namespace EcoCardio.WinApp.Template
{
    partial class FrmTemplateEdit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTemplateEdit));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtConclusao = new System.Windows.Forms.RadioButton();
            this.rbtEstruturasValvulares = new System.Windows.Forms.RadioButton();
            this.rbtMassasIntracavitarias = new System.Windows.Forms.RadioButton();
            this.rbtPericardio = new System.Windows.Forms.RadioButton();
            this.rbtFuncaoVentricular = new System.Windows.Forms.RadioButton();
            this.rbtEspessuraParedes = new System.Windows.Forms.RadioButton();
            this.rbtCavidadesCardiacas = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtTemplateTexto = new System.Windows.Forms.TextBox();
            this.txtNomeTemplate = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtConclusao);
            this.groupBox1.Controls.Add(this.rbtEstruturasValvulares);
            this.groupBox1.Controls.Add(this.rbtMassasIntracavitarias);
            this.groupBox1.Controls.Add(this.rbtPericardio);
            this.groupBox1.Controls.Add(this.rbtFuncaoVentricular);
            this.groupBox1.Controls.Add(this.rbtEspessuraParedes);
            this.groupBox1.Controls.Add(this.rbtCavidadesCardiacas);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(459, 95);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tipo";
            // 
            // rbtConclusao
            // 
            this.rbtConclusao.AutoSize = true;
            this.rbtConclusao.Location = new System.Drawing.Point(12, 67);
            this.rbtConclusao.Name = "rbtConclusao";
            this.rbtConclusao.Size = new System.Drawing.Size(75, 17);
            this.rbtConclusao.TabIndex = 6;
            this.rbtConclusao.TabStop = true;
            this.rbtConclusao.Text = "Conclusão";
            this.rbtConclusao.UseVisualStyleBackColor = true;
            // 
            // rbtEstruturasValvulares
            // 
            this.rbtEstruturasValvulares.AutoSize = true;
            this.rbtEstruturasValvulares.Location = new System.Drawing.Point(320, 44);
            this.rbtEstruturasValvulares.Name = "rbtEstruturasValvulares";
            this.rbtEstruturasValvulares.Size = new System.Drawing.Size(124, 17);
            this.rbtEstruturasValvulares.TabIndex = 5;
            this.rbtEstruturasValvulares.TabStop = true;
            this.rbtEstruturasValvulares.Text = "Estruturas Valvulares";
            this.rbtEstruturasValvulares.UseVisualStyleBackColor = true;
            // 
            // rbtMassasIntracavitarias
            // 
            this.rbtMassasIntracavitarias.AutoSize = true;
            this.rbtMassasIntracavitarias.Location = new System.Drawing.Point(320, 21);
            this.rbtMassasIntracavitarias.Name = "rbtMassasIntracavitarias";
            this.rbtMassasIntracavitarias.Size = new System.Drawing.Size(130, 17);
            this.rbtMassasIntracavitarias.TabIndex = 2;
            this.rbtMassasIntracavitarias.TabStop = true;
            this.rbtMassasIntracavitarias.Text = "Massas Intracavitárias";
            this.rbtMassasIntracavitarias.UseVisualStyleBackColor = true;
            // 
            // rbtPericardio
            // 
            this.rbtPericardio.AutoSize = true;
            this.rbtPericardio.Location = new System.Drawing.Point(198, 21);
            this.rbtPericardio.Name = "rbtPericardio";
            this.rbtPericardio.Size = new System.Drawing.Size(72, 17);
            this.rbtPericardio.TabIndex = 1;
            this.rbtPericardio.TabStop = true;
            this.rbtPericardio.Text = "Pericardio";
            this.rbtPericardio.UseVisualStyleBackColor = true;
            // 
            // rbtFuncaoVentricular
            // 
            this.rbtFuncaoVentricular.AutoSize = true;
            this.rbtFuncaoVentricular.Location = new System.Drawing.Point(198, 44);
            this.rbtFuncaoVentricular.Name = "rbtFuncaoVentricular";
            this.rbtFuncaoVentricular.Size = new System.Drawing.Size(114, 17);
            this.rbtFuncaoVentricular.TabIndex = 4;
            this.rbtFuncaoVentricular.TabStop = true;
            this.rbtFuncaoVentricular.Text = "Função Ventricular";
            this.rbtFuncaoVentricular.UseVisualStyleBackColor = true;
            // 
            // rbtEspessuraParedes
            // 
            this.rbtEspessuraParedes.AutoSize = true;
            this.rbtEspessuraParedes.Location = new System.Drawing.Point(12, 44);
            this.rbtEspessuraParedes.Name = "rbtEspessuraParedes";
            this.rbtEspessuraParedes.Size = new System.Drawing.Size(180, 17);
            this.rbtEspessuraParedes.TabIndex = 3;
            this.rbtEspessuraParedes.TabStop = true;
            this.rbtEspessuraParedes.Text = "Espessura Paredes Ventriculares";
            this.rbtEspessuraParedes.UseVisualStyleBackColor = true;
            // 
            // rbtCavidadesCardiacas
            // 
            this.rbtCavidadesCardiacas.AutoSize = true;
            this.rbtCavidadesCardiacas.Location = new System.Drawing.Point(12, 21);
            this.rbtCavidadesCardiacas.Name = "rbtCavidadesCardiacas";
            this.rbtCavidadesCardiacas.Size = new System.Drawing.Size(127, 17);
            this.rbtCavidadesCardiacas.TabIndex = 0;
            this.rbtCavidadesCardiacas.TabStop = true;
            this.rbtCavidadesCardiacas.Text = "Cavidades Cardíacas";
            this.rbtCavidadesCardiacas.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtTemplateTexto);
            this.groupBox2.Controls.Add(this.txtNomeTemplate);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(12, 113);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(459, 185);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Template";
            // 
            // txtTemplateTexto
            // 
            this.txtTemplateTexto.Location = new System.Drawing.Point(12, 91);
            this.txtTemplateTexto.Multiline = true;
            this.txtTemplateTexto.Name = "txtTemplateTexto";
            this.txtTemplateTexto.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtTemplateTexto.Size = new System.Drawing.Size(438, 78);
            this.txtTemplateTexto.TabIndex = 1;
            // 
            // txtNomeTemplate
            // 
            this.txtNomeTemplate.Location = new System.Drawing.Point(12, 42);
            this.txtNomeTemplate.Name = "txtNomeTemplate";
            this.txtNomeTemplate.Size = new System.Drawing.Size(438, 20);
            this.txtNomeTemplate.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Texto:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome:";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(168, 304);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Gravar";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(249, 304);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 1;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // FrmTemplateEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 333);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmTemplateEdit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Template";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbtMassasIntracavitarias;
        private System.Windows.Forms.RadioButton rbtPericardio;
        private System.Windows.Forms.RadioButton rbtFuncaoVentricular;
        private System.Windows.Forms.RadioButton rbtEspessuraParedes;
        private System.Windows.Forms.RadioButton rbtCavidadesCardiacas;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtTemplateTexto;
        private System.Windows.Forms.TextBox txtNomeTemplate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.RadioButton rbtEstruturasValvulares;
        private System.Windows.Forms.RadioButton rbtConclusao;
    }
}