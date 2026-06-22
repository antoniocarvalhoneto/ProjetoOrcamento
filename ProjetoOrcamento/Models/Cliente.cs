public class Cliente
{
    public int Id { get; set; }
    public string Nome { get; set; } = string.Empty;
    public string Contato { get; set; } = string.Empty;
    public string Cpf { get; set; } = string.Empty;
    public string Cep { get; set; } = string.Empty;
    public string Endereco { get; set; } = string.Empty;
    public string Observacoes { get; set; } = string.Empty;

    public Cliente()
    {
    }

    public Cliente(
        string nome,
        string contato,
        string cpf = "",
        string cep = "",
        string endereco = "",
        string observacoes = "")
    {
        Nome = nome;
        Contato = contato;
        Cpf = cpf;
        Cep = cep;
        Endereco = endereco;
        Observacoes = observacoes;
    }

    public override string ToString()
    {
        return Nome;
    }
}
