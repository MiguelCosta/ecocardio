using System.Collections.Generic;

namespace EcoCardio.Domain
{
    public class TransmissaoAcustica
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public virtual ICollection<Exame> Exames { get; set; }

    }
}
