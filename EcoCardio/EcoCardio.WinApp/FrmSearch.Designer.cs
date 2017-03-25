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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSearch));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSearchNumero = new System.Windows.Forms.TextBox();
            this.txtSearchNome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvExames = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataNascimentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.exameBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnPrint = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnEditarRegisto = new System.Windows.Forms.Button();
            this.btnCriarRegisto = new System.Windows.Forms.Button();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExames)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exameBindingSource)).BeginInit();
            this.groupBox2.SuspendLayout();
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
            this.dgvExames.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvExames.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvExames.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvExames.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.numeroDataGridViewTextBoxColumn,
            this.dataDataGridViewTextBoxColumn,
            this.nomeDataGridViewTextBoxColumn,
            this.dataNascimentoDataGridViewTextBoxColumn});
            this.dgvExames.DataSource = this.exameBindingSource;
            this.dgvExames.Location = new System.Drawing.Point(6, 19);
            this.dgvExames.Name = "dgvExames";
            this.dgvExames.ReadOnly = true;
            this.dgvExames.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvExames.Size = new System.Drawing.Size(748, 368);
            this.dgvExames.TabIndex = 0;
            this.dgvExames.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvExames_CellDoubleClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.FillWeight = 15F;
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // numeroDataGridViewTextBoxColumn
            // 
            this.numeroDataGridViewTextBoxColumn.DataPropertyName = "Numero";
            this.numeroDataGridViewTextBoxColumn.FillWeight = 20F;
            this.numeroDataGridViewTextBoxColumn.HeaderText = "Número do Exame";
            this.numeroDataGridViewTextBoxColumn.Name = "numeroDataGridViewTextBoxColumn";
            this.numeroDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataDataGridViewTextBoxColumn
            // 
            this.dataDataGridViewTextBoxColumn.DataPropertyName = "Data";
            this.dataDataGridViewTextBoxColumn.FillWeight = 20F;
            this.dataDataGridViewTextBoxColumn.HeaderText = "Data do exame";
            this.dataDataGridViewTextBoxColumn.Name = "dataDataGridViewTextBoxColumn";
            this.dataDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
            this.nomeDataGridViewTextBoxColumn.FillWeight = 61.54822F;
            this.nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            this.nomeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataNascimentoDataGridViewTextBoxColumn
            // 
            this.dataNascimentoDataGridViewTextBoxColumn.DataPropertyName = "DataNascimento";
            this.dataNascimentoDataGridViewTextBoxColumn.FillWeight = 20F;
            this.dataNascimentoDataGridViewTextBoxColumn.HeaderText = "Data de Nascimento";
            this.dataNascimentoDataGridViewTextBoxColumn.Name = "dataNascimentoDataGridViewTextBoxColumn";
            this.dataNascimentoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // exameBindingSource
            // 
            this.exameBindingSource.DataSource = typeof(EcoCardio.Domain.Exame);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox2.Controls.Add(this.btnPrint);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.btnEditarRegisto);
            this.groupBox2.Controls.Add(this.btnCriarRegisto);
            this.groupBox2.Location = new System.Drawing.Point(12, 131);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(113, 393);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Opções";
            // 
            // btnPrint
            // 
            this.btnPrint.Image = global::EcoCardio.WinApp.Img32.Print32;
            this.btnPrint.Location = new System.Drawing.Point(6, 203);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(101, 55);
            this.btnPrint.TabIndex = 17;
            this.btnPrint.Text = "Imprimir";
            this.btnPrint.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // button1
            // 
            this.button1.Image = global::EcoCardio.WinApp.Img32.Delete32;
            this.button1.Location = new System.Drawing.Point(6, 142);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 55);
            this.button1.TabIndex = 16;
            this.button1.Text = "Apagar Registo";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button1.UseVisualStyleBackColor = true;
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
            this.btnEditarRegisto.Click += new System.EventHandler(this.btnEditarRegisto_Click);
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
            ((System.ComponentModel.ISupportInitialize)(this.exameBindingSource)).EndInit();
            this.groupBox2.ResumeLayout(false);
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
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnEditarRegisto;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataNascimentoDataGridViewTextBoxColumn;
    }
}