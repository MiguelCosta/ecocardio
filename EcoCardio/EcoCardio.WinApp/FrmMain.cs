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

            // se login OK
            var frm = new FrmInit();
            frm.MdiParent = this;
            frm.Show();

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

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void addServicoBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void grbPesquisas_Enter(object sender, EventArgs e)
        {

        }
    }
}
