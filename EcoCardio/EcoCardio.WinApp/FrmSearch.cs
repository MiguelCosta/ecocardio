using System;
using System.Windows.Forms;

namespace EcoCardio.WinApp
{
    public partial class FrmSearch : Form
    {
        public FrmSearch()
        {
            InitializeComponent();
        }

        private void btnCriarRegisto_Click(object sender, EventArgs e)
        {
            Exame.FrmExameNew.Open();
            FillExames();
        }

        private void btnEditarRegisto_Click(object sender, EventArgs e)
        {
            if (dgvExames.CurrentRow != null)
            {
                Domain.Exame exame = (Domain.Exame)dgvExames.CurrentRow.DataBoundItem;
                Exame.FrmExameNew.Open(exame.Id);
                FillExames();
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (dgvExames.CurrentRow != null)
            {
                var exame = (Domain.Exame)dgvExames.CurrentRow.DataBoundItem;
                var frm = new Reports.FrmReportViewer();
                frm.OpenExame(exame.Id);
                frm.ShowDialog();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvExames.CurrentRow != null)
            {
                var exame = (Domain.Exame)dgvExames.CurrentRow.DataBoundItem;

                var responde = MessageBox.Show("Tem a certeza que pretende eliminar o exame?", "Elimiar exame", MessageBoxButtons.YesNo);
                if (responde == DialogResult.Yes)
                {
                    GerallApp.AppRepository.Exames.Delete(exame.Id);
                    GerallApp.AppRepository.Complete();
                    SearchExames();
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SearchExames();   
        }

        private void dgvExames_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Domain.Exame exame = (Domain.Exame)dgvExames.Rows[e.RowIndex].DataBoundItem;
            Exame.FrmExameNew.Open(exame.Id);
            FillExames();
        }

        private void FrmSearch_Load(object sender, EventArgs e)
        {
            FillExames();
        }

        private void FillExames()
        {
            var results = GerallApp.AppRepository.Exames.MostRecent(100);

            exameBindingSource.DataSource = results;
        }

        private void SearchExames()
        {
            int numero = 0;
            int.TryParse(txtSearchNumero.Text, out numero);
            var results = GerallApp.AppRepository.Exames.Search(txtSearchNome.Text, numero);

            exameBindingSource.DataSource = results;
        }
    }
}
