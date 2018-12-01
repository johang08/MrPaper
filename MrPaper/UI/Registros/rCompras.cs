using MrPaper.BLL;
using MrPaper.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MrPaper.UI.Registros
{
    public partial class rCompras : Form
    {
        public List<ProductosDetalle> Detalle { get; set; }

        public rCompras()
        {
            InitializeComponent();
            this.Detalle = new List<ProductosDetalle>();
            LlenaComboSuplidores();
            LlenaComboProductos();
        }


        private void CargarGrid()
        {
            ProductosDataGridView.DataSource = null;
            ProductosDataGridView.DataSource = this.Detalle;
        }

       private void  LlenaComboSuplidores()
       {
            List<Productos> lista = ProductosBLL.GetList(x => true);
            ProductosComboBox.DataSource = lista;
            ProductosComboBox.ValueMember = "ProductoId";
            ProductosComboBox.DisplayMember = "NombreProduct";
        }

        private void LlenaComboProductos()
        {
            List<Suplidores> lista = SuplidoresBLL.GetList(x => true);
            SuplidorComboBox.DataSource = lista;
            SuplidorComboBox.ValueMember = "SuplidorId";
            SuplidorComboBox.DisplayMember = "NombreEmpresa";
        }

    }
}
