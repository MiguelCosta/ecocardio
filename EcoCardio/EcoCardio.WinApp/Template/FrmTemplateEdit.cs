using System;
using System.Windows.Forms;

namespace EcoCardio.WinApp.Template
{
    public partial class FrmTemplateEdit : Form
    {
        private Domain.Template _template = null;

        public FrmTemplateEdit()
        {
            InitializeComponent();
        }

        public static void Create()
        {
            var frm = new FrmTemplateEdit();
            frm.ShowDialog();
        }

        public static void Edit(int templateId)
        {
            var frm = new FrmTemplateEdit();
            frm.SetTemplate(templateId);
            frm.ShowDialog();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var template = GetTemplate();

            if (_template == null)
            {
                GerallApp.AppRepository.Templates.Insert(template);
            }
            else
            {
                template.Id = _template.Id;
                GerallApp.AppRepository.Templates.Update(template.Id, template);
            }
            GerallApp.AppRepository.Complete();
            SetTemplate(template.Id);
            MessageBox.Show($"Template guardado.");
            this.Close();
        }

        private void FillTemplate()
        {
            txtNomeTemplate.Text = _template.Nome;
            txtTemplateTexto.Text = _template.Texto;
            switch (_template.Type)
            {
                case Domain.Enums.TemplateType.CavidadesCardiacas:
                    rbtCavidadesCardiacas.Checked = true;
                    break;

                case Domain.Enums.TemplateType.EspessuraParedesVentriculares:
                    rbtEspessuraParedes.Checked = true;
                    break;

                case Domain.Enums.TemplateType.EstruturasValvulares:
                    rbtEstruturasValvulares.Checked = true;
                    break;

                case Domain.Enums.TemplateType.FuncaoVentricular:
                    rbtFuncaoVentricular.Checked = true;
                    break;

                case Domain.Enums.TemplateType.Pericardio:
                    rbtPericardio.Checked = true;
                    break;

                case Domain.Enums.TemplateType.MassasIntracavitarias:
                    rbtMassasIntracavitarias.Checked = true;
                    break;

                case Domain.Enums.TemplateType.Conclusao:
                    rbtConclusao.Checked = true;
                    break;

                default:
                    break;
            }
        }

        private Domain.Template GetTemplate()
        {
            var template = new Domain.Template();
            template.Nome = txtNomeTemplate.Text;
            template.Texto = txtTemplateTexto.Text;
            template.Type =
                rbtCavidadesCardiacas.Checked ? Domain.Enums.TemplateType.CavidadesCardiacas :
                rbtEspessuraParedes.Checked ? Domain.Enums.TemplateType.EspessuraParedesVentriculares :
                rbtEstruturasValvulares.Checked ? Domain.Enums.TemplateType.EstruturasValvulares :
                rbtFuncaoVentricular.Checked ? Domain.Enums.TemplateType.FuncaoVentricular :
                rbtMassasIntracavitarias.Checked ? Domain.Enums.TemplateType.MassasIntracavitarias :
                rbtConclusao.Checked ? Domain.Enums.TemplateType.Conclusao :
                Domain.Enums.TemplateType.Pericardio;
            return template;
        }

        private void SetTemplate(int templateId)
        {
            _template = GerallApp.AppRepository.Templates.Find(templateId);
            FillTemplate();
        }
    }
}
