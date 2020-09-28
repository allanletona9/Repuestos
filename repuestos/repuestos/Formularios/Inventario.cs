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
        List<int> lIdTipoPago = new List<int>();

        public Inventario()
        {
            MaximizeBox = false;
            InitializeComponent();
        }

        string fechaInicio = null;
        string fechaFin = null;
        int iCodigoproducto = 0;

        private void Inventario_Load(object sender, EventArgs e)
        {

            textBox10.SendToBack();
            textBox11.SendToBack();
            totalc.SendToBack();
            actualizarordenes();
            bloquear();
            MaximizeBox = false;
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


        void bloquear()
        {
            comboBox1.Enabled = false;
            comboBox2.Enabled = false;
            textBox6.Enabled = false;
            textBox7.Enabled = false;
            textBox8.Enabled = false;
            textBox9.Enabled = false;
            textBox2.Enabled = false;
            textBox3.Enabled = false;
            textBox4.Enabled = false;
            textBox5.Enabled = false;
            button4.Enabled = false;
            btn_guardarC.Enabled = false;
            btn_cancelarC.Enabled = false;


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

        private void llenarproveedores()
        {
            comboBox2.Items.Clear();
            lIdTipoPago.Clear();
            try
            {
                DataTable dtobtenertipoRep = logic.logic_ObtenerPreoveedores();

                foreach (DataRow row in dtobtenertipoRep.Rows)
                {
                    comboBox2.Items.Add(row[1].ToString());
                    lIdTipoPago.Add(Convert.ToInt32(row[0].ToString()));
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error en capa diseno recuperando los tipos de pago: " + ex.Message);
            }
        }


        private void llenarproductos()
        {
            comboBox1.Items.Clear();
            lIdTipoPago.Clear();
            try
            {
                DataTable dtobtenertipoRep = logic.logic_ObtenerPrductosOC();

                foreach (DataRow row in dtobtenertipoRep.Rows)
                {
                    comboBox1.Items.Add(row[1].ToString());
                    lIdTipoPago.Add(Convert.ToInt32(row[0].ToString()));
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error en capa diseno recuperando los tipos de pago: " + ex.Message);
            }
        }


        private void button5_Click(object sender, EventArgs e)
        {
            comboBox1.Enabled = true;
            comboBox2.Enabled = true;
            textBox6.Enabled = false;
            textBox7.Enabled = false;
            textBox8.Enabled = false;
            textBox9.Enabled = false;
            textBox2.Enabled = false;
            textBox3.Enabled = false;
            textBox4.Enabled = true;
            textBox5.Enabled = false;
            button4.Enabled = true;
            btn_guardarC.Enabled = true;
            btn_cancelarC.Enabled = true;

            llenarproveedores();
            llenarproductos();
        }

        private void btn_cancelarC_Click(object sender, EventArgs e)
        {
            comboBox1.Enabled = false;
            comboBox2.Enabled = false;
            textBox6.Enabled = false;
            textBox7.Enabled = false;
            textBox8.Enabled = false;
            textBox9.Enabled = false;
            textBox2.Enabled = false;
            textBox3.Enabled = false;
            textBox4.Enabled = false;
            textBox5.Enabled = false;
            button4.Enabled = false;
            btn_guardarC.Enabled = false;
            btn_cancelarC.Enabled = false;

            comboBox1.Text = "";
            comboBox2.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
            textBox9.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            dataGridView1.Columns.Clear();


        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string valor = comboBox2.SelectedItem.ToString();

            if (valor == null)
            {
                MessageBox.Show("Faltan campos por llenar");
            }
            else
            {

                DataTable dtConsultar = logic.logicaconsultadatos(valor);
                foreach (DataRow row in dtConsultar.Rows)
                {
                    textBox6.Text = row[1].ToString();
                    textBox8.Text = row[2].ToString();
                    textBox9.Text = row[3].ToString();
                    textBox7.Text = row[5].ToString();

                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string valor = comboBox1.SelectedItem.ToString();

            if (valor == null)
            {
                MessageBox.Show("Faltan campos por llenar");
            }
            else
            {

                DataTable dtConsultar = logic.productosoc(valor);
                foreach (DataRow row in dtConsultar.Rows)
                {
                    
                     if(row[3].ToString() != "0")
                    {
                        textBox11.Text = row[0].ToString();
                        textBox3.Text = row[2].ToString();
                        textBox2.Text = row[3].ToString();
                    }
                    else if (row[4].ToString() != "0")
                    {
                        textBox11.Text = row[0].ToString();
                        textBox3.Text = row[2].ToString();
                        textBox2.Text = row[4].ToString();
                    }
                    else if (row[5].ToString() != "0")
                    {
                        textBox11.Text = row[0].ToString();
                        textBox3.Text = row[2].ToString();
                        textBox2.Text = row[5].ToString();
                    }
                    else if (row[6].ToString() != "0")
                    {
                        textBox11.Text = row[0].ToString();
                        textBox3.Text = row[2].ToString();
                        textBox2.Text = row[6].ToString();
                    }
                     else
                        {
                             MessageBox.Show("Datos de Repuesto no Encontrado,\nVerificarlo en Mantenimientos/Repuestos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            label17.Text = DateTime.Now.ToString("yyyy-MM-dd");
             
        }


        void limpiar()
        {

            comboBox1.Text = "";
            comboBox2.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
            textBox9.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            dataGridView1.Columns.Clear();

        }


        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                int cantidad = 0;
                int costo = 0;
                int total = 0;

                costo = Convert.ToInt32(textBox2.Text);
                cantidad = Convert.ToInt32(textBox4.Text);

                total = costo * cantidad;

                totalc.Text = total.ToString();


                dataGridView1.Rows.Add(textBox11.Text,textBox3.Text, textBox4.Text, textBox2.Text, totalc.Text);
                comboBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Enabled = false;

                string cant = textBox5.Text;
                string mul = totalc.Text;

                int var1 = Convert.ToInt32(cant);
                int var2 = Convert.ToInt32(mul);
                int suma = 0;

                suma = var1 + var2;

               string total1 = suma.ToString();

                textBox5.Text = total1;

            }
            catch
            {
                MessageBox.Show("Favor Ingresar Datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_guardarC_Click(object sender, EventArgs e)
        {
            string total = textBox5.Text;
            string nombre = textBox6.Text;
            string fecha = DateTime.Now.ToString("yyyy-MM-dd");

            if ((total == null) && (fecha == null))
            {
                MessageBox.Show("Faltan campos por llenar");
            }
            else
            {

                DataTable dtConsultar = logic.ocEncabezadoProve(nombre);
               
                foreach (DataRow row in dtConsultar.Rows)
                {

                    textBox10.Text = row[0].ToString();
                    string id = textBox10.Text;
                    DataTable dtinsertar = logic.ocEncabezado(total,fecha,id);



                    string datos1;
                    string datos2;
                    string datos3;
                    string datos4;
                    string datos5;
                    string idproducto;
                    string idOC;


                    for (int i = 0; i < dataGridView1.Rows.Count; i++)
                    {
                        datos1 = dataGridView1.Rows[i].Cells[0].Value.ToString();
                        datos2 = dataGridView1.Rows[i].Cells[1].Value.ToString();
                        datos3 = dataGridView1.Rows[i].Cells[2].Value.ToString();
                        datos4 = dataGridView1.Rows[i].Cells[3].Value.ToString();
                        datos5 = dataGridView1.Rows[i].Cells[4].Value.ToString();

                      //  MessageBox.Show("Datos: " + datos2);
                        DataTable dtConsultars = logic.ocDetalleRepuesto(datos2);

                        foreach (DataRow rowss in dtConsultars.Rows)
                        {
                            idproducto = rowss[0].ToString();
                           // MessageBox.Show("Id Productos " + idproducto);

                            DataTable dtConsultarss = logic.ocDetallEcompra();

                            foreach (DataRow rowssS in dtConsultarss.Rows)
                            {
                                idOC = rowssS[0].ToString();
                               // MessageBox.Show("Id orden de Compra " + idOC);
                                DataTable insertarOC = logic.InsertarOC(idOC,idproducto, datos4, datos3);

                            }
                        }

                       
                    }

                    MessageBox.Show("Orden de Compra Guardada");
                    comboBox1.Text = "";
                    comboBox2.Text = "";
                    textBox6.Text = "";
                    textBox7.Text = "";
                    textBox8.Text = "";
                    textBox9.Text = "";
                    textBox2.Text = "";
                    textBox3.Text = "";
                    textBox4.Text = "";
                    textBox5.Text = "";
                    dataGridView1.Columns.Clear();
                    bloquear();

                    limpiar();
                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
           
            dataGridView1.Rows.Remove(dataGridView1.CurrentRow);
            string datos1;
            string datos2;
            string datos3;
            string datos4;
            string datos5;

            int suma = 0;

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                datos1 = dataGridView1.Rows[i].Cells[0].Value.ToString();
                datos2 = dataGridView1.Rows[i].Cells[1].Value.ToString();
                datos3 = dataGridView1.Rows[i].Cells[2].Value.ToString();
                datos4 = dataGridView1.Rows[i].Cells[3].Value.ToString();
                datos5 = dataGridView1.Rows[i].Cells[4].Value.ToString();

                int totals = Convert.ToInt32(datos5);

                suma = totals ;
            }

            string total1 = suma.ToString();
            textBox5.Text = total1;
        }


        void actualizarordenes()
        {
            try
            {
                DataTable dtobtenertipoRep = logic.ordenescompra();

                foreach (DataRow row in dtobtenertipoRep.Rows)
                {
                   dataGridView2.Rows.Add(row[0].ToString(), row[1].ToString(), row[2].ToString(), row[3].ToString());
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error en capa diseno recuperando los tipos de pago: " + ex.Message);
            }
        }

        void actualizar()
        {
            string datos1;
            string datos2;
            string datos3;
            string datos4;
            string datos5;

            int suma = 0;

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                datos1 = dataGridView1.Rows[i].Cells[0].Value.ToString();
                datos2 = dataGridView1.Rows[i].Cells[1].Value.ToString();
                datos3 = dataGridView1.Rows[i].Cells[2].Value.ToString();
                datos4 = dataGridView1.Rows[i].Cells[3].Value.ToString();
                datos5 = dataGridView1.Rows[i].Cells[4].Value.ToString();

                int totals = Convert.ToInt32(datos5);

                suma = totals + totals;
            }

            string total1 = suma.ToString();
            textBox5.Text = total1;
        }


        private void textBox10_TextChanged(object sender, EventArgs e)
        {
            
        }


    }
}
    
