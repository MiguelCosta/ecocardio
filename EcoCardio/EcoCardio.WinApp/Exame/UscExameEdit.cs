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

        private void btnSave_Click(object sender, EventArgs e)
        {
            var newExame = GetExameInfo();
            if (this.Exame == null )
            {
                GerallApp.AppRepository.Exames.Insert(newExame);
            }
            else
            {
                newExame.Id = this.Exame.Id;
                GerallApp.AppRepository.Exames.Update(this.Exame.Id, newExame);
            }

            GerallApp.AppRepository.Complete();
            this.SetExame(newExame.Id);
        }

        private Domain.Exame GetExameInfo()
        {
            var result = new Domain.Exame();

            // Identificacao
            result.Nome = txtNome.Text;
            if (dtpDataNascimento.Checked)
            {
                result.DataNascimento = dtpDataNascimento.Value;
                result.Idade = CalculateAge(dtpDataNascimento.Value);
            }
            result.Genre = rdbFeminino.Checked ? Domain.Enums.Genre.Fem : Domain.Enums.Genre.Masc;


            // Informação do Exame
            result.Data = dtpDataExame.Value;
            result.RequisitadoPor = cmbRequisitadoPor.SelectedText;
            result.TransmissaoAcustica = cmbTransmissaoAcustica.SelectedText;
            result.InfoClinica = txtInfoClinica.Text;

            // Dimensoes
            result.DiametroAorta = GetIntFromTextBox(txtRaizAorta);
            result.DiametroAuriculaEsquerda = GetIntFromTextBox(txtAuriculaEsquerda);
            result.DiametroVETeleadiastole = GetIntFromTextBox(txtVEtelediastole);
            result.DiametroVETelessistole = GetIntFromTextBox(txtVEtelessistole);
            result.FracaoEncurtamento = GetIntFromTextBox(txtFracaoEncurtamento);
            result.DiametroSepto = GetIntFromTextBox(txtSepto);
            result.DiametroParedePosterior = GetIntFromTextBox(txtParedeSuperior);
            result.FracaoEjecao = GetIntFromTextBox(txtFracaoEjecao);

            // Text info
            result.EstruturasValvulares = txtEstruturasValvulares.Text;
            result.CavidadesCardiacas = txtCavidadesCardiacas.Text;
            result.EspessuraParedesVentriculares = txtEspessuraParedes.Text;
            result.FuncaoVentricular = txtFuncaoVentricular.Text;
            result.MassasIntracavitarias = txtMassasIntracavitarias.Text;
            result.Pericardio = txtPericardico.Text;

            // Final
            result.Conclusao = txtConclusao.Text;
            result.Medico1 = cmbCardiologista1.Text;
            result.Medico2 = cmbCardiologista2.Text;

            return result;
        }

        private int? GetIntFromTextBox(TextBox textBox)
        {
            int result;
            if (int.TryParse(textBox.Text, out result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }

        private int CalculateAge(DateTime value)
        {
            var today = DateTime.Now;
            var age = today.Year - value.Year;
            if (value > today.AddYears(-age)) age--;
            return age;
        }
    }
}
