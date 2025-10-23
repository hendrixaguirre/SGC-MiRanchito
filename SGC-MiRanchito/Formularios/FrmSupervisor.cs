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
    public partial class FrmSupervisor : Form
    {
        public FrmSupervisor()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            this.Hide();
            if (tbPassword.Text == "chesteram")
            {
                this.Hide();
                new FrmOpcsSuper().Show();
            }
            else
            {
                MessageBox.Show("Usuario o Contraseña Incorrecta");
                tbPassword.Clear();
                tbPassword.Focus();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
            new FrmOpciones().Show();
        }
    }
}
