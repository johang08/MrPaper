using MrPaper.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace MrPaper.UI.Consultas
{
    public partial class cSuplidores : Form
    {
        public cSuplidores()
        {
            InitializeComponent();
        }

        public object CriterioTextBox { get; private set; }

        private void button1_Click(object sender, EventArgs e)
        {
            Expression<Func<Suplidores, bool>> Filtro = a => true;

            var listado = new List<Suplidores>();

            if (CriterioTextBox.Text.Trim().Length > 0)
            {
                switch (FiltrarComboBox.SelectedIndex)
                {
                    case 0://Todo
                        listado = SuplidoresBLL.GetList(p => true);
                        break;
                    case 1://Nombres
                        listado = SuplidoresBLL.GetList(p => p.Nombres.Contains(CriterioTextBox.Text));
                        break;
                    case 2: //NombreUsuario
                        listado = SuplidoresBLL.GetList(p => p.NombreSuplidor.Contains(CriterioTextBox.Text));
                        break;
                    case 3: //TipoUsuario
                        listado = SuplidoresBLL.GetList(p => p.TipoUsuario.Contains(CriterioTextBox.Text));
                        break;
                }

            }
            else
                listado = SuplidoresBLL.GetList(p => true);

            ConsultaDataGridView.DataSource = null;
            ConsultaDataGridView.DataSource = listado;
        }
    }
}
