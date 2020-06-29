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
    public partial class frm_repuestos : Form
    {
        Logicpublic logic = new Logicpublic();
        public frm_repuestos()
        {
            InitializeComponent();
        }

        private void frm_repuestos_Load(object sender, EventArgs e)
        {
            ActualizarRepuestos();
        }

        void ActualizarRepuestos()
        {
            dgvRepuestos.Rows.Clear();
            DataTable dtInventario = logic.logic_ObtenerRepuestos();
            foreach (DataRow row in dtInventario.Rows)
            {
                dgvRepuestos.Rows.Add(row[0].ToString(), row[2].ToString(), row[3].ToString());
            }
        }

        private void dgvRepuestos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Inventario invt = Owner as Inventario;
            invt.txtcodigoprod1.Text = dgvRepuestos.CurrentRow.Cells[0].Value.ToString();
            this.Close();
        }
    }
}
