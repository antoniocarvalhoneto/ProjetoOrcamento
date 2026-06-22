namespace ProjetoOrcamento
{
    public sealed class Usuario
    {
        public int Id { get; set; }
        public string Nome { get; set; } = string.Empty;
        public string Login { get; set; } = string.Empty;
        public string SenhaHash { get; set; } = string.Empty;
        public Papel Papel { get; set; } = new();

        public bool EhAdmin => Papel.EhAdmin;
        public bool PodeAlterarDados => Papel.PodeAlterarDados;

        public override string ToString()
        {
            return $"{Nome} ({Papel.Nome})";
        }
    }
}
