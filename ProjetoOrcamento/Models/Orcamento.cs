using ProjetoOrcamento.Deita;

public class Orcamento
{
    public Guid Id { get; set; }

    public Cliente Cliente { get; set; }

    public List<ItemOrcamento> Itens { get; set; }

    public StatusOrcamento Status { get; private set; }

    public int? NumeroPedido { get; private set; }

    public string MotivoRejeicao { get; private set; }

    public DateTime DataCriacao { get; set; }

    public Orcamento()
    {
        Id = Guid.NewGuid();
        Itens = new List<ItemOrcamento>();
        Status = StatusOrcamento.Pendente;
        DataCriacao = DateTime.Now;
    }

    public decimal CalcularTotal()
    {
        decimal total = 0;

        foreach (ItemOrcamento item in Itens)
        {
            total += item.Subtotal;
        }

        return total;
    }

    public void Aprovar()
    {
        if (Itens.Count == 0)
            throw new InvalidOperationException("Orçamento não pode ser aprovado sem itens.");

        Status = StatusOrcamento.Aprovado;
        NumeroPedido = Dados.ProximoNumeroPedido;
        Dados.ProximoNumeroPedido++;
    }

    public void Rejeitar(string motivo)
    {
        if (string.IsNullOrWhiteSpace(motivo))
            throw new InvalidOperationException("Motivo da rejeição é obrigatório.");

        Status = StatusOrcamento.Rejeitado;
        MotivoRejeicao = motivo;
    }
}