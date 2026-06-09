using ProjetoOrcamento.Deita;

public class Orcamento
{
    public Cliente Cliente { get; set; }

    public List<ItemOrcamento> Itens { get; set; }

    public StatusOrcamento Status { get; private set; }

    public int? NumeroPedido { get; private set; }

    public string MotivoRejeicao { get; private set; }

    public Orcamento()
    {
        Itens = new List<ItemOrcamento>();

        Status = StatusOrcamento.Pendente;
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
        Status = StatusOrcamento.Aprovado;

        NumeroPedido = Dados.ProximoNumeroPedido;

        Dados.ProximoNumeroPedido++;
    }

    public void Rejeitar(string motivo)
    {
        Status = StatusOrcamento.Rejeitado;

        MotivoRejeicao = motivo;
    }
}