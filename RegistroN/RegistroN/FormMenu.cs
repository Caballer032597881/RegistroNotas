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
            var formEstudiante = new FormEstudiante();
            formEstudiante.MdiParent = this;
            formEstudiante.Show();
        }
        
        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login();
        }

        private void Login()
        {
            var formLogin = new FormLogin();
            formLogin.ShowDialog();
        }

        private void maestrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formMaestros = new FormMaestros();
            formMaestros.MdiParent = this;
            formMaestros.Show();
        }

        private void FormMenu_Load(object sender, EventArgs e)
        {
            Login();
        }

        private void notasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formNotas = new FormNotas();
            formNotas.MdiParent = this;
            formNotas.Show();
        }
    }
}
