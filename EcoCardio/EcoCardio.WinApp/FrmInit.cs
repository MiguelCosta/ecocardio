using System;
using System.Windows.Forms;

namespace EcoCardio.WinApp
{
    public partial class FrmInit : Form
    {
        public FrmInit()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string nome = txtSearchNome.Text;
            int numero;
            int.TryParse(txtSearchNumeroProcesso.Text, out numero);

            var results = GerallApp.AppRepository.Exames.Search(txtSearchNome.Text, numero);
        }
    }
}
