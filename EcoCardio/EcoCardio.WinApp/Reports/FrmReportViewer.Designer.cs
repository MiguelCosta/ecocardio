namespace EcoCardio.WinApp.Reports
{
    partial class FrmReportViewer
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
            this.crvExame = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crvExame
            // 
            this.crvExame.ActiveViewIndex = -1;
            this.crvExame.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvExame.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvExame.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvExame.Location = new System.Drawing.Point(0, 0);
            this.crvExame.Name = "crvExame";
            this.crvExame.ShowRefreshButton = false;
            this.crvExame.Size = new System.Drawing.Size(884, 601);
            this.crvExame.TabIndex = 0;
            this.crvExame.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // FrmReportViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 601);
            this.Controls.Add(this.crvExame);
            this.Name = "FrmReportViewer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Visualizador de Documentos";
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvExame;
    }
}