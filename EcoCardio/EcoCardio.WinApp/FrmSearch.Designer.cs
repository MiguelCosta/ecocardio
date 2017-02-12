namespace EcoCardio.WinApp
{
    partial class FrmSearch
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
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSearchNumero = new System.Windows.Forms.TextBox();
            this.txtSearchNome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.exameBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dgvExames = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnCriarRegisto = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.pbtnImprimir = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pbtnConsultar = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pbtnEditarRegisto = new System.Windows.Forms.PictureBox();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idadeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeroProcessoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.observacaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.servicoIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.utenteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.utenteIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.exameBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExames)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbtnImprimir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbtnConsultar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbtnEditarRegisto)).BeginInit();
            this.SuspendLayout();
            // 
            // picLogo
            // 
            this.picLogo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picLogo.Image = global::EcoCardio.WinApp.ImgCustom.realecoSmall;
            this.picLogo.Location = new System.Drawing.Point(717, 27);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(174, 76);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogo.TabIndex = 11;
            this.picLogo.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtSearchNumero);
            this.groupBox1.Controls.Add(this.txtSearchNome);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(699, 113);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pesquisar";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(66, 78);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Procurar";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Número";
            // 
            // txtSearchNumero
            // 
            this.txtSearchNumero.Location = new System.Drawing.Point(66, 52);
            this.txtSearchNumero.Name = "txtSearchNumero";
            this.txtSearchNumero.Size = new System.Drawing.Size(131, 20);
            this.txtSearchNumero.TabIndex = 1;
            // 
            // txtSearchNome
            // 
            this.txtSearchNome.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearchNome.Location = new System.Drawing.Point(66, 26);
            this.txtSearchNome.Name = "txtSearchNome";
            this.txtSearchNome.Size = new System.Drawing.Size(627, 20);
            this.txtSearchNome.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome";
            // 
            // exameBindingSource
            // 
            this.exameBindingSource.DataSource = typeof(EcoCardio.Domain.Exame);
            // 
            // dgvExames
            // 
            this.dgvExames.AllowUserToAddRows = false;
            this.dgvExames.AllowUserToDeleteRows = false;
            this.dgvExames.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvExames.AutoGenerateColumns = false;
            this.dgvExames.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvExames.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.dataDataGridViewTextBoxColumn,
            this.numeroDataGridViewTextBoxColumn,
            this.nomeDataGridViewTextBoxColumn,
            this.idadeDataGridViewTextBoxColumn,
            this.numeroProcessoDataGridViewTextBoxColumn,
            this.observacaoDataGridViewTextBoxColumn,
            this.servicoIdDataGridViewTextBoxColumn,
            this.utenteDataGridViewTextBoxColumn,
            this.utenteIdDataGridViewTextBoxColumn});
            this.dgvExames.DataSource = this.exameBindingSource;
            this.dgvExames.Location = new System.Drawing.Point(131, 131);
            this.dgvExames.Name = "dgvExames";
            this.dgvExames.ReadOnly = true;
            this.dgvExames.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvExames.Size = new System.Drawing.Size(760, 383);
            this.dgvExames.TabIndex = 0;
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
            this.groupBox2.Location = new System.Drawing.Point(12, 131);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(113, 388);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Opções";
            // 
            // btnCriarRegisto
            // 
            this.btnCriarRegisto.Image = global::EcoCardio.WinApp.Img50.Create50;
            this.btnCriarRegisto.Location = new System.Drawing.Point(6, 19);
            this.btnCriarRegisto.Name = "btnCriarRegisto";
            this.btnCriarRegisto.Size = new System.Drawing.Size(101, 72);
            this.btnCriarRegisto.TabIndex = 0;
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
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 50;
            // 
            // dataDataGridViewTextBoxColumn
            // 
            this.dataDataGridViewTextBoxColumn.DataPropertyName = "Data";
            this.dataDataGridViewTextBoxColumn.HeaderText = "Data";
            this.dataDataGridViewTextBoxColumn.Name = "dataDataGridViewTextBoxColumn";
            this.dataDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // numeroDataGridViewTextBoxColumn
            // 
            this.numeroDataGridViewTextBoxColumn.DataPropertyName = "Numero";
            this.numeroDataGridViewTextBoxColumn.HeaderText = "Numero";
            this.numeroDataGridViewTextBoxColumn.Name = "numeroDataGridViewTextBoxColumn";
            this.numeroDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            this.nomeDataGridViewTextBoxColumn.ReadOnly = true;
            this.nomeDataGridViewTextBoxColumn.Width = 200;
            // 
            // idadeDataGridViewTextBoxColumn
            // 
            this.idadeDataGridViewTextBoxColumn.DataPropertyName = "Idade";
            this.idadeDataGridViewTextBoxColumn.HeaderText = "Idade";
            this.idadeDataGridViewTextBoxColumn.Name = "idadeDataGridViewTextBoxColumn";
            this.idadeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // numeroProcessoDataGridViewTextBoxColumn
            // 
            this.numeroProcessoDataGridViewTextBoxColumn.DataPropertyName = "NumeroProcesso";
            this.numeroProcessoDataGridViewTextBoxColumn.HeaderText = "NumeroProcesso";
            this.numeroProcessoDataGridViewTextBoxColumn.Name = "numeroProcessoDataGridViewTextBoxColumn";
            this.numeroProcessoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // observacaoDataGridViewTextBoxColumn
            // 
            this.observacaoDataGridViewTextBoxColumn.DataPropertyName = "Observacao";
            this.observacaoDataGridViewTextBoxColumn.HeaderText = "Observacao";
            this.observacaoDataGridViewTextBoxColumn.Name = "observacaoDataGridViewTextBoxColumn";
            this.observacaoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // servicoIdDataGridViewTextBoxColumn
            // 
            this.servicoIdDataGridViewTextBoxColumn.DataPropertyName = "ServicoId";
            this.servicoIdDataGridViewTextBoxColumn.HeaderText = "ServicoId";
            this.servicoIdDataGridViewTextBoxColumn.Name = "servicoIdDataGridViewTextBoxColumn";
            this.servicoIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // utenteDataGridViewTextBoxColumn
            // 
            this.utenteDataGridViewTextBoxColumn.DataPropertyName = "Utente";
            this.utenteDataGridViewTextBoxColumn.HeaderText = "Utente";
            this.utenteDataGridViewTextBoxColumn.Name = "utenteDataGridViewTextBoxColumn";
            this.utenteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // utenteIdDataGridViewTextBoxColumn
            // 
            this.utenteIdDataGridViewTextBoxColumn.DataPropertyName = "UtenteId";
            this.utenteIdDataGridViewTextBoxColumn.HeaderText = "UtenteId";
            this.utenteIdDataGridViewTextBoxColumn.Name = "utenteIdDataGridViewTextBoxColumn";
            this.utenteIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // FrmSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(903, 526);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dgvExames);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.picLogo);
            this.Name = "FrmSearch";
            this.ShowIcon = false;
            this.Text = "FormSearch";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.exameBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExames)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbtnImprimir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbtnConsultar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbtnEditarRegisto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSearchNome;
        private System.Windows.Forms.BindingSource exameBindingSource;
        private System.Windows.Forms.DataGridView dgvExames;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSearchNumero;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnCriarRegisto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pbtnImprimir;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pbtnConsultar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pbtnEditarRegisto;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idadeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroProcessoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn observacaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn servicoIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn utenteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn utenteIdDataGridViewTextBoxColumn;
    }
}