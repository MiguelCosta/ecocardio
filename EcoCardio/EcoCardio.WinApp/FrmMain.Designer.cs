#region Copyright Syncfusion Inc. 2001 - 2016
// Copyright Syncfusion Inc. 2001 - 2016. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
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
            this.ribbonControlAdv1 = new Syncfusion.Windows.Forms.Tools.RibbonControlAdv();
            this.toolStripTabItem1 = new Syncfusion.Windows.Forms.Tools.ToolStripTabItem();
            this.toolStripEx1 = new Syncfusion.Windows.Forms.Tools.ToolStripEx();
            this.btnHome = new System.Windows.Forms.ToolStripButton();
            this.btnExit = new System.Windows.Forms.ToolStripButton();
            this.statusBarExt1 = new Syncfusion.Windows.Forms.Tools.Controls.StatusBar.StatusBarExt();
            this.lblUser = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControlAdv1)).BeginInit();
            this.ribbonControlAdv1.SuspendLayout();
            this.toolStripTabItem1.Panel.SuspendLayout();
            this.toolStripEx1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.statusBarExt1)).BeginInit();
            this.statusBarExt1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ribbonControlAdv1
            // 
            this.ribbonControlAdv1.Dock = Syncfusion.Windows.Forms.Tools.DockStyleEx.Top;
            this.ribbonControlAdv1.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.ribbonControlAdv1.Header.AddMainItem(toolStripTabItem1);
            this.ribbonControlAdv1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControlAdv1.MenuButtonFont = new System.Drawing.Font("Segoe UI", 8.25F);
            this.ribbonControlAdv1.MenuButtonText = "";
            this.ribbonControlAdv1.MenuColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(114)))), ((int)(((byte)(198)))));
            this.ribbonControlAdv1.Name = "ribbonControlAdv1";
            this.ribbonControlAdv1.OfficeColorScheme = Syncfusion.Windows.Forms.Tools.ToolStripEx.ColorScheme.Managed;
            // 
            // ribbonControlAdv1.OfficeMenu
            // 
            this.ribbonControlAdv1.OfficeMenu.MainPanel.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnExit});
            this.ribbonControlAdv1.OfficeMenu.Name = "OfficeMenu";
            this.ribbonControlAdv1.OfficeMenu.ShowItemToolTips = true;
            this.ribbonControlAdv1.OfficeMenu.Size = new System.Drawing.Size(58, 68);
            this.ribbonControlAdv1.OfficeMenu.Text = "Menu";
            this.ribbonControlAdv1.QuickPanelImageLayout = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ribbonControlAdv1.RibbonHeaderImage = Syncfusion.Windows.Forms.Tools.RibbonHeaderImage.None;
            this.ribbonControlAdv1.SelectedTab = this.toolStripTabItem1;
            this.ribbonControlAdv1.ShowRibbonDisplayOptionButton = true;
            this.ribbonControlAdv1.Size = new System.Drawing.Size(833, 139);
            this.ribbonControlAdv1.SystemText.QuickAccessDialogDropDownName = "Start menu";
            this.ribbonControlAdv1.SystemText.RenameDisplayLabelText = "&Display Name:";
            this.ribbonControlAdv1.TabIndex = 0;
            this.ribbonControlAdv1.Text = "ribbonControlAdv1";
            // 
            // toolStripTabItem1
            // 
            this.toolStripTabItem1.Name = "toolStripTabItem1";
            // 
            // ribbonControlAdv1.ribbonPanel1
            // 
            this.toolStripTabItem1.Panel.Controls.Add(this.toolStripEx1);
            this.toolStripTabItem1.Panel.Name = "ribbonPanel1";
            this.toolStripTabItem1.Panel.ScrollPosition = 0;
            this.toolStripTabItem1.Panel.TabIndex = 2;
            this.toolStripTabItem1.Panel.Text = "Geral";
            this.toolStripTabItem1.Position = 0;
            this.toolStripTabItem1.Size = new System.Drawing.Size(40, 19);
            this.toolStripTabItem1.Tag = "1";
            this.toolStripTabItem1.Text = "Geral";
            // 
            // toolStripEx1
            // 
            this.toolStripEx1.AutoSize = false;
            this.toolStripEx1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStripEx1.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.toolStripEx1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.toolStripEx1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStripEx1.Image = null;
            this.toolStripEx1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnHome});
            this.toolStripEx1.Location = new System.Drawing.Point(0, 1);
            this.toolStripEx1.Name = "toolStripEx1";
            this.toolStripEx1.Size = new System.Drawing.Size(224, 83);
            this.toolStripEx1.TabIndex = 0;
            // 
            // btnHome
            // 
            this.btnHome.Image = global::EcoCardio.WinApp.Img50.Search50;
            this.btnHome.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnHome.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(54, 62);
            this.btnHome.Text = "Início";
            this.btnHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnExit
            // 
            this.btnExit.Image = global::EcoCardio.WinApp.Img32.exit;
            this.btnExit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(46, 20);
            this.btnExit.Text = "Sair";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // statusBarExt1
            // 
            this.statusBarExt1.BeforeTouchSize = new System.Drawing.Size(833, 22);
            this.statusBarExt1.BorderColor = System.Drawing.SystemColors.Control;
            this.statusBarExt1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.statusBarExt1.Controls.Add(this.lblUser);
            this.statusBarExt1.CustomLayoutBounds = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.statusBarExt1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.statusBarExt1.Location = new System.Drawing.Point(0, 545);
            this.statusBarExt1.Name = "statusBarExt1";
            this.statusBarExt1.Padding = new System.Windows.Forms.Padding(3);
            this.statusBarExt1.Size = new System.Drawing.Size(833, 22);
            this.statusBarExt1.Spacing = new System.Drawing.Size(2, 2);
            this.statusBarExt1.TabIndex = 1;
            this.statusBarExt1.ThemesEnabled = true;
            this.statusBarExt1.VisualStyle = Syncfusion.Windows.Forms.Tools.Controls.StatusBar.VisualStyle.Default;
            // 
            // lblUser
            // 
            this.lblUser.Location = new System.Drawing.Point(0, 2);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(39, 13);
            this.lblUser.TabIndex = 0;
            this.lblUser.Text = "lblUser";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(833, 567);
            this.Controls.Add(this.statusBarExt1);
            this.Controls.Add(this.ribbonControlAdv1);
            this.IsMdiContainer = true;
            this.Name = "FrmMain";
            this.ShowIcon = false;
            this.Text = "EcoCardio";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControlAdv1)).EndInit();
            this.ribbonControlAdv1.ResumeLayout(false);
            this.ribbonControlAdv1.PerformLayout();
            this.toolStripTabItem1.Panel.ResumeLayout(false);
            this.toolStripEx1.ResumeLayout(false);
            this.toolStripEx1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.statusBarExt1)).EndInit();
            this.statusBarExt1.ResumeLayout(false);
            this.statusBarExt1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Syncfusion.Windows.Forms.Tools.RibbonControlAdv ribbonControlAdv1;
        private Syncfusion.Windows.Forms.Tools.ToolStripTabItem toolStripTabItem1;
        private Syncfusion.Windows.Forms.Tools.ToolStripEx toolStripEx1;
        private System.Windows.Forms.ToolStripButton btnExit;
        private Syncfusion.Windows.Forms.Tools.Controls.StatusBar.StatusBarExt statusBarExt1;
        private Syncfusion.Windows.Forms.Tools.AutoLabel lblUser;
        private System.Windows.Forms.ToolStripButton btnHome;
    }
}