public class ItemOrcamento
{
    public Servico Servico { get; set; }

    public int Quantidade { get; set; }

    public decimal Subtotal
    {
        get
        {
            return Servico.PrecoUnitario * Quantidade;
        }
    }
}