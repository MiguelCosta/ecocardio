using System;

namespace EcoCardio.WinApp
{
    public partial class FrmMain2 : Syncfusion.Windows.Forms.MetroForm
    {
        public FrmMain2()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            ShowFormHome();
        }

        private void FrmMain2_Load(object sender, EventArgs e)
        {
            // Inicia a ligação à base de dados
            GerallApp.AppRepository = new Repository.Implementation.AppUnitOfWork();

            // coisas a fazer quando abre o form

            // mostrar o splash screen
            var splash = new FrmLogin();
            splash.ShowDialog();

            lblUser.Text = GerallApp.CurrentUser.Nome;

            // se login OK
            var frm = new FrmHome();
            frm.MdiParent = this;
            frm.Show();
        }

        private void ShowFormHome()
        {
        }
    }
}
