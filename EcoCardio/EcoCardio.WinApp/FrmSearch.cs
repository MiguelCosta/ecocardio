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
        }

        private void btnEditarRegisto_Click(object sender, EventArgs e)
        {
            if (dgvExames.CurrentRow != null)
            {
                Domain.Exame exame = (Domain.Exame)dgvExames.CurrentRow.DataBoundItem;
                Exame.FrmExameNew.Open(exame.Id);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            int numero = 0;
            int.TryParse(txtSearchNumero.Text, out numero);
            var results = GerallApp.AppRepository.Exames.Search(txtSearchNome.Text, numero);

            exameBindingSource.DataSource = results;
        }

        private void dgvExames_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Domain.Exame exame = (Domain.Exame)dgvExames.Rows[e.RowIndex].DataBoundItem;
            Exame.FrmExameNew.Open(exame.Id);
        }

        private void FrmSearch_Load(object sender, EventArgs e)
        {
            var results = GerallApp.AppRepository.Exames.MostRecent(100);

            exameBindingSource.DataSource = results;
        }
    }
}
