using ProjetoOrcamento.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ProjetoOrcamento.Services
{
    internal sealed class ServicoService
    {
        private readonly IServicoRepository _repository;

        public ServicoService()
            : this(new SqliteServicoRepository())
        {
        }

        public ServicoService(IServicoRepository repository)
        {
            _repository = repository;
        }

        public IReadOnlyList<Servico> ObterTodos()
        {
            return _repository.ObterTodos();
        }

        public IReadOnlyList<Servico> Pesquisar(string termo)
        {
            if (string.IsNullOrWhiteSpace(termo))
                return ObterTodos().ToList();

            return ObterTodos()
                .Where(servico =>
                    servico.Nome.Contains(termo, StringComparison.OrdinalIgnoreCase)
                    || servico.PrecoUnitario.ToString("N2").Contains(termo, StringComparison.OrdinalIgnoreCase))
                .ToList();
        }

        public void Salvar(Servico servico, int indexEmEdicao, Usuario solicitante)
        {
            AutorizacaoService.ExigirAlteracao(solicitante, "salvar serviços");
            Validar(servico);

            if (indexEmEdicao >= 0)
            {
                _repository.Atualizar(indexEmEdicao, servico);
                return;
            }

            _repository.Adicionar(servico);
        }

        public void Remover(Servico servico, Usuario solicitante)
        {
            AutorizacaoService.ExigirAlteracao(solicitante, "excluir serviços");

            var index = _repository.ObterIndex(servico);

            if (index >= 0)
                _repository.Remover(index);
        }

        public int ObterIndex(Servico servico)
        {
            return _repository.ObterIndex(servico);
        }

        private static void Validar(Servico servico)
        {
            if (string.IsNullOrWhiteSpace(servico.Nome))
                throw new InvalidOperationException("Informe o nome do serviço.");

            if (servico.PrecoUnitario <= 0)
                throw new InvalidOperationException("Informe um preço maior que zero.");
        }
    }
}
