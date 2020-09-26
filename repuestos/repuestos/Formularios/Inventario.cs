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
using Button = System.Windows.Forms.Button;

namespace repuestos.Formularios
{
    public partial class Inventario : Form
    {
        Logicpublic logic = new Logicpublic();
        Mantenimientos mantenimiento = new Mantenimientos();

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
                dgv_Inventario.Rows.Add(row[0].ToString(), row[1].ToString(), row[2].ToString(), row[3].ToString(), row[4].ToString(), row[5].ToString(), row[6].ToString(), row[7].ToString(), row[8].ToString(), row[9].ToString());
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

        private void dgv_Inventario_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
           
            textBox1.Text = dgv_Inventario.CurrentRow.Cells[1].Value.ToString();
           
        }

        private void btn_modC_Click(object sender, EventArgs e)
        {
          

            Mantenimientos repuestos = new Mantenimientos();
            AddOwnedForm(repuestos);
            repuestos.Show();
            
        }

       public void btn_eliminarI_Click(object sender, EventArgs e)
        {
            
            Mantenimientos repuestos = new Mantenimientos();       
            repuestos.Show();

            //mantenimiento.tabControl1.SelectedIndex = 2; //Para seleccionar la segunda pestaña.
           // mantenimiento.cargar_datos();


        }

        private void btn_ingresarC_Click(object sender, EventArgs e)
        {
            Mantenimientos repuestos = new Mantenimientos();
            AddOwnedForm(repuestos);
            repuestos.Show();

        }

       

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
          
        }

        private void tab_inventario_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void dgv_Inventario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Mantenimientos repuestos = new Mantenimientos();
            AddOwnedForm(repuestos);
            repuestos.Show();
        }

        private void ExportarDatoskardex(DataGridView dgvKardex)
        {
            try
            {
                Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application(); // Instancia a la libreria de Microsoft Office
                excel.Application.Workbooks.Add(true); //Con esto añadimos una hoja en el Excel para exportar los archivos
                int IndiceColumna = 0;
                foreach (DataGridViewColumn columna in dgvKardex.Columns) //Aquí empezamos a leer las columnas del listado a exportar
                {
                    IndiceColumna++;
                    excel.Cells[1, IndiceColumna] = columna.Name;
                }
                int IndiceFila = 0;
                foreach (DataGridViewRow fila in dgvKardex.Rows) //Aquí leemos las filas de las columnas leídas
                {
                    IndiceFila++;
                    IndiceColumna = 0;
                    foreach (DataGridViewColumn columna in dgvKardex.Columns)
                    {
                        IndiceColumna++;
                        excel.Cells[IndiceFila + 1, IndiceColumna] = fila.Cells[columna.Name].Value;
                    }
                }
                excel.Visible = true;
            }
            catch (Exception)
            {
                MessageBox.Show("No hay Registros a Exportar.");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ExportarDatoskardex(dgvKardex);
        }
        private void ExportarDatosInv(DataGridView dgv_Inventario)
        {
            try
            {
                Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application(); // Instancia a la libreria de Microsoft Office
                excel.Application.Workbooks.Add(true); //Con esto añadimos una hoja en el Excel para exportar los archivos
                int IndiceColumna = 0;
                foreach (DataGridViewColumn columna in dgv_Inventario.Columns) //Aquí empezamos a leer las columnas del listado a exportar
                {
                    IndiceColumna++;
                    excel.Cells[1, IndiceColumna] = columna.Name;
                }
                int IndiceFila = 0;
                foreach (DataGridViewRow fila in dgv_Inventario.Rows) //Aquí leemos las filas de las columnas leídas
                {
                    IndiceFila++;
                    IndiceColumna = 0;
                    foreach (DataGridViewColumn columna in dgv_Inventario.Columns)
                    {
                        IndiceColumna++;
                        excel.Cells[IndiceFila + 1, IndiceColumna] = fila.Cells[columna.Name].Value;
                    }
                }
                excel.Visible = true;
            }
            catch (Exception)
            {
                MessageBox.Show("No hay Registros a Exportar.");
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            ExportarDatosInv(dgv_Inventario);
        }

        private void txtcodigoprod2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                e.Handled = true;
                return;
            }
        }

        private void txtExistencias_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                e.Handled = true;
                return;
            }
        }
    }
}
