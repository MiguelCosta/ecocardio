using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace EcoCardio.WinApp
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            // coisas a fazer quando se fecha o form
            // fechar a ligação à base de dados por exemplo
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            // coisas a fazer quando abre o form

            // mostrar o splash screen
            var splash = new FrmSplashScreen();
            splash.ShowDialog();

            // Query de teste dos serviços

            // todos os servicos
            var servicos = GerallApp.EcoCardioContext.Servicos.ToList();

            // servicos filtrados por nome
            var servicosNome = GerallApp.EcoCardioContext.Servicos
                .Where(x => x.Nome == "A")
                .ToList();

            // servico filtrado por Id
            var servicoId = GerallApp.EcoCardioContext.Servicos
                .Where(x => x.Id == 1)
                .First();

            var servicoId2 = GerallApp.EcoCardioContext.Servicos
                .First(x => x.Id == 1);
        }
    }
}
