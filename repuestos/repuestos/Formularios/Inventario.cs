using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logic;

namespace repuestos.Formularios
{
    public partial class Inventario : Form
    {
        Logicpublic logic = new Logicpublic();
        public Inventario()
        {
            InitializeComponent();
        }

        private void Inventario_Load(object sender, EventArgs e)
        {

        }

        void ActualizarInventario()
        {
            dgv_Inventario.Rows.Clear();
            DataTable dtInventario = logic.logicaGetInventario();
            foreach (DataRow row in dtInventario.Rows)
            {
                dgv_Inventario.Rows.Add(row[0].ToString(), row[1].ToString(), row[2].ToString(), row[3].ToString(), row[4].ToString(), row[5].ToString(), row[6].ToString(), row[7].ToString());
            }
        }

        private void tabInventarioGeneral_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabInventarioGeneral.SelectedTab == tab_inventario)
            {
                ActualizarInventario();
            }
        }
    }
}
