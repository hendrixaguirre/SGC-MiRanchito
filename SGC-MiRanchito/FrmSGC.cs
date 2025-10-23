using SGC_MiRanchito.Formularios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SGC_MiRanchito
{

    public partial class FrmSGC : Form
    {
        public FrmSGC()
        {
            InitializeComponent();
        }

        private void iniciarSesiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FrmOpciones().Show();
        }
    }
}
