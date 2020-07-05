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

        string fechaInicio = null;
        string fechaFin = null;
        int iCodigoproducto = 0;

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

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            fechaInicio = dtp_inicio.Value.ToString("yyyy-MM-dd");
            fechaFin = dtp_fin.Value.ToString("yyyy-MM-dd");


            if(txtcodigoprod1.Text == "")
            {
                MessageBox.Show("Debe llenar todos los campos");
                return;
            }
            iCodigoproducto = Convert.ToInt32(txtcodigoprod1.Text);

            DataTable dtProductoKardex = logic.logicaGetProductoKardex(iCodigoproducto);
            foreach (DataRow row in dtProductoKardex.Rows)
            {
                txtcodigoprod2.Text = row[0].ToString();
                txtDescripcion.Text = row[1].ToString();
                txtExistencias.Text = row[2].ToString();
            }

            DataTable dtVentasKardex = logic.logicaGetVentasKardex(iCodigoproducto, fechaInicio, fechaFin);
            foreach (DataRow row in dtVentasKardex.Rows)
            {
                dgvKardex.Rows.Add(row[0].ToString(), row[1].ToString(), row[2].ToString(), row[3].ToString(), row[4].ToString());
            }

            DataTable dtComprasKardex = logic.logicaGetComprasKardex(iCodigoproducto, fechaInicio, fechaFin);
            foreach (DataRow row in dtComprasKardex.Rows)
            {
                dgvKardex.Rows.Add(row[0].ToString(), row[1].ToString(), row[2].ToString(), row[3].ToString(), row[4].ToString());
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            frm_repuestos repuestos = new frm_repuestos(1);
            AddOwnedForm(repuestos);
            repuestos.Show();
        }
    }
}
