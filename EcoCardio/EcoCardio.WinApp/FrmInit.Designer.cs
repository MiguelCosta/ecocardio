namespace EcoCardio.WinApp
{
    partial class FrmInit
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
            this.grpSearch = new System.Windows.Forms.GroupBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.dtgUtentes = new System.Windows.Forms.DataGridView();
            this.txtSearchNome = new System.Windows.Forms.TextBox();
            this.btnCriarRegisto = new System.Windows.Forms.Button();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.lblNumeroProcesso = new System.Windows.Forms.Label();
            this.txtNumeroProcesso = new System.Windows.Forms.TextBox();
            this.txtNumeroEcocardio = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.grpSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgUtentes)).BeginInit();
            this.SuspendLayout();
            // 
            // grpSearch
            // 
            this.grpSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpSearch.Controls.Add(this.txtNumeroEcocardio);
            this.grpSearch.Controls.Add(this.label2);
            this.grpSearch.Controls.Add(this.txtNumeroProcesso);
            this.grpSearch.Controls.Add(this.lblNumeroProcesso);
            this.grpSearch.Controls.Add(this.txtSearchNome);
            this.grpSearch.Controls.Add(this.lblNome);
            this.grpSearch.Location = new System.Drawing.Point(12, 12);
            this.grpSearch.Name = "grpSearch";
            this.grpSearch.Size = new System.Drawing.Size(779, 96);
            this.grpSearch.TabIndex = 0;
            this.grpSearch.TabStop = false;
            this.grpSearch.Text = "Pesquisa";
            this.grpSearch.Enter += new System.EventHandler(this.grpSearch_Enter);
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(28, 31);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(38, 13);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome:";
            this.lblNome.Click += new System.EventHandler(this.label1_Click);
            // 
            // dtgUtentes
            // 
            this.dtgUtentes.AllowUserToDeleteRows = false;
            this.dtgUtentes.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dtgUtentes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgUtentes.Location = new System.Drawing.Point(131, 114);
            this.dtgUtentes.Name = "dtgUtentes";
            this.dtgUtentes.ReadOnly = true;
            this.dtgUtentes.Size = new System.Drawing.Size(642, 373);
            this.dtgUtentes.TabIndex = 1;
            // 
            // txtSearchNome
            // 
            this.txtSearchNome.Location = new System.Drawing.Point(72, 28);
            this.txtSearchNome.Name = "txtSearchNome";
            this.txtSearchNome.Size = new System.Drawing.Size(427, 20);
            this.txtSearchNome.TabIndex = 1;
            // 
            // btnCriarRegisto
            // 
            this.btnCriarRegisto.Location = new System.Drawing.Point(12, 146);
            this.btnCriarRegisto.Name = "btnCriarRegisto";
            this.btnCriarRegisto.Size = new System.Drawing.Size(113, 41);
            this.btnCriarRegisto.TabIndex = 2;
            this.btnCriarRegisto.Text = "Criar Registo";
            this.btnCriarRegisto.UseVisualStyleBackColor = true;
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(12, 217);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(113, 41);
            this.btnConsultar.TabIndex = 3;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(12, 286);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(113, 41);
            this.btnModificar.TabIndex = 4;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            // 
            // lblNumeroProcesso
            // 
            this.lblNumeroProcesso.AutoSize = true;
            this.lblNumeroProcesso.Location = new System.Drawing.Point(519, 28);
            this.lblNumeroProcesso.Name = "lblNumeroProcesso";
            this.lblNumeroProcesso.Size = new System.Drawing.Size(69, 13);
            this.lblNumeroProcesso.TabIndex = 2;
            this.lblNumeroProcesso.Text = "Nº Processo:";
            // 
            // txtNumeroProcesso
            // 
            this.txtNumeroProcesso.Location = new System.Drawing.Point(624, 25);
            this.txtNumeroProcesso.Name = "txtNumeroProcesso";
            this.txtNumeroProcesso.Size = new System.Drawing.Size(111, 20);
            this.txtNumeroProcesso.TabIndex = 3;
            // 
            // txtNumeroEcocardio
            // 
            this.txtNumeroEcocardio.Location = new System.Drawing.Point(624, 54);
            this.txtNumeroEcocardio.Name = "txtNumeroEcocardio";
            this.txtNumeroEcocardio.Size = new System.Drawing.Size(111, 20);
            this.txtNumeroEcocardio.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(519, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nº Ecocardiograma";
            // 
            // FrmInit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 514);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.btnCriarRegisto);
            this.Controls.Add(this.dtgUtentes);
            this.Controls.Add(this.grpSearch);
            this.Name = "FrmInit";
            this.Text = "Início";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.grpSearch.ResumeLayout(false);
            this.grpSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgUtentes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpSearch;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.DataGridView dtgUtentes;
        private System.Windows.Forms.TextBox txtSearchNome;
        private System.Windows.Forms.Button btnCriarRegisto;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.TextBox txtNumeroEcocardio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNumeroProcesso;
        private System.Windows.Forms.Label lblNumeroProcesso;
    }
}