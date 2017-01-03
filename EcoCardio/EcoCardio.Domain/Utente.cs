using System;
using System.Collections.Generic;

namespace EcoCardio.Domain
{
    public class Utente
    {
        public DateTime DataNascimento { get; set; }

        public string Email { get; set; }

        public virtual ICollection<Exame> Exames { get; set; }

        public string FirstName { get; set; }

        public Enums.Genre Genre { get; set; }

        public int Id { get; set; }

        public string LastName { get; set; }

        public string Morada { get; set; }

        public string Nome { get; set; }

        public int NumeroProcesso { get; set; }

        public string NumeroSNS { get; set; }

        public string Telefone { get; set; }

        public string Telemovel { get; set; }
    }
}
