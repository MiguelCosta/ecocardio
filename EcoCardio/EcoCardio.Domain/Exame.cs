using System;

namespace EcoCardio.Domain
{
    public class Exame
    {
        public string CavidadesCardiacas { get; set; }

        public string Conclusao { get; set; }

        public DateTime Data { get; set; }

        public DateTime? DataNascimento { get; set; }

        public int? DiametroAorta { get; set; }

        public int? DiametroAuriculaEsquerda { get; set; }

        public int? DiametroParedePosterior { get; set; }

        public int? DiametroSepto { get; set; }

        public int? DiametroVETeleadiastole { get; set; }

        public int? DiametroVETelessistole { get; set; }

        public string Email { get; set; }

        public string EspessuraParedesVentriculares { get; set; }

        public string EstruturasValvulares { get; set; }

        public string FirstName { get; set; }

        public int? FracaoEjecao { get; set; }

        public int? FracaoEncurtamento { get; set; }

        public string FuncaoVentricular { get; set; }

        public int Id { get; set; }

        public int? Idade { get; set; }

        public string LastName { get; set; }

        public string MassasIntracavitarias { get; set; }

        public string Morada { get; set; }

        public string Nome { get; set; }

        public int Numero { get; set; }

        public int? NumeroProcesso { get; set; }

        public string NumeroSNS { get; set; }

        public string Observacao { get; set; }

        public virtual Servico Servico { get; set; }

        public int? ServicoId { get; set; }

        public string Telefone { get; set; }

        public string Telemovel { get; set; }

        public virtual TransmissaoAcustica TransmissaoAcustica { get; set; }

        public int? TransmissaoAcusticaId { get; set; }
    }
}
