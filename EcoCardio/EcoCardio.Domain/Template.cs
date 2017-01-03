namespace EcoCardio.Domain
{
    public class Template
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public string Texto { get; set; }

        public Enums.TemplateType Type { get; set; }
    }
}
