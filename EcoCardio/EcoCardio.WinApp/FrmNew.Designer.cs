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
            this.uscCreate1 = new EcoCardio.WinApp.UscCreate();
            this.SuspendLayout();
            // 
            // uscCreate1
            // 
            this.uscCreate1.AutoScroll = true;
            this.uscCreate1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uscCreate1.Location = new System.Drawing.Point(0, 0);
            this.uscCreate1.Name = "uscCreate1";
            this.uscCreate1.Size = new System.Drawing.Size(809, 741);
            this.uscCreate1.TabIndex = 0;
            // 
            // FrmNew
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 741);
            this.Controls.Add(this.uscCreate1);
            this.MaximumSize = new System.Drawing.Size(825, 1000);
            this.Name = "FrmNew";
            this.Text = "FrmNew";
            this.ResumeLayout(false);

        }

        #endregion

        private UscCreate uscCreate1;
    }
}