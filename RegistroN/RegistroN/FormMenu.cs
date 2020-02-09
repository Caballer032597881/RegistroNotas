using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegistroN
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void calificacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void reporteDeMaestroToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void alumnosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formEstudiantes = new FormEstudiantes();
            formEstudiantes.MdiParent = this;
            formEstudiantes.ShowDialog();
        }
        
        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formLogin = new FormLogin();
            formLogin.ShowDialog();
        }
    }
}
