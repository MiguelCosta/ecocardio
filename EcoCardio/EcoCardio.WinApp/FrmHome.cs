using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;

using System.Text;
using System.Windows.Forms;

namespace EcoCardio.WinApp
{
    public partial class FrmHome : Syncfusion.Windows.Forms.MetroForm
    {
        public FrmHome()
        {
            InitializeComponent();
        }

        private void FrmHome_Load(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            int numero = 0;
            int.TryParse(txtSearchNumero.Text, out numero);
            var results = GerallApp.AppRepository.Exames.Search(txtSearchNome.Text, numero);

            exameBindingSource.DataSource = results;

        }
    }
}
