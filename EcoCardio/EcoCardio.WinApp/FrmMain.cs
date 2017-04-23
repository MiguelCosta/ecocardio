using System;
using System.Windows.Forms;

namespace EcoCardio.WinApp
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
            this.Load += FrmMain_Load;
            mnuGeral_Exit.Click += mnuGeral_Exit_Click;
        }

        #region "FormMain"

        private void FrmMain_Load(object sender, EventArgs e)
        {
            // Inicia a ligação à base de dados
            GerallApp.AppRepository = new Repository.Implementation.AppUnitOfWork();

            // mostrar o splash screen
            var splash = new FrmAutentication();
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

        private void mnuGeral_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion "FormMain Actions"

        #region "ShowForms"

        private void ShowFormInit()
        {
            var frm = new FrmSearch();
            frm.MdiParent = this;
            frm.Show();
        }

        #endregion "ShowForms"

        private void mnuServicos_Click(object sender, EventArgs e)
        {
            var frm = new Servico.FrmServicoList();
            frm.ShowDialog();
        }

        private void mnuTemplates_Click(object sender, EventArgs e)
        {
            var frm = new Template.FrmTemplateList();
            frm.ShowDialog();
        }
    }
}
