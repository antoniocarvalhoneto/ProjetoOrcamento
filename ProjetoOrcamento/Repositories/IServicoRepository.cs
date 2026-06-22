using System.Collections.Generic;

namespace ProjetoOrcamento.Repositories
{
    internal interface IServicoRepository
    {
        IReadOnlyList<Servico> ObterTodos();
        void Adicionar(Servico servico);
        void Atualizar(int index, Servico servico);
        void Remover(int index);
        int ObterIndex(Servico servico);
    }
}
