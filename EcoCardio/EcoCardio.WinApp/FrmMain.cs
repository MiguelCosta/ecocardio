using System;

namespace EcoCardio.WinApp
{
    public partial class FrmMain : Syncfusion.Windows.Forms.MetroForm
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        #region "FormMain"

        private void FrmMain_Load(object sender, EventArgs e)
        {
            // Inicia a ligação à base de dados
            GerallApp.AppRepository = new Repository.Implementation.AppUnitOfWork();

            // mostrar o splash screen
            var splash = new FrmLogin();
            var result = splash.ShowDialog();
            if (result != System.Windows.Forms.DialogResult.OK)
            {
                // se não foi possível fazer login fecha a aplicação
                this.Close();
            }
            else
            {
                ShowFormInit();
            }
        }

        #endregion "FormMain"

        #region "FormMain Actions"

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            ShowFormHome();
        }

        #endregion "FormMain Actions"

        #region "ShowForms"

        private void ShowFormHome()
        {
        }

        private void ShowFormInit()
        {
            lblUser.Text = GerallApp.CurrentUser.Nome;

            var frm = new FrmHome();
            frm.MdiParent = this;
            frm.Show();
        }

        #endregion "ShowForms"
    }
}
