using System;
using System.Collections.Generic;

namespace ProjetoOrcamento.Repositories
{
    internal interface IOrcamentoRepository
    {
        IReadOnlyList<Orcamento> ObterTodos();
        Orcamento? ObterPorId(Guid id);
        void Adicionar(Orcamento orcamento);
        void Atualizar(Orcamento orcamento);
        void Remover(Guid id);
        int ObterProximoNumeroPedido();
        void AtualizarProximoNumeroPedido(int proximoNumeroPedido);
    }
}
