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
            crvExame.ReportSource = report;
        }
    }
}
