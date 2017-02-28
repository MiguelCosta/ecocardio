using System.Windows.Forms;

namespace EcoCardio.WinApp.Exame
{
    public partial class UscExameEdit : UserControl
    {
        public UscExameEdit()
        {
            InitializeComponent();
        }

        private Domain.Exame Exame { get; set; }

        private Domain.Utente Utente { get; set; }

        public void SetExame(int exameId)
        {
            Exame = GerallApp.AppRepository.Exames.Find(exameId);
            if (Exame.UtenteId.HasValue)
            {
                Utente = GerallApp.AppRepository.Utentes.Find(Exame.UtenteId.Value);
            }
            else
            {
                Utente = new Domain.Utente();
            }
            FillExame();
        }

        private void FillExame()
        {
            //identificacao
            txtNome.Text = Exame.Nome;
            dtpDataNascimento.Value = Utente.DataNascimento;
            txtIdade.Text = Exame.Idade?.ToString();
        }
    }
}
