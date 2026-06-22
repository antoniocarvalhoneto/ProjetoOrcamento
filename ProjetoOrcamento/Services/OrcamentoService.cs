using ProjetoOrcamento.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ProjetoOrcamento.Services
{
    internal sealed class OrcamentoService
    {
        private readonly IOrcamentoRepository _repository;

        public OrcamentoService()
            : this(new SqliteOrcamentoRepository())
        {
        }

        public OrcamentoService(IOrcamentoRepository repository)
        {
            _repository = repository;
        }

        public IReadOnlyList<Orcamento> ObterTodos()
        {
            return _repository.ObterTodos();
        }

        public IReadOnlyList<Orcamento> Pesquisar(string termo, StatusOrcamento? status)
        {
            var consulta = ObterTodos().AsEnumerable();

            if (status.HasValue)
                consulta = consulta.Where(orcamento => orcamento.Status == status.Value);

            if (!string.IsNullOrWhiteSpace(termo))
            {
                consulta = consulta.Where(orcamento =>
                    Contem(orcamento.Cliente?.Nome, termo)
                    || Contem(orcamento.Status.ToString(), termo)
                    || Contem(orcamento.NumeroPedido > 0 ? orcamento.NumeroPedido.ToString() : string.Empty, termo)
                    || Contem(orcamento.MotivoRejeicao, termo));
            }

            return consulta.ToList();
        }

        public Orcamento? ObterPorId(Guid id)
        {
            return _repository.ObterPorId(id);
        }

        public void Criar(Orcamento orcamento)
        {
            if (orcamento.Cliente == null)
                throw new InvalidOperationException("Selecione um cliente.");

            if (orcamento.Itens.Count == 0)
                throw new InvalidOperationException("Adicione pelo menos um item ao orçamento.");

            _repository.Adicionar(orcamento);
        }

        public void Aprovar(Orcamento orcamento)
        {
            if (orcamento.Status != StatusOrcamento.Pendente)
                throw new InvalidOperationException($"Orçamento já foi {orcamento.Status.ToString().ToLower()}.");

            var proximoNumeroPedido = _repository.ObterProximoNumeroPedido();
            orcamento.Aprovar(proximoNumeroPedido);
            _repository.Atualizar(orcamento);
            _repository.AtualizarProximoNumeroPedido(proximoNumeroPedido + 1);
        }

        public void Rejeitar(Orcamento orcamento, string motivo)
        {
            if (orcamento.Status != StatusOrcamento.Pendente)
                throw new InvalidOperationException($"Orçamento já foi {orcamento.Status.ToString().ToLower()}.");

            orcamento.Rejeitar(motivo);
            _repository.Atualizar(orcamento);
        }

        private static bool Contem(string? texto, string termo)
        {
            return !string.IsNullOrWhiteSpace(texto)
                && texto.Contains(termo, StringComparison.OrdinalIgnoreCase);
        }
    }
}
