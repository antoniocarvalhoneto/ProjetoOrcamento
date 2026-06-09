public class Servico
{
    public string Nome { get; set; }
    public decimal PrecoUnitario { get; set; }

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