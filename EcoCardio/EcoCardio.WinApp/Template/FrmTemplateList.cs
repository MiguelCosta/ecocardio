using System;
using System.Windows.Forms;

namespace EcoCardio.WinApp.Template
{
    public partial class FrmTemplateList : Form
    {
        public FrmTemplateList()
        {
            InitializeComponent();
        }

        private void dgvListaTemplates_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Edit();
        }

        private void FrmTemplateList_Load(object sender, EventArgs e)
        {
            Fill();
        }

        #region "Buttons actions"

        private void btnCreate_Click(object sender, EventArgs e)
        {
            FrmTemplateEdit.Create();
            Fill();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvListaTemplates.CurrentRow != null)
            {
                var item = dgvListaTemplates.CurrentRow.DataBoundItem as Domain.Template;
                GerallApp.AppRepository.Templates.Delete(item.Id);
                GerallApp.AppRepository.Complete();
                Fill();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Edit();
        }

        #endregion "Buttons actions"

        #region "Actions"

        private void Edit()
        {
            if (dgvListaTemplates.CurrentRow != null)
            {
                var item = dgvListaTemplates.CurrentRow.DataBoundItem as Domain.Template;
                FrmTemplateEdit.Edit(item.Id);
                Fill();
            }
        }

        private void Fill()
        {
            templateBindingSource.DataSource = GerallApp.AppRepository.Templates.GetAll();
            templateBindingSource.ResetBindings(false);
        }

        #endregion "Actions"
    }
}
