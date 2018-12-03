using MrPaper.BLL;
using MrPaper.Entidades;
using System;
using System.Windows.Forms;

namespace MrPaper.UI.Registros
{
    public partial class rProductos : Form
    {
        public rProductos()
        {
            InitializeComponent();
        }

        private void Limpiar()
        {
            ProductosIDNumericUpDown.Value = 0;
            NombreProductoTextBox.Text = string.Empty;
            CostoTextBox.Text = string.Empty;
            PrecioTextBox.Text = string.Empty;
            GananciaTextBox.Text = string.Empty;
            InventarioTextBox.Text = string.Empty;
            DescripcionRichTextBox.Text = string.Empty;
            FechaProductosDateTimePicker.Value = DateTime.Now;
        }

        private Productos LlenaClase()
        {
            Productos productos = new Productos();
            productos.ProductoId = Convert.ToInt32(ProductosIDNumericUpDown.Value);
            productos.NombreProduct = NombreProductoTextBox.Text;
            productos.Costo = Convert.ToInt32(CostoTextBox.Text);
            productos.Precio = Convert.ToInt32 (PrecioTextBox.Text);
            productos.Ganancia = Convert.ToInt32 (GananciaTextBox.Text);
            productos.Inventario = Convert.ToInt32 (InventarioTextBox.Text);
            productos.Descripcion = DescripcionRichTextBox.Text;
            productos.FechaProductos = FechaProductosDateTimePicker.Value;
            return productos;
        }
        private bool ExisteEnLaBaseDeDatos()
        {
            Productos productos = ProductosBLL.Buscar((int)ProductosIDNumericUpDown.Value);
            return (productos != null);
        }

        private void NuevoButton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void GuardarButton_Click(object sender, EventArgs e)
        {
            Productos productos;
            bool paso = false;
            if (Validate())
            {
                MessageBox.Show("Revisar todos los campos", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            productos = LlenaClase();

            if (ProductosIDNumericUpDown.Value == 0)
                paso = ProductosBLL.Guardar(productos);
            else
            {
                if (!ExisteEnLaBaseDeDatos())
                {
                    MessageBox.Show("El Producto no existe", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                paso = ProductosBLL.Modificar(productos);
            }
            Limpiar();

            if (paso)
                MessageBox.Show("Guardado!!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("No se pudo guardar!!", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void EliminarButton_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(ProductosIDNumericUpDown.Value);
            if (ProductosBLL.Eliminar(id))
            {
                MessageBox.Show("Eliminado", "Exito!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("No se pudo eliminar", "Fallido", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Limpiar();
        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(ProductosIDNumericUpDown.Value);
            Productos productos = ProductosBLL.Buscar(id);

            if (productos != null)
            {

                NombreProductoTextBox.Text = productos.NombreProduct;
                DescripcionRichTextBox.Text = productos.Descripcion;
            }
            else
                MessageBox.Show("No existente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
    }

