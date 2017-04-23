namespace EcoCardio.WinApp.Exame
{
    partial class FrmExameNew
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmExameNew));
            this.uscExameEditControl = new EcoCardio.WinApp.Exame.UscExameEdit();
            this.SuspendLayout();
            // 
            // uscExameEditControl
            // 
            this.uscExameEditControl.AutoScroll = true;
            this.uscExameEditControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uscExameEditControl.Location = new System.Drawing.Point(0, 0);
            this.uscExameEditControl.Name = "uscExameEditControl";
            this.uscExameEditControl.Size = new System.Drawing.Size(822, 645);
            this.uscExameEditControl.TabIndex = 0;
            // 
            // FrmExameNew
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 645);
            this.Controls.Add(this.uscExameEditControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmExameNew";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Novo Exame";
            this.ResumeLayout(false);

        }

        #endregion

        private UscExameEdit uscExameEditControl;
    }
}