namespace EcoCardio.WinApp.Template
{
    partial class FrmTemplateList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTemplateList));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvListaTemplates = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.templateBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnApagarTemplate = new System.Windows.Forms.Button();
            this.btnEditarTemplate = new System.Windows.Forms.Button();
            this.btnCriarTemplate = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaTemplates)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.templateBindingSource)).BeginInit();
            this.SuspendLayout();
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
            this.groupBox1.Size = new System.Drawing.Size(97, 286);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ações";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.dgvListaTemplates);
            this.groupBox2.Location = new System.Drawing.Point(115, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(438, 286);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Lista";
            // 
            // dgvListaTemplates
            // 
            this.dgvListaTemplates.AllowUserToAddRows = false;
            this.dgvListaTemplates.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvListaTemplates.AutoGenerateColumns = false;
            this.dgvListaTemplates.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaTemplates.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.typeDataGridViewTextBoxColumn,
            this.nomeDataGridViewTextBoxColumn,
            this.textoDataGridViewTextBoxColumn});
            this.dgvListaTemplates.DataSource = this.templateBindingSource;
            this.dgvListaTemplates.Location = new System.Drawing.Point(7, 20);
            this.dgvListaTemplates.Name = "dgvListaTemplates";
            this.dgvListaTemplates.Size = new System.Drawing.Size(425, 257);
            this.dgvListaTemplates.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // typeDataGridViewTextBoxColumn
            // 
            this.typeDataGridViewTextBoxColumn.DataPropertyName = "Type";
            this.typeDataGridViewTextBoxColumn.HeaderText = "Tipo";
            this.typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            // 
            // textoDataGridViewTextBoxColumn
            // 
            this.textoDataGridViewTextBoxColumn.DataPropertyName = "Texto";
            this.textoDataGridViewTextBoxColumn.HeaderText = "Texto";
            this.textoDataGridViewTextBoxColumn.Name = "textoDataGridViewTextBoxColumn";
            // 
            // templateBindingSource
            // 
            this.templateBindingSource.DataSource = typeof(EcoCardio.Domain.Template);
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
            // FrmTemplateList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 307);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmTemplateList";
            this.Text = "Templates";
            this.Load += new System.EventHandler(this.FrmTemplateList_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaTemplates)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.templateBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnCriarTemplate;
        private System.Windows.Forms.Button btnApagarTemplate;
        private System.Windows.Forms.Button btnEditarTemplate;
        private System.Windows.Forms.DataGridView dgvListaTemplates;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn textoDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource templateBindingSource;
    }
}