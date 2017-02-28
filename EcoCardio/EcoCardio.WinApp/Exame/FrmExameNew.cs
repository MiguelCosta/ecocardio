using System.Windows.Forms;

namespace EcoCardio.WinApp.Exame
{
    public partial class FrmExameNew : Form
    {
        public FrmExameNew()
        {
            InitializeComponent();
        }

        public static void Open()
        {
            var frm = new FrmExameNew();
            frm.ShowDialog();
        }

        public static void Open(int exameId)
        {
            var frm = new FrmExameNew();
            frm.Text = "Editar Exame";
            frm.uscExameEditControl.SetExame(exameId);
            frm.ShowDialog();
        }
    }
}
