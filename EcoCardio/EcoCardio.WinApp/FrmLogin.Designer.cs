#region Copyright Syncfusion Inc. 2001 - 2016
// Copyright Syncfusion Inc. 2001 - 2016. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
namespace EcoCardio.WinApp
{
    partial class FrmLogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.picLogin = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.autoLabel1 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.txtUsername = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.txtPassword = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.autoLabel2 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.btnLogin = new Syncfusion.Windows.Forms.ButtonAdv();
            this.btnExit = new Syncfusion.Windows.Forms.ButtonAdv();
            ((System.ComponentModel.ISupportInitialize)(this.picLogin)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtUsername)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassword)).BeginInit();
            this.SuspendLayout();
            // 
            // picLogin
            // 
            this.picLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.picLogin.Image = ((System.Drawing.Image)(resources.GetObject("picLogin.Image")));
            this.picLogin.Location = new System.Drawing.Point(56, 9);
            this.picLogin.Margin = new System.Windows.Forms.Padding(0);
            this.picLogin.Name = "picLogin";
            this.picLogin.Size = new System.Drawing.Size(272, 121);
            this.picLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picLogin.TabIndex = 5;
            this.picLogin.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnExit);
            this.groupBox1.Controls.Add(this.btnLogin);
            this.groupBox1.Controls.Add(this.txtPassword);
            this.groupBox1.Controls.Add(this.autoLabel2);
            this.groupBox1.Controls.Add(this.txtUsername);
            this.groupBox1.Controls.Add(this.autoLabel1);
            this.groupBox1.Location = new System.Drawing.Point(12, 158);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(362, 149);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Login";
            // 
            // autoLabel1
            // 
            this.autoLabel1.DY = -17;
            this.autoLabel1.LabeledControl = this.txtUsername;
            this.autoLabel1.Location = new System.Drawing.Point(6, 20);
            this.autoLabel1.Name = "autoLabel1";
            this.autoLabel1.Position = Syncfusion.Windows.Forms.Tools.AutoLabelPosition.Top;
            this.autoLabel1.Size = new System.Drawing.Size(55, 13);
            this.autoLabel1.TabIndex = 0;
            this.autoLabel1.Text = "Username";
            // 
            // txtUsername
            // 
            this.txtUsername.BeforeTouchSize = new System.Drawing.Size(350, 20);
            this.txtUsername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUsername.Location = new System.Drawing.Point(6, 37);
            this.txtUsername.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(350, 20);
            this.txtUsername.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtUsername.TabIndex = 1;
            this.txtUsername.UseBorderColorOnFocus = true;
            // 
            // txtPassword
            // 
            this.txtPassword.BeforeTouchSize = new System.Drawing.Size(350, 20);
            this.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassword.Location = new System.Drawing.Point(6, 86);
            this.txtPassword.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '●';
            this.txtPassword.Size = new System.Drawing.Size(350, 20);
            this.txtPassword.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtPassword.TabIndex = 3;
            this.txtPassword.UseBorderColorOnFocus = true;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // autoLabel2
            // 
            this.autoLabel2.DY = -17;
            this.autoLabel2.LabeledControl = this.txtPassword;
            this.autoLabel2.Location = new System.Drawing.Point(6, 69);
            this.autoLabel2.Name = "autoLabel2";
            this.autoLabel2.Position = Syncfusion.Windows.Forms.Tools.AutoLabelPosition.Top;
            this.autoLabel2.Size = new System.Drawing.Size(53, 13);
            this.autoLabel2.TabIndex = 2;
            this.autoLabel2.Text = "Password";
            // 
            // btnLogin
            // 
            this.btnLogin.BeforeTouchSize = new System.Drawing.Size(75, 23);
            this.btnLogin.IsBackStageButton = false;
            this.btnLogin.Location = new System.Drawing.Point(7, 113);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 23);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "Entrar";
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnExit
            // 
            this.btnExit.BeforeTouchSize = new System.Drawing.Size(75, 23);
            this.btnExit.IsBackStageButton = false;
            this.btnExit.Location = new System.Drawing.Point(281, 113);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Sair";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 317);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.picLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmLogin";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.ShowMaximizeBox = false;
            this.ShowMinimizeBox = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.picLogin)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtUsername)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassword)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected System.Windows.Forms.PictureBox picLogin;
        private System.Windows.Forms.GroupBox groupBox1;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtUsername;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel1;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtPassword;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel2;
        private Syncfusion.Windows.Forms.ButtonAdv btnExit;
        private Syncfusion.Windows.Forms.ButtonAdv btnLogin;
    }
}