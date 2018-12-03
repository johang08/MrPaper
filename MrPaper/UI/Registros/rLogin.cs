using System;
using System.Windows.Forms;

namespace MrPaper.UI.Registros
{
    public partial class rLogin : Form
    {
        public rLogin()
        {
            InitializeComponent();
        }

        private void LogInicioButton_Click(object sender, EventArgs e)
        {
            string User = this.LoginUserTextBox.Text;
            string Password = this.LoginContraseñaTextBox.Text;

            if (User == "" || Password == "")
            {
                MessageBox.Show("  Inserte Usuario y Contraseña ", "STICS Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.LoginUserTextBox.Focus();
                return;
            }

        }

        private void LogCancelarButton_Click(object sender, EventArgs e)
        {
            
        }
    }
}
