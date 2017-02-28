using System;
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

        public void SetExame(int exameId)
        {
            Exame = GerallApp.AppRepository.Exames.Find(exameId);
            FillExame();
        }

        private void FillExame()
        {
            //identificacao
            txtNome.Text = Exame.Nome;
            if (Exame.DataNascimento.HasValue)
            {
                dtpDataNascimento.Value = Exame.DataNascimento.Value;
                dtpDataNascimento.Checked = true;
            }
            else
            {
                dtpDataNascimento.Value = DateTime.Now;
                dtpDataNascimento.Checked = false;
            }
            txtIdade.Text = Exame.Idade?.ToString();
        }
    }
}
