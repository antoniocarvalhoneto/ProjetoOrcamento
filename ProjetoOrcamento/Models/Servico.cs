public class Servico
{
    public int Id { get; set; }
    public string Nome { get; set; } = string.Empty;
    public decimal PrecoUnitario { get; set; }

    public Servico()
    {
    }

    public Servico(string nome, decimal preco)
    {
        Nome = nome;
        PrecoUnitario = preco;
    }

    public override string ToString()
    {
        return Nome;
    }
}
