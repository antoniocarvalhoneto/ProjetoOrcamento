using System.Collections.Generic;

namespace ProjetoOrcamento.Repositories
{
    internal interface IClienteRepository
    {
        IReadOnlyList<Cliente> ObterTodos();
        void Adicionar(Cliente cliente);
        void Atualizar(int index, Cliente cliente);
        void Remover(int index);
        int ObterIndex(Cliente cliente);
    }
}
