using MrPaper.BLL;
using MrPaper.Entidades;
using System;
using System.Windows.Forms;

namespace MrPaper.UI.Registros
{
    public partial class rUsuarios : Form
    {
        public rUsuarios()
        {
            InitializeComponent();
        }

        private void Limpiar()
        {
            UsuarioIdNumericUpDown.Value = 0;
            NombreTextBox.Text = string.Empty;
            NombreUserTextBox.Text = string.Empty;
            ClaveTextBox.Text = string.Empty;
            ConfirmarClaveTextBox.Text = string.Empty;
            FechaDateTimePicker.Value = DateTime.Now;
        }

        private Usuarios LlenaClase()
        {
            Usuarios usuario = new Usuarios();
            usuario.UsuarioId = Convert.ToInt32(UsuarioIdNumericUpDown.Value);
            usuario.Nombre = NombreTextBox.Text;
            usuario.NombreUser = NombreUserTextBox.Text;
            usuario.Clave = ClaveTextBox.Text;
            usuario.ConfirmarClave = ConfirmarClaveTextBox.Text;
            usuario.TipoUsuario = TipoUsuarioComboBox.Text;
            usuario.Fecha = FechaDateTimePicker.Value;
            return usuario;
        }

        public bool Validar()
        {
            bool validar = false;
            if (String.IsNullOrEmpty(NombreTextBox.Text))
            {
                errorProvider1.SetError(NombreTextBox, "El campo *Nombres* esta vacio");
                validar = true;
            }
            if (String.IsNullOrWhiteSpace(NombreTextBox.Text))
            {
                errorProvider1.SetError(NombreTextBox, "El campo *Nombres* esta vacio");
                validar = true;
            }
            if (String.IsNullOrEmpty(NombreUserTextBox.Text))
            {
                errorProvider1.SetError(NombreUserTextBox, "El campo *Nombre de usuario* esta vacio");
                validar = true;
            }
            if (String.IsNullOrWhiteSpace(NombreUserTextBox.Text))
            {
                errorProvider1.SetError(NombreUserTextBox, "El campo *Nombre de usuario* esta vacio");
                validar = true;
            }
            if (String.IsNullOrEmpty(ClaveTextBox.Text))
            {
                errorProvider1.SetError(ClaveTextBox, "El campo *Contraseña* esta vacio");
                validar = true;

            }
            if (String.IsNullOrWhiteSpace(ClaveTextBox.Text))
            {
                errorProvider1.SetError(ClaveTextBox, "El campo *Contraseña* esta vacio");
                validar = true;
            }
            if (String.IsNullOrEmpty(ConfirmarClaveTextBox.Text))
            {
                errorProvider1.SetError(ConfirmarClaveTextBox, "El campo *Contraseña* esta vacio");
                validar = true;

            }
            if (String.IsNullOrWhiteSpace(ConfirmarClaveTextBox.Text))
            {
                errorProvider1.SetError(ConfirmarClaveTextBox, "El campo *Contraseña* esta vacio");
                validar = true;
            }
            if (String.IsNullOrEmpty(TipoUsuarioComboBox.Text))
            {
                errorProvider1.SetError(TipoUsuarioComboBox, "No a seleccionado en el campo *Tipo de usuario*");
                validar = true;
            }
            if (ClaveTextBox.Text != ClaveTextBox.Text)
            {
                errorProvider1.SetError(ClaveTextBox, "Revise las contraseñas, no son identicas");
                validar = true;
            }
            if (ClaveTextBox.Text != ClaveTextBox.Text)
            {
                errorProvider1.SetError(ClaveTextBox, "Revise las contraseñas, no son identicas");
                validar = true;
            }
            return validar;
        }

        private bool ExisteEnLaBaseDeDatos()
        {
            Usuarios usuario = UsuariosBLL.Buscar((int)UsuarioIdNumericUpDown.Value);
            return (usuario != null);
        }

        private void NuevoButton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void GuardarButton_Click(object sender, EventArgs e)
        {
            Usuarios usuario;
            bool paso = false;
            if (Validar())
            {
                MessageBox.Show("Revisar todos los campos", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            usuario = LlenaClase();

            if (UsuarioIdNumericUpDown.Value == 0)
                paso = UsuariosBLL.Guardar(usuario);
            else
            {
                if (!ExisteEnLaBaseDeDatos())
                {
                    MessageBox.Show("El Usuario no existe", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                paso = UsuariosBLL.Modificar(usuario);
            }
            Limpiar();

            if (paso)
                MessageBox.Show("Guardado!!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("No se pudo guardar!!", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void EliminarButton_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(UsuarioIdNumericUpDown.Value);
            if (UsuariosBLL.Eliminar(id))
            {
                MessageBox.Show("Eliminado", "Exito!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("No se pudo eliminar", "Fallido", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Limpiar();
        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(UsuarioIdNumericUpDown.Value);
            Usuarios usuario = UsuariosBLL.Buscar(id);

            if (usuario != null)
            {

                NombreTextBox.Text = usuario.Nombre;
                NombreUserTextBox.Text = usuario.NombreUser;
                ClaveTextBox.Text = usuario.Clave;
                ConfirmarClaveTextBox.Text = usuario.ConfirmarClave;
                TipoUsuarioComboBox.Text = usuario.TipoUsuario;
            }
            else
                MessageBox.Show("No existente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void UsuarioIdNumericUpDown_ValueChanged(object sender, EventArgs e)
        {

        }

        private void ClaveTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
