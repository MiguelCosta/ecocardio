using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EcoCardio.WinApp
{
    public partial class FrmSearch : Form
    {
        public FrmSearch()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            int numero = 0;
            int.TryParse(txtSearchNumero.Text, out numero);
            var results = GerallApp.AppRepository.Exames.Search(txtSearchNome.Text, numero);

            exameBindingSource.DataSource = results;
        }

        private void btnCriarRegisto_Click(object sender, EventArgs e)
        {
            Exame.FrmExameNew.Open();
        }
    }
}
