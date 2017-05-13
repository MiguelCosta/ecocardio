using EcoCardio.Domain.Enums;
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

        public int? DiametroAortaAscendente { get; set; }

        public int? DiametroAuriculaEsquerda { get; set; }

        public int? DiametroAuriculaEsquerda1 { get; set; }

        public int? DiametroAuriculaEsquerda2 { get; set; }

        public int? DiametroFuncaoVd { get; set; }

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

        public Genre Genre { get; set; }

        public int Id { get; set; }

        public int? Idade { get; set; }

        public string InfoClinica { get; set; }

        public string LastName { get; set; }

        public string MassasIntracavitarias { get; set; }

        /// <summary>
        /// Valor calculado
        /// <see cref="CalcMassaVE"/>
        /// </summary>
        public double? MassaVE { get; set; }

        public string Medico1 { get; set; }

        public string Medico2 { get; set; }

        public string Morada { get; set; }

        public string Nome { get; set; }

        public int Numero { get; set; }

        public int? NumeroProcesso { get; set; }

        public string NumeroSNS { get; set; }

        public string Observacao { get; set; }

        public string Pericardio { get; set; }

        public string RequisitadoPor { get; set; }

        public string Telefone { get; set; }

        public string Telemovel { get; set; }

        public string TransmissaoAcustica { get; set; }

        /// <summary>
        /// http://csecho.ca/mdmath/?tag=lvmlvmi
        ///     LVEDD - VE DIASTOLE
        ///     IVSd - SEPTO IV
        ///     PWd - PAREDE POSTERIOR
        /// </summary>
        /// <returns></returns>
        public double? CalcMassaVE()
        {
            if (!DiametroVETeleadiastole.HasValue
                || !DiametroSepto.HasValue
                || !DiametroParedePosterior.HasValue)
            {
                return null;
            }

            double partial1 = Math.Pow(DiametroVETeleadiastole.Value + DiametroSepto.Value + DiametroParedePosterior.Value, 3);
            double partial2 = Math.Pow(DiametroVETeleadiastole.Value, 3);
            double result = 0.8 * (1.04 * (partial1 - partial2)) + 0.6;

            result = result / 1000;

            result = Math.Round(result, 1);

            return result;
        }
    }
}
