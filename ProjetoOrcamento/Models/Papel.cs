namespace ProjetoOrcamento
{
    public sealed class Papel
    {
        public const int AdminId = 1;
        public const int OperadorId = 2;
        public const int VisualizadorId = 3;

        public int Id { get; set; }
        public string Nome { get; set; } = string.Empty;

        public bool EhAdmin => Id == AdminId;
        public bool PodeAlterarDados => Id is AdminId or OperadorId;

        public override string ToString()
        {
            return Nome;
        }
    }
}
