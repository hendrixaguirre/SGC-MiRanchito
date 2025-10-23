using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SGC_MiRanchito.Formularios
{
    public partial class FrmOpciones : Form
    {
        public FrmOpciones()
        {
            InitializeComponent();
        }

        private void btnAdministrador_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FrmAdministrador().Show();
        }

        private void btnSupervisor_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FrmSupervisor().Show();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
