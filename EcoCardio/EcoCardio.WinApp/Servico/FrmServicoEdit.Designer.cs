namespace EcoCardio.WinApp.Servico
{
    partial class FrmServicoEdit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmServicoEdit));
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtMedico2 = new System.Windows.Forms.RadioButton();
            this.rbtRequisitadoPor = new System.Windows.Forms.RadioButton();
            this.rbtMedico1 = new System.Windows.Forms.RadioButton();
            this.rbtNone = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(239, 221);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(158, 221);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Gravar";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtMedico2);
            this.groupBox1.Controls.Add(this.rbtRequisitadoPor);
            this.groupBox1.Controls.Add(this.rbtMedico1);
            this.groupBox1.Controls.Add(this.rbtNone);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(446, 120);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tipo";
            // 
            // rbtMedico2
            // 
            this.rbtMedico2.AutoSize = true;
            this.rbtMedico2.Location = new System.Drawing.Point(12, 67);
            this.rbtMedico2.Name = "rbtMedico2";
            this.rbtMedico2.Size = new System.Drawing.Size(69, 17);
            this.rbtMedico2.TabIndex = 6;
            this.rbtMedico2.TabStop = true;
            this.rbtMedico2.Text = "Médico 2";
            this.rbtMedico2.UseVisualStyleBackColor = true;
            // 
            // rbtRequisitadoPor
            // 
            this.rbtRequisitadoPor.AutoSize = true;
            this.rbtRequisitadoPor.Location = new System.Drawing.Point(12, 90);
            this.rbtRequisitadoPor.Name = "rbtRequisitadoPor";
            this.rbtRequisitadoPor.Size = new System.Drawing.Size(100, 17);
            this.rbtRequisitadoPor.TabIndex = 2;
            this.rbtRequisitadoPor.TabStop = true;
            this.rbtRequisitadoPor.Text = "Requisitado Por";
            this.rbtRequisitadoPor.UseVisualStyleBackColor = true;
            // 
            // rbtMedico1
            // 
            this.rbtMedico1.AutoSize = true;
            this.rbtMedico1.Location = new System.Drawing.Point(12, 44);
            this.rbtMedico1.Name = "rbtMedico1";
            this.rbtMedico1.Size = new System.Drawing.Size(69, 17);
            this.rbtMedico1.TabIndex = 3;
            this.rbtMedico1.TabStop = true;
            this.rbtMedico1.Text = "Médico 1";
            this.rbtMedico1.UseVisualStyleBackColor = true;
            // 
            // rbtNone
            // 
            this.rbtNone.AutoSize = true;
            this.rbtNone.Location = new System.Drawing.Point(12, 21);
            this.rbtNone.Name = "rbtNone";
            this.rbtNone.Size = new System.Drawing.Size(87, 17);
            this.rbtNone.TabIndex = 0;
            this.rbtNone.TabStop = true;
            this.rbtNone.Text = "Não Definido";
            this.rbtNone.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtNome);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(12, 138);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(446, 77);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Template";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(12, 42);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(428, 20);
            this.txtNome.TabIndex = 0;
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
            // FrmServicoEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 254);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnSave);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmServicoEdit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Serviço";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbtMedico2;
        private System.Windows.Forms.RadioButton rbtRequisitadoPor;
        private System.Windows.Forms.RadioButton rbtMedico1;
        private System.Windows.Forms.RadioButton rbtNone;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label1;
    }
}