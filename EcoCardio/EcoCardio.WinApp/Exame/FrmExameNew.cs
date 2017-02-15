using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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
    }
}
