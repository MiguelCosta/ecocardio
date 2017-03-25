using CrystalDecisions.CrystalReports.Engine;
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
            string filePath = Properties.Settings.Default.ReportPathExame;
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
