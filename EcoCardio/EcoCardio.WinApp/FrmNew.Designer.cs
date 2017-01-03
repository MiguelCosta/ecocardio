namespace EcoCardio.WinApp
{
    partial class FrmNew
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
            this.grbAdicionar = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.grbAdicionar.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbAdicionar
            // 
            this.grbAdicionar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grbAdicionar.Controls.Add(this.textBox1);
            this.grbAdicionar.Controls.Add(this.label1);
            this.grbAdicionar.Location = new System.Drawing.Point(12, 12);
            this.grbAdicionar.Name = "grbAdicionar";
            this.grbAdicionar.Size = new System.Drawing.Size(785, 487);
            this.grbAdicionar.TabIndex = 0;
            this.grbAdicionar.TabStop = false;
            this.grbAdicionar.Text = "Criar Registo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(603, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nº Processo";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(679, 13);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            // 
            // FrmNew
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 511);
            this.Controls.Add(this.grbAdicionar);
            this.Name = "FrmNew";
            this.Text = "FrmNew";
            this.grbAdicionar.ResumeLayout(false);
            this.grbAdicionar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbAdicionar;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
    }
}