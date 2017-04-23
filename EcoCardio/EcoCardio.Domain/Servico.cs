namespace EcoCardio.Domain
{
    public class Servico
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public Enums.ServicoType Tipo { get; set; }
    }
}
