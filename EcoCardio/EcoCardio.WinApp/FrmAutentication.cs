using System;
using System.Windows.Forms;

namespace EcoCardio.WinApp
{
    public partial class FrmAutentication : Form
    {
        public FrmAutentication()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            // verificar na base de dados se o utilizador existe
            var user = GerallApp.AppRepository.Utilizadores.FindByUsernameAndPassword(username, password);

            if (user == null)
            {
                MessageBox.Show("Username ou passoword inválidos!");
            }
            else
            {
                GerallApp.CurrentUser = user;
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
