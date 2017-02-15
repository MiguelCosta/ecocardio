﻿namespace EcoCardio.WinApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSearch));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSearchNumero = new System.Windows.Forms.TextBox();
            this.txtSearchNome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvExames = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnConsultarRegisto = new System.Windows.Forms.Button();
            this.btnEditarRegisto = new System.Windows.Forms.Button();
            this.btnCriarRegisto = new System.Windows.Forms.Button();
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
            this.exameBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExames)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.exameBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
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
            this.dgvExames.Location = new System.Drawing.Point(6, 19);
            this.dgvExames.Name = "dgvExames";
            this.dgvExames.ReadOnly = true;
            this.dgvExames.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvExames.Size = new System.Drawing.Size(748, 368);
            this.dgvExames.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.btnConsultarRegisto);
            this.groupBox2.Controls.Add(this.btnEditarRegisto);
            this.groupBox2.Controls.Add(this.btnCriarRegisto);
            this.groupBox2.Location = new System.Drawing.Point(12, 131);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(113, 393);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Opções";
            // 
            // button3
            // 
            this.button3.Image = global::EcoCardio.WinApp.Img32.PDF32;
            this.button3.Location = new System.Drawing.Point(6, 325);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(101, 55);
            this.button3.TabIndex = 18;
            this.button3.Text = "Gerar PDF";
            this.button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Image = global::EcoCardio.WinApp.Img32.Print32;
            this.button2.Location = new System.Drawing.Point(6, 264);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(101, 55);
            this.button2.TabIndex = 17;
            this.button2.Text = "Imprimir";
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Image = global::EcoCardio.WinApp.Img32.Delete32;
            this.button1.Location = new System.Drawing.Point(6, 203);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 55);
            this.button1.TabIndex = 16;
            this.button1.Text = "Apagar Registo";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnConsultarRegisto
            // 
            this.btnConsultarRegisto.Image = global::EcoCardio.WinApp.Img32.Search32;
            this.btnConsultarRegisto.Location = new System.Drawing.Point(6, 142);
            this.btnConsultarRegisto.Name = "btnConsultarRegisto";
            this.btnConsultarRegisto.Size = new System.Drawing.Size(101, 55);
            this.btnConsultarRegisto.TabIndex = 15;
            this.btnConsultarRegisto.Text = "Consultar Registo";
            this.btnConsultarRegisto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnConsultarRegisto.UseVisualStyleBackColor = true;
            // 
            // btnEditarRegisto
            // 
            this.btnEditarRegisto.Image = global::EcoCardio.WinApp.Img32.Edit32;
            this.btnEditarRegisto.Location = new System.Drawing.Point(6, 80);
            this.btnEditarRegisto.Name = "btnEditarRegisto";
            this.btnEditarRegisto.Size = new System.Drawing.Size(101, 56);
            this.btnEditarRegisto.TabIndex = 14;
            this.btnEditarRegisto.Text = "Editar Registo";
            this.btnEditarRegisto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnEditarRegisto.UseVisualStyleBackColor = true;
            // 
            // btnCriarRegisto
            // 
            this.btnCriarRegisto.Image = global::EcoCardio.WinApp.Img32.Create32;
            this.btnCriarRegisto.Location = new System.Drawing.Point(6, 19);
            this.btnCriarRegisto.Name = "btnCriarRegisto";
            this.btnCriarRegisto.Size = new System.Drawing.Size(101, 55);
            this.btnCriarRegisto.TabIndex = 0;
            this.btnCriarRegisto.Text = "Criar Registo";
            this.btnCriarRegisto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCriarRegisto.UseVisualStyleBackColor = true;
            this.btnCriarRegisto.Click += new System.EventHandler(this.btnCriarRegisto_Click);
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
            // exameBindingSource
            // 
            this.exameBindingSource.DataSource = typeof(EcoCardio.Domain.Exame);
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
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.dgvExames);
            this.groupBox3.Location = new System.Drawing.Point(131, 131);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(760, 393);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Listagem";
            // 
            // FrmSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(903, 533);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.picLogo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmSearch";
            this.ShowIcon = false;
            this.Text = "Página Inicial";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmSearch_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExames)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.exameBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.groupBox3.ResumeLayout(false);
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
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnConsultarRegisto;
        private System.Windows.Forms.Button btnEditarRegisto;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}