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
    
    public partial class frm_clientes : Form
    {
        Logicpublic logic = new Logicpublic();
       
        public frm_clientes()
        {
            InitializeComponent();
        }

        private void frm_clientes_Load(object sender, EventArgs e)
        {
            ActualizarClientes();
        }

        void ActualizarClientes()
        {
            dgv_clientes.Rows.Clear();
            DataTable dtClientes = logic.logic_Obtenerclientes();
            foreach (DataRow row in dtClientes.Rows)
            {
                dgv_clientes.Rows.Add(row[0].ToString(), row[1].ToString(), row[2].ToString());
            }
        }

        private void dgv_clientes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Facturacion fact = Owner as Facturacion;
            fact.txtNombreCliente.Text = dgv_clientes.CurrentRow.Cells[1].Value.ToString();
            fact.txtNit.Text = dgv_clientes.CurrentRow.Cells[2].Value.ToString();
            fact.txtCodCliente.Text = dgv_clientes.CurrentRow.Cells[0].Value.ToString();
            this.Close();
        }
    }
}
