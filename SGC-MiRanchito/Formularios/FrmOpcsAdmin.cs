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
    public partial class FrmOpcsAdmin : Form
    {
        public FrmOpcsAdmin()
        {
            InitializeComponent();
        }

        private void btnRespuestas_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FrmRespuestas().Show();

        }

        private void btnGraficos_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FrmGraficos().Show();
        }
    }
}
