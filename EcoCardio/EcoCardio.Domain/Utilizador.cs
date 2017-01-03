namespace EcoCardio.Domain
{
    public class Utilizador
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public string Password { get; set; }

        public string Username { get; set; }

        public Enums.ProfileType Profile { get; set; }
    }
}
