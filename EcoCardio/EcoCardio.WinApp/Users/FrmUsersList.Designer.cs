namespace EcoCardio.WinApp.Users
{
    partial class FrmUsersList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUsersList));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvListaTemplates = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnApagarTemplate = new System.Windows.Forms.Button();
            this.btnEditarTemplate = new System.Windows.Forms.Button();
            this.btnCriarTemplate = new System.Windows.Forms.Button();
            this.utilizadorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.profileDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaTemplates)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.utilizadorBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.dgvListaTemplates);
            this.groupBox2.Location = new System.Drawing.Point(115, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(357, 279);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Lista";
            // 
            // dgvListaTemplates
            // 
            this.dgvListaTemplates.AllowUserToAddRows = false;
            this.dgvListaTemplates.AllowUserToDeleteRows = false;
            this.dgvListaTemplates.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvListaTemplates.AutoGenerateColumns = false;
            this.dgvListaTemplates.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaTemplates.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nomeDataGridViewTextBoxColumn,
            this.usernameDataGridViewTextBoxColumn,
            this.profileDataGridViewTextBoxColumn});
            this.dgvListaTemplates.DataSource = this.utilizadorBindingSource;
            this.dgvListaTemplates.Location = new System.Drawing.Point(7, 20);
            this.dgvListaTemplates.Name = "dgvListaTemplates";
            this.dgvListaTemplates.ReadOnly = true;
            this.dgvListaTemplates.Size = new System.Drawing.Size(344, 247);
            this.dgvListaTemplates.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.btnApagarTemplate);
            this.groupBox1.Controls.Add(this.btnEditarTemplate);
            this.groupBox1.Controls.Add(this.btnCriarTemplate);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(97, 279);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ações";
            // 
            // btnApagarTemplate
            // 
            this.btnApagarTemplate.Image = global::EcoCardio.WinApp.Img50.Delete50;
            this.btnApagarTemplate.Location = new System.Drawing.Point(6, 195);
            this.btnApagarTemplate.Name = "btnApagarTemplate";
            this.btnApagarTemplate.Size = new System.Drawing.Size(85, 82);
            this.btnApagarTemplate.TabIndex = 3;
            this.btnApagarTemplate.Text = "Apagar";
            this.btnApagarTemplate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnApagarTemplate.UseVisualStyleBackColor = true;
            // 
            // btnEditarTemplate
            // 
            this.btnEditarTemplate.Image = global::EcoCardio.WinApp.Img50.Edit50;
            this.btnEditarTemplate.Location = new System.Drawing.Point(6, 107);
            this.btnEditarTemplate.Name = "btnEditarTemplate";
            this.btnEditarTemplate.Size = new System.Drawing.Size(85, 82);
            this.btnEditarTemplate.TabIndex = 2;
            this.btnEditarTemplate.Text = "Editar";
            this.btnEditarTemplate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnEditarTemplate.UseVisualStyleBackColor = true;
            // 
            // btnCriarTemplate
            // 
            this.btnCriarTemplate.Image = global::EcoCardio.WinApp.Img50.Create50;
            this.btnCriarTemplate.Location = new System.Drawing.Point(6, 19);
            this.btnCriarTemplate.Name = "btnCriarTemplate";
            this.btnCriarTemplate.Size = new System.Drawing.Size(85, 82);
            this.btnCriarTemplate.TabIndex = 1;
            this.btnCriarTemplate.Text = "Criar";
            this.btnCriarTemplate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCriarTemplate.UseVisualStyleBackColor = true;
            // 
            // utilizadorBindingSource
            // 
            this.utilizadorBindingSource.DataSource = typeof(EcoCardio.Domain.Utilizador);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            this.nomeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // usernameDataGridViewTextBoxColumn
            // 
            this.usernameDataGridViewTextBoxColumn.DataPropertyName = "Username";
            this.usernameDataGridViewTextBoxColumn.HeaderText = "Username";
            this.usernameDataGridViewTextBoxColumn.Name = "usernameDataGridViewTextBoxColumn";
            this.usernameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // profileDataGridViewTextBoxColumn
            // 
            this.profileDataGridViewTextBoxColumn.DataPropertyName = "Profile";
            this.profileDataGridViewTextBoxColumn.HeaderText = "Profile";
            this.profileDataGridViewTextBoxColumn.Name = "profileDataGridViewTextBoxColumn";
            this.profileDataGridViewTextBoxColumn.ReadOnly = true;
            this.profileDataGridViewTextBoxColumn.Visible = false;
            // 
            // FrmUsersList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 298);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmUsersList";
            this.Text = "Utilizadores";
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaTemplates)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.utilizadorBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvListaTemplates;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnApagarTemplate;
        private System.Windows.Forms.Button btnEditarTemplate;
        private System.Windows.Forms.Button btnCriarTemplate;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn profileDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource utilizadorBindingSource;
    }
}