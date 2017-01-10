#region Copyright Syncfusion Inc. 2001 - 2016

// Copyright Syncfusion Inc. 2001 - 2016. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 

#endregion Copyright Syncfusion Inc. 2001 - 2016

using System;
using System.Windows.Forms;

namespace EcoCardio.WinApp
{
    public partial class FrmLogin : Syncfusion.Windows.Forms.MetroForm
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            MdiParent.Close();
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
                Close();
            }
        }
    }
}
