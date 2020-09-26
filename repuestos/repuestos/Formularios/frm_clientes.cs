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
using Microsoft.Office.Interop.Excel;
using DataTable = System.Data.DataTable;

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

        private void dgv_clientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            dgv_clientes.Rows.Clear();
            string sNombre = textBox1.Text;
            string snit = textBox1.Text;

            try
            {
                DataTable dtBuscar2 = logic.logicaBuscarnit(snit);
                DataTable dtBuscar = logic.logicaBuscarclientes(sNombre);

                foreach (DataRow row in dtBuscar.Rows )
                {
                    dgv_clientes.Rows.Add(row[0].ToString(), row[1].ToString(), row[2].ToString(), row[3].ToString());

                }
                foreach (DataRow row in dtBuscar2.Rows)
                {
                    dgv_clientes.Rows.Add(row[0].ToString(), row[1].ToString(), row[2].ToString(), row[3].ToString());

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error en capa diseno recuperar clientes: " + ex.Message);
            }

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            dgv_clientes.Rows.Clear();
            string sNombre = textBox1.Text;
            string snit = textBox1.Text;

            try
            {
                DataTable dtBuscar2 = logic.logicaBuscarnit(snit);
                DataTable dtBuscar = logic.logicaBuscarclientes(sNombre);

                foreach (DataRow row in dtBuscar.Rows)
                {
                    dgv_clientes.Rows.Add(row[0].ToString(), row[1].ToString(), row[2].ToString(), row[3].ToString());

                }
                foreach (DataRow row in dtBuscar2.Rows)
                {
                    dgv_clientes.Rows.Add(row[0].ToString(), row[1].ToString(), row[2].ToString(), row[3].ToString());

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error en capa diseno recuperar clientes: " + ex.Message);
            }
        }
    }
}
