using MrPaper.BLL;
using MrPaper.Entidades;
using System;

using System.Windows.Forms;

namespace MrPaper.UI.Registros
{
    public partial class rSuplidores : Form
    {
        public rSuplidores()
        {
            InitializeComponent();
        }

        private void Limpiar()
        {
            SuplidorIdNumericUpDown.Value = 0;
            NombreEmpresaTextBox.Text = string.Empty;
            RNCTextBox.Text = string.Empty;
            DireccionTextBox.Text = string.Empty;
            TelefonoTextBox.Text = string.Empty;
            FechaRegDateTimePicker.Value = DateTime.Now;
        }

        private Suplidores LlenaClase()
        {
            Suplidores suplidores = new Suplidores();
            suplidores.SuplidorID = Convert.ToInt32(SuplidorIdNumericUpDown.Value);
            suplidores.NombreEmpresa = NombreEmpresaTextBox.Text;
            suplidores.RNC = RNCTextBox.Text;
            suplidores.Direccion = DireccionTextBox.Text;
            suplidores.Telefono = TelefonoTextBox.Text;
            suplidores.Fecha = FechaRegDateTimePicker.Value;
            return suplidores;
        }

        public bool Validar()
        {
            bool validar = false;
            if (String.IsNullOrEmpty(NombreEmpresaTextBox.Text))
            {
                errorProvider1.SetError(NombreEmpresaTextBox, "El campo *Nombre Empresarial* esta vacio");
                validar = true;
            }
            if (String.IsNullOrWhiteSpace(NombreEmpresaTextBox.Text))
            {
                errorProvider1.SetError(NombreEmpresaTextBox, "El campo *Nombre Empresarial* esta vacio");
                validar = true;
            }
            if (String.IsNullOrEmpty(RNCTextBox.Text))
            {
                errorProvider1.SetError(RNCTextBox, "El campo *RNC* esta vacio");
                validar = true;
            }
            if (String.IsNullOrWhiteSpace(RNCTextBox.Text))
            {
                errorProvider1.SetError(RNCTextBox, "El campo *RNC* esta vacio");
                validar = true;
            }
            if (String.IsNullOrEmpty(DireccionTextBox.Text))
            {
                errorProvider1.SetError(DireccionTextBox, "El campo *Dirección* esta vacio");
                validar = true;

            }
            if (String.IsNullOrWhiteSpace(DireccionTextBox.Text))
            {
                errorProvider1.SetError(DireccionTextBox, "El campo *Dirección* esta vacio");
                validar = true;
            }
            if (String.IsNullOrEmpty(TelefonoTextBox.Text))
            {
                errorProvider1.SetError(TelefonoTextBox, "El campo *Telefono* esta vacio");
                validar = true;

            }
            if (String.IsNullOrWhiteSpace(TelefonoTextBox.Text))
            {
                errorProvider1.SetError(TelefonoTextBox, "El campo *Telefono* esta vacio");
                validar = true;
            }
            return validar;
        }

        private bool ExisteEnLaBaseDeDatos()
        {
            Suplidores suplidores = SuplidoresBLL.Buscar((int)SuplidorIdNumericUpDown.Value);
            return (suplidores != null);
        }

        private void NuevoButton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void GuardarButton_Click(object sender, EventArgs e)
        {
            Suplidores suplidores;
            bool paso = false;
            if (Validar())
            {
                MessageBox.Show("Revisar todos los campos", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            suplidores = LlenaClase();

            if (SuplidorIdNumericUpDown.Value == 0)
                paso = SuplidoresBLL.Guardar(suplidores);
            else
            {
                if (!ExisteEnLaBaseDeDatos())
                {
                    MessageBox.Show("El Usuario no existe", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                paso = SuplidoresBLL.Modificar(suplidores);
            }
            Limpiar();

            if (paso)
                MessageBox.Show("Guardado!!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("No se pudo guardar!!", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void EliminarButton_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(SuplidorIdNumericUpDown.Value);
            if (SuplidoresBLL.Eliminar(id))
            {
                MessageBox.Show("Eliminado", "Exito!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("No se pudo eliminar", "Fallido", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Limpiar();
        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(SuplidorIdNumericUpDown.Value);
            Suplidores suplidores = SuplidoresBLL.Buscar(id);

            if (suplidores != null)
            {

                NombreEmpresaTextBox.Text = suplidores.NombreEmpresa;
                RNCTextBox.Text = suplidores.NombreEmpresa;
                DireccionTextBox.Text = suplidores.Direccion;
                TelefonoTextBox.Text = suplidores.Telefono;
            }
            else
                MessageBox.Show("No existente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void SuplidorIdNumericUpDown_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
