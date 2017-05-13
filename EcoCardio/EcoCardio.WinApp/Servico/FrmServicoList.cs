using System;
using System.Windows.Forms;

namespace EcoCardio.WinApp.Servico
{
    public partial class FrmServicoList : Form
    {
        public FrmServicoList()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            FrmServicoEdit.Create();
            Fill();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvListaServicos.CurrentRow != null)
            {
                var item = dgvListaServicos.CurrentRow.DataBoundItem as Domain.Servico;
                GerallApp.AppRepository.Servicos.Delete(item.Id);
                GerallApp.AppRepository.Complete();
                Fill();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Edit();
        }

        private void dgvListaServicos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Edit();
        }

        private void Edit()
        {
            if (dgvListaServicos.CurrentRow != null)
            {
                var item = dgvListaServicos.CurrentRow.DataBoundItem as Domain.Servico;
                FrmServicoEdit.Edit(item.Id);
                Fill();
            }
        }

        private void Fill()
        {
            servicoBindingSource.DataSource = GerallApp.AppRepository.Servicos.GetAll();
            servicoBindingSource.ResetBindings(false);
        }

        private void FrmServicoList_Load(object sender, EventArgs e)
        {
            Fill();
        }
    }
}
