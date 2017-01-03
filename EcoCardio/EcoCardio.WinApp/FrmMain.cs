using System;
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
            // Inicia a ligação à base de dados
            GerallApp.AppRepository = new Repository.Implementation.AppUnitOfWork();

            // coisas a fazer quando abre o form

            // mostrar o splash screen
            var splash = new FrmSplashScreen();
            splash.ShowDialog();

            // Query de teste dos serviços

            // todos os servicos
            var servicos = GerallApp.AppRepository.Servicos.GetAll(); ;

            // servicos filtrados por nome
            var servicosNome = GerallApp.AppRepository.Servicos
                .GetBy(x => x.Nome.Contains("Dr"));

            // servico filtrado por Id
            var servicoId = GerallApp.AppRepository.Servicos
                .Find(1);

            // templates por um tipo
            var templateCavidadesCardiacas = GerallApp.AppRepository.Templates
                .GetBy(x => x.Type == Domain.Enums.TemplateType.CavidadesCardiacas);
        }
    }
}
