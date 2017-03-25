using CrystalDecisions.CrystalReports.Engine;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EcoCardio.WinApp.Reports
{
    public partial class FrmReportViewer : Form
    {
        public FrmReportViewer()
        {
            InitializeComponent();

        }

        public void OpenExame(int exameId)
        {
            ReportDocument report = new ReportDocument();
            string filePath = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Reports", "Exame.rpt");
            report.Load(filePath);
            report.SetParameterValue("ExameId", exameId);
            report.DataSourceConnections[0].SetConnection(
                Properties.Settings.Default.DataBaseServer,
                Properties.Settings.Default.DataBaseName,
                Properties.Settings.Default.DataBaseUser,
                Properties.Settings.Default.DataBasePassword);
            crvExame.ReportSource = report;
        }
    }
}
