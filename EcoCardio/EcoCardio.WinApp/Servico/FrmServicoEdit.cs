using System;
using System.Windows.Forms;

namespace EcoCardio.WinApp.Servico
{
    public partial class FrmServicoEdit : Form
    {
        private Domain.Servico _servico = null;

        public FrmServicoEdit()
        {
            InitializeComponent();
        }

        public static void Create()
        {
            var frm = new FrmServicoEdit();
            frm.ShowDialog();
        }

        public static void Edit(int servicoId)
        {
            var frm = new FrmServicoEdit();
            frm.SetServico(servicoId);
            frm.ShowDialog();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var servico = GetServico();

            if (_servico == null)
            {
                GerallApp.AppRepository.Servicos.Insert(servico);
            }
            else
            {
                servico.Id = _servico.Id;
                GerallApp.AppRepository.Servicos.Update(servico.Id, servico);
            }
            GerallApp.AppRepository.Complete();
            SetServico(servico.Id);
            MessageBox.Show($"Serviço guardado.");
            this.Close();
        }

        private void FillServico()
        {
            txtNome.Text = _servico.Nome;
            switch (_servico.Tipo)
            {
                case Domain.Enums.ServicoType.Medico1:
                    rbtMedico1.Checked = true;
                    break;

                case Domain.Enums.ServicoType.Medico2:
                    rbtMedico2.Checked = true;
                    break;

                case Domain.Enums.ServicoType.Requisitado:
                    rbtRequisitadoPor.Checked = true;
                    break;

                default:
                    rbtNone.Checked = true;
                    break;
            }
        }

        private Domain.Servico GetServico()
        {
            var servico = new Domain.Servico();
            servico.Nome = txtNome.Text;
            servico.Tipo =
                rbtMedico1.Checked ? Domain.Enums.ServicoType.Medico1 :
                rbtMedico2.Checked ? Domain.Enums.ServicoType.Medico2 :
                rbtRequisitadoPor.Checked ? Domain.Enums.ServicoType.Requisitado :
                Domain.Enums.ServicoType.None;
            return servico;
        }

        private void SetServico(int servicoId)
        {
            _servico = GerallApp.AppRepository.Servicos.Find(servicoId);
            FillServico();
        }
    }
}
