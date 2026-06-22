using ProjetoOrcamento.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ProjetoOrcamento.Services
{
    internal sealed class ClienteService
    {
        private readonly IClienteRepository _repository;

        public ClienteService()
            : this(new SqliteClienteRepository())
        {
        }

        public ClienteService(IClienteRepository repository)
        {
            _repository = repository;
        }

        public IReadOnlyList<Cliente> ObterTodos()
        {
            return _repository.ObterTodos();
        }

        public IReadOnlyList<Cliente> Pesquisar(string termo)
        {
            if (string.IsNullOrWhiteSpace(termo))
                return ObterTodos().ToList();

            return ObterTodos()
                .Where(cliente =>
                    Contem(cliente.Nome, termo)
                    || Contem(cliente.Contato, termo)
                    || Contem(cliente.Cpf, termo)
                    || Contem(cliente.Cep, termo)
                    || Contem(cliente.Endereco, termo)
                    || Contem(cliente.Observacoes, termo))
                .ToList();
        }

        public void Salvar(Cliente cliente, int indexEmEdicao)
        {
            Validar(cliente);

            if (indexEmEdicao >= 0)
            {
                _repository.Atualizar(indexEmEdicao, cliente);
                return;
            }

            _repository.Adicionar(cliente);
        }

        public void Remover(Cliente cliente)
        {
            var index = _repository.ObterIndex(cliente);

            if (index >= 0)
                _repository.Remover(index);
        }

        public int ObterIndex(Cliente cliente)
        {
            return _repository.ObterIndex(cliente);
        }

        private static void Validar(Cliente cliente)
        {
            if (string.IsNullOrWhiteSpace(cliente.Nome))
                throw new InvalidOperationException("Informe o nome do cliente.");

            if (string.IsNullOrWhiteSpace(cliente.Contato))
                throw new InvalidOperationException("Informe o telefone do cliente.");
        }

        private static bool Contem(string? texto, string termo)
        {
            return !string.IsNullOrWhiteSpace(texto)
                && texto.Contains(termo, StringComparison.OrdinalIgnoreCase);
        }
    }
}
