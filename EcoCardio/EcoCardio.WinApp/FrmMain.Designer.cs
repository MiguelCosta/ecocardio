namespace EcoCardio.WinApp
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuGeral = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuGeral_Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.statusBarExt1 = new Syncfusion.Windows.Forms.Tools.Controls.StatusBar.StatusBarExt();
            this.lblVersion = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.lblUser = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.mnuTemplates = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.statusBarExt1)).BeginInit();
            this.statusBarExt1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuGeral,
            this.mnuTemplates});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(724, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuGeral
            // 
            this.mnuGeral.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator1,
            this.mnuGeral_Exit});
            this.mnuGeral.Name = "mnuGeral";
            this.mnuGeral.Size = new System.Drawing.Size(46, 20);
            this.mnuGeral.Text = "Geral";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(149, 6);
            // 
            // mnuGeral_Exit
            // 
            this.mnuGeral_Exit.Name = "mnuGeral_Exit";
            this.mnuGeral_Exit.Size = new System.Drawing.Size(152, 22);
            this.mnuGeral_Exit.Text = "Sair";
            this.mnuGeral_Exit.Click += new System.EventHandler(this.mnuGeral_Exit_Click);
            // 
            // statusBarExt1
            // 
            this.statusBarExt1.BeforeTouchSize = new System.Drawing.Size(724, 22);
            this.statusBarExt1.BorderColor = System.Drawing.SystemColors.Control;
            this.statusBarExt1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.statusBarExt1.Controls.Add(this.lblVersion);
            this.statusBarExt1.Controls.Add(this.lblUser);
            this.statusBarExt1.CustomLayoutBounds = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.statusBarExt1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.statusBarExt1.Location = new System.Drawing.Point(0, 499);
            this.statusBarExt1.Name = "statusBarExt1";
            this.statusBarExt1.Padding = new System.Windows.Forms.Padding(3);
            this.statusBarExt1.Size = new System.Drawing.Size(724, 22);
            this.statusBarExt1.Spacing = new System.Drawing.Size(2, 2);
            this.statusBarExt1.TabIndex = 6;
            this.statusBarExt1.ThemesEnabled = true;
            this.statusBarExt1.VisualStyle = Syncfusion.Windows.Forms.Tools.Controls.StatusBar.VisualStyle.Default;
            // 
            // lblVersion
            // 
            this.lblVersion.Location = new System.Drawing.Point(0, 2);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(52, 13);
            this.lblVersion.TabIndex = 1;
            this.lblVersion.Text = "lblVersion";
            // 
            // lblUser
            // 
            this.lblUser.Location = new System.Drawing.Point(54, 2);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(39, 13);
            this.lblUser.TabIndex = 0;
            this.lblUser.Text = "lblUser";
            // 
            // mnuTemplates
            // 
            this.mnuTemplates.Name = "mnuTemplates";
            this.mnuTemplates.Size = new System.Drawing.Size(73, 20);
            this.mnuTemplates.Text = "Templates";
            this.mnuTemplates.Click += new System.EventHandler(this.mnuTemplates_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 521);
            this.Controls.Add(this.statusBarExt1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "FrmMain";
            this.Text = "RealEco";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.statusBarExt1)).EndInit();
            this.statusBarExt1.ResumeLayout(false);
            this.statusBarExt1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuGeral;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem mnuGeral_Exit;
        private Syncfusion.Windows.Forms.Tools.Controls.StatusBar.StatusBarExt statusBarExt1;
        private Syncfusion.Windows.Forms.Tools.AutoLabel lblUser;
        private Syncfusion.Windows.Forms.Tools.AutoLabel lblVersion;
        private System.Windows.Forms.ToolStripMenuItem mnuTemplates;
    }
}