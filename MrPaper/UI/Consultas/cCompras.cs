using MrPaper.BLL;
using MrPaper.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MrPaper.UI.Consultas
{
    public partial class cCompras : Form
    {
        private List<Compras> Listaventas = new List<Compras>();

        public cCompras()
        {
            InitializeComponent();
        }

        public object FiltrarComboBox { get; private set; }

        private void BuscarVentasButton_Click(object sender, EventArgs e)
        {
            Expression<Func<Compras, bool>> filtro = a => true;

            switch (FiltrarComboBox.SelectedIndex)
            {
                case 0://Fecha
                    filtro = a => a.Fecha >= FechaCompras1DateTimePicker.Value.Date && a.Fecha <= FechaCompras2DateTimePicker.Value.Date;
                    break;
                case 1://Total
                    filtro = a => a.TotalAPagar.Equals(CriterioTextBox.Text);
                    break;
            }

            Listaventas = ComprasBLL.GetList(filtro);
            ConsultaDataGridView.DataSource = Listaventas;
        }
    }
}
