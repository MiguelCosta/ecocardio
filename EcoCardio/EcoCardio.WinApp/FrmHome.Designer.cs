#region Copyright Syncfusion Inc. 2001 - 2016
// Copyright Syncfusion Inc. 2001 - 2016. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
namespace EcoCardio.WinApp
{
    partial class FrmHome
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.autoLabel1 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.autoLabel2 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.txtSearchNome = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.txtSearchNumero = new Syncfusion.Windows.Forms.Tools.IntegerTextBox();
            this.btnSearch = new Syncfusion.Windows.Forms.ButtonAdv();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnCriarRegisto = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.pbtnImprimir = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pbtnConsultar = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pbtnEditarRegisto = new System.Windows.Forms.PictureBox();
            this.exameBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSearchNome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSearchNumero)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbtnImprimir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbtnConsultar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbtnEditarRegisto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exameBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.txtSearchNumero);
            this.groupBox1.Controls.Add(this.txtSearchNome);
            this.groupBox1.Controls.Add(this.autoLabel2);
            this.groupBox1.Controls.Add(this.autoLabel1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(604, 111);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pesquisar";
            // 
            // picLogo
            // 
            this.picLogo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picLogo.Image = global::EcoCardio.WinApp.ImgCustom.realecoSmall;
            this.picLogo.Location = new System.Drawing.Point(622, 31);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(174, 76);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogo.TabIndex = 5;
            this.picLogo.TabStop = false;
            // 
            // autoLabel1
            // 
            this.autoLabel1.DX = -42;
            this.autoLabel1.DY = 3;
            this.autoLabel1.LabeledControl = this.txtSearchNome;
            this.autoLabel1.Location = new System.Drawing.Point(49, 22);
            this.autoLabel1.Name = "autoLabel1";
            this.autoLabel1.Size = new System.Drawing.Size(38, 13);
            this.autoLabel1.TabIndex = 0;
            this.autoLabel1.Text = "Nome:";
            // 
            // autoLabel2
            // 
            this.autoLabel2.DX = -64;
            this.autoLabel2.DY = 3;
            this.autoLabel2.LabeledControl = this.txtSearchNumero;
            this.autoLabel2.Location = new System.Drawing.Point(27, 48);
            this.autoLabel2.Name = "autoLabel2";
            this.autoLabel2.Size = new System.Drawing.Size(60, 13);
            this.autoLabel2.TabIndex = 1;
            this.autoLabel2.Text = "N.º Exame:";
            // 
            // txtSearchNome
            // 
            this.txtSearchNome.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearchNome.BeforeTouchSize = new System.Drawing.Size(100, 20);
            this.txtSearchNome.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearchNome.Location = new System.Drawing.Point(91, 19);
            this.txtSearchNome.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtSearchNome.Name = "txtSearchNome";
            this.txtSearchNome.Size = new System.Drawing.Size(507, 20);
            this.txtSearchNome.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtSearchNome.TabIndex = 2;
            // 
            // txtSearchNumero
            // 
            this.txtSearchNumero.AllowNull = true;
            this.txtSearchNumero.BackGroundColor = System.Drawing.SystemColors.Window;
            this.txtSearchNumero.BeforeTouchSize = new System.Drawing.Size(100, 20);
            this.txtSearchNumero.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearchNumero.IntegerValue = ((long)(0));
            this.txtSearchNumero.Location = new System.Drawing.Point(91, 45);
            this.txtSearchNumero.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtSearchNumero.Name = "txtSearchNumero";
            this.txtSearchNumero.NullString = "";
            this.txtSearchNumero.Size = new System.Drawing.Size(100, 20);
            this.txtSearchNumero.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtSearchNumero.TabIndex = 3;
            // 
            // btnSearch
            // 
            this.btnSearch.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.btnSearch.BeforeTouchSize = new System.Drawing.Size(75, 23);
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.IsBackStageButton = false;
            this.btnSearch.Location = new System.Drawing.Point(91, 72);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "Procurar";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox2.Controls.Add(this.btnCriarRegisto);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.pbtnImprimir);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.pbtnConsultar);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.pbtnEditarRegisto);
            this.groupBox2.Location = new System.Drawing.Point(12, 129);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(113, 388);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Opções";
            // 
            // btnCriarRegisto
            // 
            this.btnCriarRegisto.Image = global::EcoCardio.WinApp.Img50.Create50;
            this.btnCriarRegisto.Location = new System.Drawing.Point(6, 19);
            this.btnCriarRegisto.Name = "btnCriarRegisto";
            this.btnCriarRegisto.Size = new System.Drawing.Size(101, 72);
            this.btnCriarRegisto.TabIndex = 14;
            this.btnCriarRegisto.Text = "Criar Registo";
            this.btnCriarRegisto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCriarRegisto.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(35, 332);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Imprimir";
            // 
            // pbtnImprimir
            // 
            this.pbtnImprimir.Image = global::EcoCardio.WinApp.Img50.Print50;
            this.pbtnImprimir.Location = new System.Drawing.Point(31, 279);
            this.pbtnImprimir.Name = "pbtnImprimir";
            this.pbtnImprimir.Size = new System.Drawing.Size(50, 50);
            this.pbtnImprimir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbtnImprimir.TabIndex = 12;
            this.pbtnImprimir.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 254);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Consultar";
            // 
            // pbtnConsultar
            // 
            this.pbtnConsultar.Image = global::EcoCardio.WinApp.Img50.Search50;
            this.pbtnConsultar.Location = new System.Drawing.Point(31, 201);
            this.pbtnConsultar.Name = "pbtnConsultar";
            this.pbtnConsultar.Size = new System.Drawing.Size(50, 50);
            this.pbtnConsultar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbtnConsultar.TabIndex = 10;
            this.pbtnConsultar.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Editar Registo";
            // 
            // pbtnEditarRegisto
            // 
            this.pbtnEditarRegisto.Image = global::EcoCardio.WinApp.Img50.Edit50;
            this.pbtnEditarRegisto.Location = new System.Drawing.Point(31, 122);
            this.pbtnEditarRegisto.Name = "pbtnEditarRegisto";
            this.pbtnEditarRegisto.Size = new System.Drawing.Size(50, 50);
            this.pbtnEditarRegisto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbtnEditarRegisto.TabIndex = 8;
            this.pbtnEditarRegisto.TabStop = false;
            // 
            // exameBindingSource
            // 
            this.exameBindingSource.DataSource = typeof(EcoCardio.Domain.Exame);
            // 
            // FrmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 529);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.picLogo);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmHome";
            this.ShowIcon = false;
            this.Text = "Home";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSearchNome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSearchNumero)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbtnImprimir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbtnConsultar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbtnEditarRegisto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exameBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox picLogo;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtSearchNome;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel2;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel1;
        private Syncfusion.Windows.Forms.Tools.IntegerTextBox txtSearchNumero;
        private Syncfusion.Windows.Forms.ButtonAdv btnSearch;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnCriarRegisto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pbtnImprimir;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pbtnConsultar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pbtnEditarRegisto;
        private System.Windows.Forms.BindingSource exameBindingSource;
    }
}