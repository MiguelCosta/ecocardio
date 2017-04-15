using System;
using System.Windows.Forms;

namespace EcoCardio.WinApp.Exame
{
    public partial class UscExameEdit : UserControl
    {
        public UscExameEdit()
        {
            InitializeComponent();
            FillDropdows();
        }

        private void UscExameEdit_Load(object sender, EventArgs e)
        {
            txtNome.Focus();
        }

        private Domain.Exame Exame { get; set; }

        public void SetExame(int exameId)
        {
            Exame = GerallApp.AppRepository.Exames.Find(exameId);
            FillExame();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var newExame = GetExameInfo();
            if (this.Exame == null)
            {
                newExame.Numero = GerallApp.AppRepository.Exames.NextNumber();
                GerallApp.AppRepository.Exames.Insert(newExame);
            }
            else
            {
                newExame.Id = this.Exame.Id;
                newExame.Numero = this.Exame.Numero;
                GerallApp.AppRepository.Exames.Update(this.Exame.Id, newExame);
            }

            GerallApp.AppRepository.Complete();
            this.SetExame(newExame.Id);
            MessageBox.Show($"Exame {newExame.Numero} guardado.");
            this.ParentForm.Close();
        }

        private int CalculateAge(DateTime value)
        {
            var today = DateTime.Now;
            var age = today.Year - value.Year;
            if (value > today.AddYears(-age)) age--;
            return age;
        }

        private void FillDropdows()
        {
            servicoBindingSource.DataSource = GerallApp.AppRepository.Servicos.GetAll();
            transmissaoAcusticaBindingSource.DataSource = GerallApp.AppRepository.TransmissoesAcusticas.GetAll();
            templateBindingSourceCavidadesCardiacas.DataSource = GerallApp.AppRepository.Templates.GetByType(Domain.Enums.TemplateType.CavidadesCardiacas);
            templateBindingSourceEspessuraParedes.DataSource = GerallApp.AppRepository.Templates.GetByType(Domain.Enums.TemplateType.EspessuraParedesVentriculares);
            templateBindingSourceEstruturasValvulares.DataSource = GerallApp.AppRepository.Templates.GetByType(Domain.Enums.TemplateType.EstruturasValvulares);
            templateBindingSourceFuncaoVentricular.DataSource = GerallApp.AppRepository.Templates.GetByType(Domain.Enums.TemplateType.FuncaoVentricular);
            templateBindingSourceMassasIntracavitarias.DataSource = GerallApp.AppRepository.Templates.GetByType(Domain.Enums.TemplateType.MassasIntracavitarias);
            templateBindingSourcePericardio.DataSource = GerallApp.AppRepository.Templates.GetByType(Domain.Enums.TemplateType.Pericardio);
            templateBindingSourceConclusao.DataSource = GerallApp.AppRepository.Templates.GetByType(Domain.Enums.TemplateType.Conclusao);
            servicoBindingSource.ResetBindings(false);
            transmissaoAcusticaBindingSource.ResetBindings(false);
            templateBindingSourceCavidadesCardiacas.ResetBindings(false);
            templateBindingSourceEspessuraParedes.ResetBindings(false);
            templateBindingSourceEstruturasValvulares.ResetBindings(false);
            templateBindingSourceFuncaoVentricular.ResetBindings(false);
            templateBindingSourceMassasIntracavitarias.ResetBindings(false);
            templateBindingSourcePericardio.ResetBindings(false);
            templateBindingSourceConclusao.ResetBindings(false);
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
            rdbFeminino.Checked = Exame.Genre == Domain.Enums.Genre.Fem;
            rdbMasculino.Checked = Exame.Genre == Domain.Enums.Genre.Masc;

            // Informacao do Exame
            txtExame.Text = Exame.Numero.ToString();
            dtpDataExame.Value = Exame.Data;
            cmbRequisitadoPor.SelectedValue = Exame.RequisitadoPor;
            cmbTransmissaoAcustica.SelectedValue = Exame.TransmissaoAcustica;
            txtInfoClinica.Text = Exame.InfoClinica;

            // Dimensoes
            txtRaizAorta.Text = Exame.DiametroAorta.ToString();
            txtAuriculaEsquerda.Text = Exame.DiametroAuriculaEsquerda.ToString();
            txtVEtelediastole.Text = Exame.DiametroVETeleadiastole.ToString();
            txtVEtelessistole.Text = Exame.DiametroVETelessistole.ToString();
            txtFracaoEncurtamento.Text = Exame.FracaoEncurtamento.ToString();
            txtSepto.Text = Exame.DiametroSepto.ToString();
            txtParedeSuperior.Text = Exame.DiametroParedePosterior.ToString();
            txtFracaoEjecao.Text = Exame.FracaoEjecao.ToString();

            // Text info
            txtEstruturasValvulares.Text = Exame.EstruturasValvulares;
            txtCavidadesCardiacas.Text = Exame.CavidadesCardiacas;
            txtEspessuraParedes.Text = Exame.EspessuraParedesVentriculares;
            txtFuncaoVentricular.Text = Exame.FuncaoVentricular;
            txtMassasIntracavitarias.Text = Exame.MassasIntracavitarias;
            txtPericardico.Text = Exame.Pericardio;

            // Final
            txtConclusao.Text = Exame.Conclusao;
            cmbCardiologista1.Text = Exame.Medico1;
            cmbCardiologista2.Text = Exame.Medico2;
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
            result.RequisitadoPor = cmbRequisitadoPor.Text;
            result.TransmissaoAcustica = cmbTransmissaoAcustica.Text;
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

        #region "Dropdowns"

        private void btnAddCavidadesCardiacas_Click(object sender, EventArgs e)
        {
            SetTextTemplate(cmbCavidadesCardiacas, txtCavidadesCardiacas);
        }

        private void btnAddEstruturasValvulares_Click(object sender, EventArgs e)
        {
            SetTextTemplate(cmbEstrutrasValvulares, txtEstruturasValvulares);
        }

        private void btnAddFuncaoVentricular_Click(object sender, EventArgs e)
        {
            SetTextTemplate(cmbFuncaoVentricular, txtFuncaoVentricular);
        }

        private void btnAddMassasIntracavitarias_Click(object sender, EventArgs e)
        {
            SetTextTemplate(cmbMassasIntracavitarias, txtMassasIntracavitarias);
        }

        private void btnAddPericardico_Click(object sender, EventArgs e)
        {
            SetTextTemplate(cmbPericardico, txtPericardico);
        }

        private void btnEspessuraParedes_Click(object sender, EventArgs e)
        {
            SetTextTemplate(cmbEspessuraParedes, txtEspessuraParedes);
        }

        private void btnConclusao_Click(object sender, EventArgs e)
        {
            SetTextTemplate(cmbConclusao, txtConclusao);
        }

        private void SetTextTemplate(ComboBox cmb, TextBox txt)
        {
            if (cmb.SelectedItem != null)
            {
                var item = cmb.SelectedItem as Domain.Template;
                txt.Text = item.Texto;
            }
        }

        #endregion "Dropdowns"

    }
}
