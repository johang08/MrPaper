using MrPaper.UI.Consultas;
using MrPaper.UI.Registros;
using System;
using System.Windows.Forms;

namespace MrPaper
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Run(new rLogin());
        }

        private void comprasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Run(new rCompras());
        }

        private void suplidoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Run(new rSuplidores());
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Run(new rUsuarios());
        }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Run(new rProductos());
        }

        private void consultaComprasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Run(new cCompras());
        }

        private void consultaSuplidoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Run(new cSuplidores());
        }

        private void consultaUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Run(new cUsuarios());
        }

        private void consultaProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Run(new cProductos());
        }
    }
}
