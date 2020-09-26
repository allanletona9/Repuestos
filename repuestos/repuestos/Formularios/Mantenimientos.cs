using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using Microsoft.Office.Interop.Excel;
using DataTable = System.Data.DataTable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logic;
using System.Data.SqlClient;
using Button = System.Windows.Forms.Button;

namespace repuestos.Formularios
{
    public partial class Mantenimientos : Form
    {
        Logicpublic logic = new Logicpublic();
        bool boton_ingreso = false;
        bool boton_modificar = false;
        bool boton_eliminar = false;
        List<int> lIdTipoPago = new List<int>();
        public Mantenimientos()
        {
            InitializeComponent();
            LoadTheme();
            rdb_actio.Checked = true;
            rdb_actioC.Checked = true;
            rdb_actioP.Checked = true;
            rdb_actioM.Checked = true;
            rdb_actioT.Checked = true;
            rdb_actioTP.Checked = true;
            rdb_actioU.Checked = true;
            Btn_guardar.Enabled = false;
            btn_guardarC.Enabled = false;
            btn_guardarP.Enabled = false;
            btn_guardarM.Enabled = false;
            btn_guardarT.Enabled = false;
            btn_guardarU.Enabled = false;
            btn_tipoRe.Enabled = false;
            bloquearTextBox();
            bloquearTextBoxC();
            bloquearTextBoxP();
            bloquearTextBoxM();
            bloquearTextBoxT();
            bloquearTextBoxTP();
            bloquearTextBoxU();
           


        }
        private void LoadTheme()
        {
            foreach (Control btns in this.Controls)
            {
                if (btns.GetType() == typeof(Button))
                {
                    Button btn = (Button)btns;
                    btn.BackColor = ThemeColor.PrimaryColor;
                    btn.ForeColor = Color.White;
                    btn.FlatAppearance.BorderColor= ThemeColor.SecondaryColor;
                }
            }
            //label5.ForeColor = ThemeColor.PrimaryColor;
            //groupBox1.ForeColor = ThemeColor.SecondaryColor;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Repuestos_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        public void tabPage9_Click(object sender, EventArgs e)
        {
            llenarTipoRepuesto();
        }
        
            
        

        private void label5_Click(object sender, EventArgs e)
        {

        }

        public void tabControl1_Load(object sender, EventArgs e)
        {
            

        }

        private void tabPage10_Load(object sender, EventArgs e)
        {
            //logic.logic_ObtenerRepuestos();
           
        }
     
        private void Mantenimientos_Load(object sender, EventArgs e)
        {
           tabControl1.SelectedTab = Repuestos;

          
            comboBox1.Items.Add("Precio Venta 1");
            comboBox1.Items.Add("Precio Venta 2");
            comboBox1.Items.Add("Precio Venta 3");
            comboBox1.Items.Add("Precio Venta 4");
            Actualizarrepuesto();
            txt_precio1.Text= "0.00";
            txt_precio2.Text = "0.00";
            txt_precio3.Text = "0.00";
            txt_precio4.Text = "0.00";
            txt_venta1.Text = "0.00";
            txt_venta2.Text = "0.00";
            txt_venta3.Text = "0.00";
            txt_venta4.Text = "0.00";
            txt_cantidad.Text = "0.00";
            textBox9.Text = "0 %";
            textBox8.Text = "0 %";
            textBox7.Text = "0 %";
            textBox6.Text = "0 %";
        }
        public void cargar_Repuestos()
        {

            

        }

        public void cargar_datos() {
            //this.Close();
            //tabControl1.SelectedTab = Repuestos;
         //   tabControl2.SelectedTab = tabPage10;

            //this.Show();

        }

    void Actualizarcliente()
        {

            dvgClientes.Rows.Clear();
            DataTable dtobtenerclientes = logic.logic_Obtenerclientes();
            foreach (DataRow row in dtobtenerclientes.Rows)
            {
                dvgClientes.Rows.Add(row[0].ToString(), row[1].ToString(), row[2].ToString(), row[4].ToString());
            }
        }

        void Actualizarrepuesto()
        {
            dvgRepuestos.Rows.Clear();
            DataTable dtobtenerProductos = logic.logic_ObtenerRepuestos();
            foreach (DataRow row in dtobtenerProductos.Rows)
            {
                dvgRepuestos.Rows.Add(row[0].ToString(), row[1].ToString(), row[2].ToString(), row[3].ToString(), row[4].ToString(), row[5].ToString(), row[6].ToString(), row[7].ToString(), row[8].ToString(), row[9].ToString(), row[10].ToString(), row[11].ToString(), row[12].ToString(), row[13].ToString(), row[14].ToString());
            }
        }

        void ActualizarProveedores()
        {

            dvgProveedores.Rows.Clear();
            DataTable dtobtenerproveedores = logic.logic_Obtenerproveedores();
            foreach (DataRow row in dtobtenerproveedores.Rows)
            {
                dvgProveedores.Rows.Add(row[0].ToString(), row[1].ToString(), row[2].ToString(), row[3].ToString(), row[5].ToString());
            }
        }
        void ActualizarMarca()
        {

            dvgMarca.Rows.Clear();
            DataTable dtobtenermarca = logic.logic_Obtenermarca();
            foreach (DataRow row in dtobtenermarca.Rows)
            {
                dvgMarca.Rows.Add(row[0].ToString(), row[1].ToString(), row[3].ToString());
            }
        }
        void ActualizarPago()
        {

            dvgPago.Rows.Clear();
            DataTable dtobtenerpago = logic.logic_Obtenerpago();
            foreach (DataRow row in dtobtenerpago.Rows)
            {
                dvgPago.Rows.Add(row[0].ToString(), row[1].ToString(), row[3].ToString());
            }
        }

        void Actualizarusuarios()
        {

            dvg_usuarios.Rows.Clear();
            DataTable dtobtenerusuarios = logic.logic_Obtenerusuarios();
            foreach (DataRow row in dtobtenerusuarios.Rows)
            {
                dvg_usuarios.Rows.Add(row[0].ToString(), row[1].ToString(), row[2].ToString(), row[5].ToString());
            }
        }
        
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            dvgRepuestos.Rows.Clear();
            string sNombre1 = txtBuscar1.Text;

            try
            {
                DataTable dtBuscar = logic.logicaBuscarRepuestos(sNombre1);

                foreach (DataRow row in dtBuscar.Rows)
                {
                 dvgRepuestos.Rows.Add(row[0].ToString(), row[1].ToString(), row[2].ToString(), row[3].ToString(), row[4].ToString(), row[5].ToString(), row[6].ToString(), row[7].ToString(), row[8].ToString(), row[9].ToString(), row[10].ToString(), row[11].ToString(), row[12].ToString(), row[13].ToString(), row[14].ToString());
                  
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error en capa diseno recuperar repuestos: " + ex.Message);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            habilitarBotonesC();
            bloquearBotonesC();
            txt_nombreC.Text = "";
            txt_nitC.Text = "";
            gpb_estadoC.Enabled = false;
            boton_ingreso = true;
            tabControl3.SelectedTab = tabPage1;



      
        }
        void habilitarBotones()
        {
            txt_codigo.Enabled = true;
            comboBox2.Enabled = true;
            txt_precio1.Enabled = true;
            txt_precio2.Enabled = true;
            txt_precio3.Enabled = true;
            txt_precio4.Enabled = true;
            txt_venta1.Enabled = true;
            txt_venta2.Enabled = true;
            txt_venta3.Enabled = true;
            txt_venta4.Enabled = true;
            txt_codF.Enabled = true;   
            txt_descrip.Enabled = true;
            txt_cantidad.Enabled = true;
            txt_preciofac.Enabled = true;
            comboBox1.Enabled = true;
            gpb_estado.Enabled = true;
            gpb_fact_sin_exp.Enabled = true;
            llenarTipoRepuesto();
        }
        void habilitarBotonesC()
        {
            txt_codC.Enabled = false;
            txt_nombreC.Enabled = true;
            txt_nitC.Enabled = true;
            gpb_estadoC.Enabled = true;
        }
        void habilitarBotonesP()
        {
            txt_codP.Enabled = false;
            txt_nombreP.Enabled = true;
            txt_nitP.Enabled = true;
            txt_direccionP.Enabled = true;
            gpb_estadoP.Enabled = true;
        }
        void habilitarBotonesM()
        {
            txt_codM.Enabled = false;
            txt_nombreM.Enabled = true;
            gpb_estadoM.Enabled = true;
        }
        void habilitarBotonesT()
        {
            txt_codT.Enabled = false;
            txt_nombreT.Enabled = true;
            gpb_estadoT.Enabled = true;
        }
        void habilitarBotonesTP()
        {
            txt_cod_tipo_re.Enabled = false;
            txt_nombre_tipoRe.Enabled = true;
            gpb_estadoTP.Enabled = true;
        }
        void habilitarBotonesU()
        {
            txt_codU.Enabled = false;
            txt_nombreU.Enabled = true;
            txt_apellidoU.Enabled = true;
            txt_passwordU.Enabled = true;
            gpb_estadoU.Enabled = true;
        }
        void bloquearBotones()
        {
            Btn_eliminar.Enabled = false;
            Btn_ingresar.Enabled = false;
            Btn_modificar.Enabled = false;
            Btn_guardar.Enabled = true;
            llenarTipoRepuesto();
        }
        void bloquearBotonesC()
        {
            btn_eliminarC.Enabled = false;
            btn_ingresarC.Enabled = false;
            btn_modC.Enabled = false;
            btn_guardarC.Enabled = true;
        }
        void bloquearBotonesP()
        {
            btn_eliminarP.Enabled = false;
            btn_ingresarP.Enabled = false;
            btn_modP.Enabled = false;
            btn_guardarP.Enabled = true;
        }
        void bloquearBotonesM()
        {
            btn_eliminarM.Enabled = false;
            btn_ingresarM.Enabled = false;
            btn_modificarM.Enabled = false;
            btn_guardarM.Enabled = true;
        }
        void bloquearBotonesT()
        {
            btn_eliminarT.Enabled = false;
            btn_ingresarT.Enabled = false;
            btn_modT.Enabled = false;
            btn_guardarT.Enabled = true;
        }
        void bloquearBotonesTP()
        {
            btn_modEl.Enabled = false;
            btn_nuevoTP.Enabled = false;
            btn_modTP.Enabled = false;
            btn_tipoRe.Enabled = true;
        }
        void bloquearBotonesU()
        {
            btn_eliminarU.Enabled = false;
            btn_ingresarU.Enabled = false;
            btn_modU.Enabled = false;
            btn_guardarU.Enabled = true;
        }
        void bloquearTextBox()
        {
            txt_codigo.Enabled = false;
            comboBox2.Enabled = false;
            txt_precio1.Enabled = false;
            txt_precio2.Enabled = false;
            txt_precio3.Enabled = false;
            txt_precio4.Enabled = false;
            txt_venta1.Enabled = false;
            txt_venta2.Enabled = false;
            txt_venta3.Enabled = false;
            txt_venta4.Enabled = false;
            txt_codF.Enabled = false;
            txt_descrip.Enabled = false;
            txt_preciofac.Enabled = false;
            comboBox1.Enabled = false;
            txt_cantidad.Enabled = false;
            gpb_estado.Enabled = false;
            gpb_fact_sin_exp.Enabled = false;
        }
        void bloquearTextBoxC()
        {
            txt_codC.Enabled = false;
            txt_nombreC.Enabled = false;
            txt_nitC.Enabled = false;
            gpb_estadoC.Enabled = false;
        }
        void bloquearTextBoxP()
        {
            txt_codP.Enabled = false;
            txt_nombreP.Enabled = false;
            txt_nitP.Enabled = false;
            txt_direccionP.Enabled = false;
            gpb_estadoP.Enabled = false;
        }
        void bloquearTextBoxM()
        {
            txt_codM.Enabled = false;
            txt_nombreM.Enabled = false;
            gpb_estadoM.Enabled = false;
        }
        void bloquearTextBoxT()
        {
            txt_codT.Enabled = false;
            txt_nombreT.Enabled = false;
            gpb_estadoT.Enabled = false;
        }
        void bloquearTextBoxTP()
        {
            txt_cod_tipo_re.Enabled = false;
            txt_nombre_tipoRe.Enabled = false;
            gpb_estadoTP.Enabled = false;
        }
        void bloquearTextBoxU()
        {
            txt_codU.Enabled = false;
            txt_nombreU.Enabled = false;
            txt_apellidoU.Enabled = false;
            txt_passwordU.Enabled = false;
            gpb_estadoU.Enabled = false;


          
        }
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            habilitarBotones();
            bloquearBotones();
            txt_descrip.Text = "";
            gpb_estado.Enabled = false;
            boton_ingreso = true;
            tabControl2.SelectedTab = MantenimientoR;
            llenarTipoRepuesto();
            txt_precio1.Text = "0.00";
            txt_precio2.Text = "0.00";
            txt_precio3.Text = "0.00";
            txt_precio4.Text = "0.00";
            txt_venta1.Text = "0.00";
            txt_venta2.Text = "0.00";
            txt_venta3.Text = "0.00";
            txt_venta4.Text = "0.00";
            txt_cantidad.Text = "0.00";
            textBox9.Text = "0 %";
            textBox8.Text = "0 %";
            textBox7.Text = "0 %";
            textBox6.Text = "0 %";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            dvgClientes.Rows.Clear();
            string sNombre = textBox10.Text;
            string snit= textBox10.Text;

            try
            {
                DataTable dtBuscar2 = logic.logicaBuscarnit(snit);
                DataTable dtBuscar = logic.logicaBuscarclientes(sNombre);

                foreach (DataRow row in dtBuscar.Rows)
                {
                    dvgClientes.Rows.Add(row[0].ToString(), row[1].ToString(), row[2].ToString(), row[4].ToString());

                }
                foreach (DataRow row in dtBuscar2.Rows)
                {
                    dvgClientes.Rows.Add(row[0].ToString(), row[1].ToString(), row[2].ToString(), row[4].ToString());

                }


            }
            catch (Exception ex)
            {
                Console.WriteLine("Error en capa diseno recuperar clientes: " + ex.Message);
            }
        }

    


    private void btnCancelar_Click(object sender, EventArgs e)
        {
            limpiarForm();
            bloquearTextBox();
            Btn_ingresar.Enabled = true;
            rdb_actio.Checked = true;
            boton_eliminar = false;
            boton_modificar = false;
            boton_ingreso = false;
            txt_precio1.Text = "0.00";
            txt_precio2.Text = "0.00";
            txt_precio3.Text = "0.00";
            txt_precio4.Text = "0.00";
            txt_venta1.Text = "0.00";
            txt_venta2.Text = "0.00";
            txt_venta3.Text = "0.00";
            txt_venta4.Text = "0.00";
            txt_cantidad.Text = "0.00";
            textBox9.Text = "0 %";
            textBox8.Text = "0 %";
            textBox7.Text = "0 %";
            textBox6.Text = "0 %";

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            

            string sdescripcion = txt_descrip.Text;
            //string sPrecio_unitario = txt_precio1.Text;
           
            string sid_tipo_repuesto = lIdTipoPago[comboBox2.SelectedIndex].ToString();    
            string scod_fabricante =txt_codF.Text;  
            string scosto_repuesto1 =txt_precio1.Text;
            string scosto_repuesto2 = txt_precio2.Text;
            string scosto_repuesto3 = txt_precio3.Text;
            string scosto_repuesto4 = txt_precio4.Text;
            string sprecio_venta1= txt_venta1.Text;
            string sprecio_venta2 = txt_venta2.Text;
            string sprecio_venta3 = txt_venta3.Text;
            string sprecio_venta4 = txt_venta4.Text;
            int scantidad = Convert.ToInt32(txt_cantidad.Text); 
            string spreciofac = txt_preciofac.Text;
            string sfacturar_sin_existencia =gpb_fact_sin_exp.Text;
            string sEstado1 = ""; 
            int sprecio_factura = Convert.ToInt32(txt_preciofac.Text);
            int iCodigo = Convert.ToInt32(txt_codigo.Text);

           
                  
                   
          
            if (boton_ingreso == true)
            {
              
                if (txt_codF.Text == "" || txt_descrip.Text == "" || txt_precio1.Text == "" || txt_precio2.Text == "" || txt_precio3.Text == "" || txt_precio4.Text == "" || txt_venta1.Text == "" || txt_venta2.Text == "" || txt_venta3.Text == "" || txt_venta4.Text == "" || txt_cantidad.Text == "" )
                {
                   
                    MessageBox.Show("Faltan campos por llenar");
                }

                else
                {
                    if (rdb_actio1.Checked)
                        sEstado1 = "1";
                    else
                        sEstado1 = "0";
                    DataTable dtInsertar = logic.logicaInsertarRepuestos(iCodigo, sid_tipo_repuesto, scod_fabricante, sdescripcion, scosto_repuesto1, scosto_repuesto2, scosto_repuesto3, scosto_repuesto4, sprecio_venta1, sprecio_venta2, sprecio_venta3, sprecio_venta4, scantidad,sEstado1,sprecio_factura);
                    DataTable dtInsertarI = logic.logicaInsertarinventario(iCodigo);
                    MessageBox.Show("Repuestos Ingresado Exitosamente e Inventario actualizado");
                    dvgRepuestos.Rows.Clear();
                    limpiarForm();
                    Actualizarrepuesto();
                }

            }
            else if (boton_modificar == true)
            {
                if (txt_codF.Text == "" || txt_descrip.Text == "" || txt_precio1.Text == "" || txt_precio2.Text == "" || txt_precio3.Text == "" || txt_precio4.Text == "" || txt_venta1.Text == "" || txt_venta2.Text == "" || txt_venta3.Text == "" || txt_venta4.Text == "" || txt_cantidad.Text == "" || txt_codigo.Text == "")
                {
                    MessageBox.Show("Faltan campos por llenar");
                }
                else
                {
                   
                    string sEstado = "";
                    string sEstado2 = "";
                    if (rdb_actio.Checked)
                        sEstado = "1";
                    else
                        sEstado = "0";
                    if (rdb_actio1.Checked)
                        sEstado2 = "1";
                    else
                        sEstado2 = "0";


                    DataTable dtModificar = logic.logicaModificarRepuestos(iCodigo, sid_tipo_repuesto, scod_fabricante, sdescripcion, scosto_repuesto1, scosto_repuesto2, scosto_repuesto3, scosto_repuesto4, sprecio_venta1, sprecio_venta2, sprecio_venta3, sprecio_venta4, scantidad, sEstado2,sprecio_factura, sEstado);
                    MessageBox.Show("Repuesto Modificado Exitosamente");
                    dvgRepuestos.Rows.Clear();

                    limpiarForm();
                    Actualizarrepuesto();

                }

            }
            else if (boton_eliminar == true)
            {
                //int iCodigo = Convert.ToInt32(txt_codigo.Text);
                DataTable dtEliminar = logic.logicaEliminarRepuestos(iCodigo);
                MessageBox.Show("Repuesto Eliminado Exitosamente");
                dvgRepuestos.Rows.Clear();
                limpiarForm();
                Actualizarrepuesto();
            }


            tabControl2.SelectedTab = tabPage10;
        }

        void limpiarForm()
        {
            Btn_guardar.Enabled = true;
            Btn_guardar.Enabled = false;
            Btn_modificar.Enabled = true;
            Btn_eliminar.Enabled = true;  
            gpb_estado.Enabled = false;

            txt_codigo.Text = "";
            comboBox2.Text = "";
            txt_precio1.Text = "";
            txt_precio2.Text = "";
            txt_precio3.Text = "";
            txt_precio4.Text = "";
            txt_venta1.Text = "";
            txt_venta2.Text = "";
            txt_venta3.Text = "";
            txt_venta4.Text = "";
            txt_codF.Text = "";
            txt_descrip.Text = "";
            txt_preciofac.Text = "";
            comboBox1.Text = "";
            txt_cantidad.Text = "";
            gpb_fact_sin_exp.Enabled = false;

        }
        void limpiarFormC()
        {
            btn_guardarC.Enabled = true;
            btn_guardarC.Enabled = false;
            btn_modC.Enabled = true;
            btn_eliminarC.Enabled = true;
            txt_nombreC.Text = " ";
            txt_nitC.Text = "";
            txt_codC.Text = "";
            gpb_estadoC.Enabled = false;

        }
        void limpiarFormP()
        {
            btn_guardarP.Enabled = true;
            btn_guardarP.Enabled = false;
            btn_modP.Enabled = true;
            btn_eliminarP.Enabled = true;
            txt_nombreP.Text = " ";
            txt_nitP.Text = "";
            txt_direccionP.Text = "";
            gpb_estadoP.Enabled = false;
            txt_codP.Text = "";

        }
        void limpiarFormM()
        {
            btn_guardarM.Enabled = true;
            btn_guardarM.Enabled = false;
            btn_modificarM.Enabled = true;
            btn_eliminarM.Enabled = true;
            txt_nombreM.Text = " ";
            gpb_estadoM.Enabled = false;
            txt_codM.Text = "";

        }
        void limpiarFormT()
        {
            btn_guardarT.Enabled = true;
            btn_guardarT.Enabled = false;
            btn_modT.Enabled = true;
            btn_eliminarT.Enabled = true;
            txt_nombreT.Text = " ";
            gpb_estadoT.Enabled = false;
            txt_codT.Text = "";

        }
        void limpiarFormTP()
        {
            btn_tipoRe.Enabled = true;
            btn_tipoRe.Enabled = false;
            btn_modTP.Enabled = true;
            btn_modEl.Enabled = true;
            txt_nombre_tipoRe.Text = " ";
            gpb_estadoTP.Enabled = false;
            txt_cod_tipo_re.Text = " ";

        }
        void limpiarFormU()
        {
            btn_guardarU.Enabled = true;
            btn_guardarU.Enabled = false;
            btn_modU.Enabled = true;
            btn_eliminarU.Enabled = true;
            txt_nombreU.Text = " ";
            txt_apellidoU.Text = " ";
            txt_passwordU.Text = " ";
            gpb_estadoU.Enabled = false;
            txt_codU.Text = "";

        }

        private void Btn_modificar_Click(object sender, EventArgs e)
        {
            habilitarBotones();
            bloquearBotones();
            boton_modificar = true;
            boton_ingreso = false;
            
        }

        private void txt_nombre_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            Validar.soloNumeros(e);
        }

        private void txt_descrip_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_descrip_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.soloLetras(e);
        }

        private void textBox8_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.soloNumeros(e);
        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox13_KeyPress(object sender, KeyPressEventArgs e)
        {
  
        }

        private void textBox18_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.soloLetras(e);
        }

        private void textBox23_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.soloLetras(e);
        }

        private void textBox28_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.soloLetras(e);
        }

        private void textBox29_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox29_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.soloLetras(e);
        }

            
        private void Btn_eliminar_Click(object sender, EventArgs e)
        {
            habilitarBotones();
            bloquearBotones();
            boton_eliminar = true;
            boton_modificar = false;
            boton_ingreso = false;
        }

        private void dvgRepuestos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            txt_codigo.Text = dvgRepuestos.CurrentRow.Cells[0].Value.ToString();
            comboBox2.Text = dvgRepuestos.CurrentRow.Cells[1].Value.ToString();
            txt_codF.Text = dvgRepuestos.CurrentRow.Cells[2].Value.ToString();
            txt_descrip.Text = dvgRepuestos.CurrentRow.Cells[3].Value.ToString();
            txt_precio1.Text = dvgRepuestos.CurrentRow.Cells[4].Value.ToString();
            txt_precio2.Text = dvgRepuestos.CurrentRow.Cells[5].Value.ToString();
            txt_precio3.Text = dvgRepuestos.CurrentRow.Cells[6].Value.ToString();
            txt_precio4.Text = dvgRepuestos.CurrentRow.Cells[7].Value.ToString();
            txt_venta1.Text = dvgRepuestos.CurrentRow.Cells[8].Value.ToString();
            txt_venta2.Text = dvgRepuestos.CurrentRow.Cells[9].Value.ToString();
            txt_venta3.Text = dvgRepuestos.CurrentRow.Cells[10].Value.ToString();
            txt_venta4.Text = dvgRepuestos.CurrentRow.Cells[11].Value.ToString();
            txt_cantidad.Text = dvgRepuestos.CurrentRow.Cells[12].Value.ToString();
            // txt_costo.Text = dvgRepuestos.CurrentRow.Cells[14].Value.ToString();

            comboBox1.Text = dvgRepuestos.CurrentRow.Cells[14].Value.ToString();
            if(dvgRepuestos.CurrentRow.Cells[14].Value.ToString()=="1")
                comboBox1.Text = "Precio Venta 1";
            else if (dvgRepuestos.CurrentRow.Cells[14].Value.ToString() == "2")
                comboBox1.Text = "Precio Venta 2";
            else if (dvgRepuestos.CurrentRow.Cells[14].Value.ToString() == "3")
                comboBox1.Text = "Precio Venta 3";
            else if (dvgRepuestos.CurrentRow.Cells[14].Value.ToString() == "4")
                comboBox1.Text = "Precio Venta 4";


            if (dvgRepuestos.CurrentRow.Cells[14].Value.ToString() == "1")
            {
                rdb_actio.Checked = true;
                rdb_actio1.Checked = true;
            }
            else
            {
                rdb_inactivo.Checked = true;
                rdb_inactivo1.Checked = true;
            }


            tabControl2.SelectedTab = MantenimientoR;
        }
       

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void label23_Click(object sender, EventArgs e)
        {

        }

        private void tabPage9_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox23_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_ingresarP_Click(object sender, EventArgs e)
        {
            habilitarBotonesP();
            bloquearBotonesP();
            txt_nombreP.Text = "";
            txt_nitP.Text = "";
            txt_direccionP.Text = "";
            gpb_estadoP.Enabled = false;
            boton_ingreso = true;
            tabControl4.SelectedTab = MantenimientoP;
        }

        private void btn_ingresarM_Click(object sender, EventArgs e)
        {
            habilitarBotonesM();
            bloquearBotonesM();
            txt_nombreM.Text = "";
            gpb_estadoM.Enabled = false;
            boton_ingreso = true;
            tabControl5.SelectedTab = MantenimientoM;
        }

        private void btn_ingresarT_Click(object sender, EventArgs e)
        {
            habilitarBotonesT();
            bloquearBotonesT();
            txt_nombreT.Text = "";
            gpb_estadoT.Enabled = false;
            boton_ingreso = true;
            tabControl6.SelectedTab = MantenimientoT;
        }

        private void btn_modC_Click(object sender, EventArgs e)
        {
            habilitarBotonesC();
            bloquearBotonesC();
            boton_modificar = true;
            boton_ingreso = false;
        }

        private void btn_modP_Click(object sender, EventArgs e)
        {
            habilitarBotonesP();
            bloquearBotonesP();
            boton_modificar = true;
            boton_ingreso = false;
        }

        private void btn_modificarM_Click(object sender, EventArgs e)
        {
            habilitarBotonesM();
            bloquearBotonesM();
            boton_modificar = true;
            boton_ingreso = false;
        }

        private void btn_modT_Click(object sender, EventArgs e)
        {
            habilitarBotonesT();
            bloquearBotonesT();
            boton_modificar = true;
            boton_ingreso = false;
        }

        private void btn_eliminarC_Click(object sender, EventArgs e)
        {
            habilitarBotonesC();
            bloquearBotonesC();
            boton_eliminar = true;
            boton_modificar = false;
            boton_ingreso = false;
        }

        private void btn_eliminarP_Click(object sender, EventArgs e)
        {
            habilitarBotonesP();
            bloquearBotonesP();
            boton_eliminar = true;
            boton_modificar = false;
            boton_ingreso = false;
        }

        private void btn_eliminarM_Click(object sender, EventArgs e)
        {
            habilitarBotonesM();
            bloquearBotonesM();
            boton_eliminar = true;
            boton_modificar = false;
            boton_ingreso = false;
        }

        private void btn_eliminarT_Click(object sender, EventArgs e)
        {
            habilitarBotonesT();
            bloquearBotonesT();
            boton_eliminar = true;
            boton_modificar = false;
            boton_ingreso = false;
        }

        private void btn_cancelarC_Click(object sender, EventArgs e)
        {
            
            limpiarFormC();
            bloquearTextBoxC();
            btn_ingresarC.Enabled = true;
            rdb_actioC.Checked = true;
            boton_eliminar = false;
            boton_modificar = false;
            boton_ingreso = false;
        }

        private void btn_cancelarP_Click(object sender, EventArgs e)
        {
            limpiarFormP();
            bloquearTextBoxP();
            btn_ingresarP.Enabled = true;
            rdb_actioP.Checked = true;
            boton_eliminar = false;
            boton_modificar = false;
            boton_ingreso = false;
        }

        private void btn_cancelarM_Click(object sender, EventArgs e)
        {
            limpiarFormM();
            bloquearTextBoxM();
            btn_ingresarM.Enabled = true;
            rdb_actioM.Checked = true;
            boton_eliminar = false;
            boton_modificar = false;
            boton_ingreso = false;
        }

        private void btn_cancelarT_Click(object sender, EventArgs e)
        {
            limpiarFormT();
            bloquearTextBoxT();
            btn_ingresarT.Enabled = true;
            rdb_actioT.Checked = true;
            boton_eliminar = false;
            boton_modificar = false;
            boton_ingreso = false;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            dvgProveedores.Rows.Clear();
            string sNombre = textBox15.Text;

            try
            {
                DataTable dtBuscar = logic.logicaBuscarproveedores(sNombre);

                foreach (DataRow row in dtBuscar.Rows)
                {
                    dvgProveedores.Rows.Add(row[0].ToString(), row[1].ToString(), row[2].ToString(), row[3].ToString(), row[5].ToString());

                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error en capa diseno recuperar proveedores: " + ex.Message);
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            dvgMarca.Rows.Clear();
            string sNombre = textBox20.Text;

            try
            {
                DataTable dtBuscar = logic.logicaBuscarmarca(sNombre);

                foreach (DataRow row in dtBuscar.Rows)
                {
                    dvgMarca.Rows.Add(row[0].ToString(), row[1].ToString(), row[3].ToString());

                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error en capa diseno recuperar marca: " + ex.Message);
            }
        }

        private void button24_Click(object sender, EventArgs e)
        {
            dvgPago.Rows.Clear();
            string sNombre = textBox25.Text;

            try
            {
                DataTable dtBuscar = logic.logicaBuscarpago(sNombre);

                foreach (DataRow row in dtBuscar.Rows)
                {
                    dvgPago.Rows.Add(row[0].ToString(),row[1].ToString(), row[3].ToString());

                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error en capa diseno recuperar Tipo de Pago: " + ex.Message);
            }
        }


        

        private void tabPage4_Load(object sender, EventArgs e)
        {
            logic.logic_Obtenerproveedores();
        }

        private void MantenimientoP_Click(object sender, EventArgs e)
        {

        }

        private void MantenimientoM_Load(object sender, EventArgs e)
        {
            logic.logic_Obtenermarca();
        }

        private void tabPage8_Load(object sender, EventArgs e)
        {
            logic.logic_Obtenerpago();
        }

        private void btn_guardarC_Click(object sender, EventArgs e)
        {
            string sNombre = txt_nombreC.Text;
            string snit = txt_nitC.Text;
           


            if (boton_ingreso == true)
            {

                if (txt_nombreC.Text == "" || txt_nitC.Text == "")
                {
                    MessageBox.Show("Faltan campos por llenar");
                }
                else
                {

                    DataTable dtInsertar = logic.logicaInsertarclientes(sNombre, snit);
                    MessageBox.Show("Cliente Ingresado Exitosamente");
                    dvgClientes.Rows.Clear();
                    limpiarFormC();
                    Actualizarcliente();
                }

            }
            else if (boton_modificar == true)
            {
                if (txt_nombreC.Text == "" || txt_nitC.Text == "" || txt_codC.Text == "")
                {
                    MessageBox.Show("Faltan campos por llenar");
                }
                else
                {
                    int iCodigo = Convert.ToInt32(txt_codC.Text);
                    string sEstado = "";

                    if (rdb_actioC.Checked)
                        sEstado = "1";
                    else
                        sEstado = "0";


                    DataTable dtModificar = logic.logicaModificarclientes(iCodigo, sNombre, snit, sEstado);
                    MessageBox.Show("Cliente Modificado Exitosamente");
                    dvgClientes.Rows.Clear();

                    limpiarFormC();
                    Actualizarcliente();

                }

            }
            else if (boton_eliminar == true)
            {
                int iCodigo = Convert.ToInt32(txt_codC.Text);
                DataTable dtEliminar = logic.logicaEliminarclientes(iCodigo);
                MessageBox.Show("Cliente Eliminado Exitosamente");
                dvgClientes.Rows.Clear();
                limpiarFormP();
                Actualizarcliente();
            }


            tabControl3.SelectedTab = MantenimientoC;
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton9_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btn_guardarP_Click(object sender, EventArgs e)
        {
            string sNombre = txt_nombreP.Text;
            string snit = txt_nitP.Text;
            string sdireccion = txt_direccionP.Text;


            if (boton_ingreso == true)
            {

                if (txt_nombreP.Text == "" || txt_nitP.Text == "" || txt_direccionP.Text == "")
                {
                    MessageBox.Show("Faltan campos por llenar");
                }
                else
                {

                    DataTable dtInsertar = logic.logicaInsertarproveedores(sNombre, snit,sdireccion);
                    MessageBox.Show("proveedor Ingresado Exitosamente");
                    dvgProveedores.Rows.Clear();
                    limpiarFormP();
                    ActualizarProveedores();
                }

            }
            else if (boton_modificar == true)
            {
                if (txt_nombreP.Text == "" || txt_nitP.Text == "" || txt_direccionP.Text == "" || txt_codP.Text == "")
                {
                    MessageBox.Show("Faltan campos por llenar");
                }
                else
                {
                    int iCodigo = Convert.ToInt32(txt_codP.Text);
                    string sEstado = "";

                    if (rdb_actioP.Checked)
                        sEstado = "1";
                    else
                        sEstado = "0";


                    DataTable dtModificar = logic.logicaModificarproveedores(iCodigo, sNombre, snit,sdireccion, sEstado);
                    MessageBox.Show("Proveedor Modificado Exitosamente");
                    dvgProveedores.Rows.Clear();

                    limpiarFormP();
                    ActualizarProveedores();

                }

            }
            else if (boton_eliminar == true)
            {
                int iCodigo = Convert.ToInt32(txt_codP.Text);
                DataTable dtEliminar = logic.logicaEliminarproveedores(iCodigo);
                MessageBox.Show("Proveedor Eliminado Exitosamente");
                dvgProveedores.Rows.Clear();
                limpiarFormP();
                ActualizarProveedores();
            }


            tabControl4.SelectedTab = tabPage4;
        }

        private void btn_guardarT_Click(object sender, EventArgs e)
        {
            string sNombre = txt_nombreT.Text;
     
      


            if (boton_ingreso == true)
            {

                if (txt_nombreT.Text == "")
                {
                    MessageBox.Show("Faltan campos por llenar");
                }
                else
                {

                    DataTable dtInsertar = logic.logicaInsertarpago(sNombre);
                    MessageBox.Show("Tipo de pago Ingresado Exitosamente");
                    dvgPago.Rows.Clear();
                    limpiarFormT();
                    ActualizarPago();
                }

            }
            else if (boton_modificar == true)
            {
                if (txt_nombreT.Text == "" || txt_codT.Text == "")
                {
                    MessageBox.Show("Faltan campos por llenar");
                }
                else
                {
                    int iCodigo = Convert.ToInt32(txt_codT.Text);
                    string sEstado = "";

                    if (rdb_actioT.Checked)
                        sEstado = "1";
                    else
                        sEstado = "0";


                    DataTable dtModificar = logic.logicaModificarpago(iCodigo, sNombre, sEstado);
                    MessageBox.Show("Tipo de pago Modificado Exitosamente");
                    dvgPago.Rows.Clear();

                    limpiarFormT();
                    ActualizarPago();

                }

            }
            else if (boton_eliminar == true)
            {
                int iCodigo = Convert.ToInt32(txt_codT.Text);
                DataTable dtEliminar = logic.logicaEliminarpago(iCodigo);
                MessageBox.Show("Tipo de pago Eliminado Exitosamente");
                dvgPago.Rows.Clear();
                limpiarFormT();
                ActualizarPago();
            }


            tabControl6.SelectedTab = tabPage8;
        }

        private void btn_guardarM_Click(object sender, EventArgs e)
        {
            string sNombre = txt_nombreM.Text;




            if (boton_ingreso == true)
            {

                if (txt_nombreM.Text == "")
                {
                    MessageBox.Show("Faltan campos por llenar");
                }
                else
                {

                    DataTable dtInsertar = logic.logicaInsertarmarca(sNombre);
                    MessageBox.Show("Marca Ingresada Exitosamente");
                    dvgMarca.Rows.Clear();
                    limpiarFormM();
                    ActualizarMarca();
                }

            }
            else if (boton_modificar == true)
            {
                if (txt_nombreM.Text == "" || txt_codM.Text == "")
                {
                    MessageBox.Show("Faltan campos por llenar");
                }
                else
                {
                    int iCodigo = Convert.ToInt32(txt_codM.Text);
                    string sEstado = "";

                    if (rdb_actioM.Checked)
                        sEstado = "1";
                    else
                        sEstado = "0";


                    DataTable dtModificar = logic.logicaModificarmarca(iCodigo, sNombre, sEstado);
                    MessageBox.Show("Marca Modificada Exitosamente");
                    dvgMarca.Rows.Clear();

                    limpiarFormM();
                    ActualizarMarca();

                }

            }
            else if (boton_eliminar == true)
            {
                int iCodigo = Convert.ToInt32(txt_codM.Text);
                DataTable dtEliminar = logic.logicaEliminarmarca(iCodigo);
                MessageBox.Show("Marca Eliminada Exitosamente");
                dvgMarca.Rows.Clear();
                limpiarFormM();
                ActualizarMarca();
            }


            tabControl5.SelectedTab = tabPage6;
        }

        private void dvgProveedores_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_codP.Text = dvgProveedores.CurrentRow.Cells[0].Value.ToString();
            txt_nombreP.Text = dvgProveedores.CurrentRow.Cells[1].Value.ToString();
            txt_nitP.Text = dvgProveedores.CurrentRow.Cells[2].Value.ToString();
            txt_direccionP.Text = dvgProveedores.CurrentRow.Cells[3].Value.ToString();

            if (dvgProveedores.CurrentRow.Cells[3].Value.ToString() == "1")
            {
                rdb_actioP.Checked = true;
            }
            else
            {
                rdb_inactivoP.Checked = true;
            }


            tabControl4.SelectedTab = MantenimientoP;
        }

        private void dvgMarca_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_codM.Text = dvgMarca.CurrentRow.Cells[0].Value.ToString();
            txt_nombreM.Text = dvgMarca.CurrentRow.Cells[1].Value.ToString();
           

            if (dvgMarca.CurrentRow.Cells[1].Value.ToString() == "1")
            {
                rdb_actioM.Checked = true;
            }
            else
            {
                rdb_inactivoM.Checked = true;
            }


            tabControl5.SelectedTab = MantenimientoM;
        }

        private void dvgPago_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_codT.Text = dvgPago.CurrentRow.Cells[0].Value.ToString();
            txt_nombreT.Text = dvgPago.CurrentRow.Cells[1].Value.ToString();


            if (dvgPago.CurrentRow.Cells[1].Value.ToString() == "1")
            {
                rdb_actioT.Checked = true;
            }
            else
            {
                rdb_inactivoT.Checked = true;
            }


            tabControl6.SelectedTab = MantenimientoT;
        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void groupBox12_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter_1(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void Clientes_Click(object sender, EventArgs e)
        {

        }

        private void tabControl3_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (tabControl3.SelectedTab == MantenimientoC)
            {
                Actualizarcliente();
            }
        }

        private void tabControl4_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl4.SelectedTab == tabPage4)
            {
                ActualizarProveedores();
            }
        }

       

        private void tabControl5_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl5.SelectedTab == tabPage6)
            {
                ActualizarMarca();
            }

        }

        private void tabControl6_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl6.SelectedTab == tabPage8)
            {
                ActualizarPago();
            }
        }

        private void tabControl2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl2.SelectedTab == tabPage10)
            {
                Actualizarrepuesto();
            }
        }

        private void textBox20_Enter(object sender, EventArgs e)
        {
           
        }

        private void textBox20_KeyPress(object sender, KeyPressEventArgs e)
        {
            dvgMarca.Rows.Clear();
            string sNombre = textBox20.Text;

            try
            {
                DataTable dtBuscar = logic.logicaBuscarmarca(sNombre);

                foreach (DataRow row in dtBuscar.Rows)
                {
                    dvgMarca.Rows.Add(row[0].ToString(), row[1].ToString(),row[3].ToString());

                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error en capa diseno recuperar marca: " + ex.Message);
            }
        }

        private void textBox25_KeyPress(object sender, KeyPressEventArgs e)
        {
            dvgPago.Rows.Clear();
            string sNombre = textBox25.Text;

            try
            {
                DataTable dtBuscar = logic.logicaBuscarpago(sNombre);

                foreach (DataRow row in dtBuscar.Rows)
                {
                    dvgPago.Rows.Add(row[0].ToString(), row[1].ToString(), row[3].ToString());

                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error en capa diseno recuperar Tipo de Pago: " + ex.Message);
            }
        }

        private void textBox15_KeyPress(object sender, KeyPressEventArgs e)
        {
            dvgProveedores.Rows.Clear();
            string sNombre = textBox15.Text;

            try
            {
                DataTable dtBuscar = logic.logicaBuscarproveedores(sNombre);

                foreach (DataRow row in dtBuscar.Rows)
                {
                    dvgProveedores.Rows.Add(row[0].ToString(), row[1].ToString(), row[2].ToString(), row[3].ToString(), row[5].ToString());

                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error en capa diseno recuperar proveedores: " + ex.Message);
            }
        }

        private void txtBuscar1_KeyPress(object sender, KeyPressEventArgs e)
        {
            dvgRepuestos.Rows.Clear();
            string sNombre1 = txtBuscar1.Text;

            try
            {
                DataTable dtBuscar = logic.logicaBuscarRepuestos(sNombre1);

                foreach (DataRow row in dtBuscar.Rows)
                {
                    dvgRepuestos.Rows.Add(row[0].ToString(), row[1].ToString(), row[2].ToString(), row[3].ToString(), row[4].ToString(), row[5].ToString(), row[6].ToString(), row[7].ToString(), row[8].ToString(), row[9].ToString(), row[10].ToString(), row[11].ToString(), row[12].ToString(), row[13].ToString());

                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error en capa diseno recuperar repuestos: " + ex.Message);
            }
        }

        private void textBox10_KeyPress(object sender, KeyPressEventArgs e)
        {
            dvgClientes.Rows.Clear();
            string sNombre = textBox10.Text;
            string snit= textBox10.Text;

            try
            {
                DataTable dtBuscar2 = logic.logicaBuscarnit(snit);
                DataTable dtBuscar = logic.logicaBuscarclientes(sNombre);

                foreach (DataRow row in dtBuscar.Rows)
                {
                    dvgClientes.Rows.Add(row[0].ToString(), row[1].ToString(), row[2].ToString(), row[4].ToString());

                }
                foreach (DataRow row in dtBuscar2.Rows)
                {
                    dvgClientes.Rows.Add(row[0].ToString(), row[1].ToString(), row[2].ToString(), row[4].ToString());

                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error en capa diseno recuperar clientes: " + ex.Message);
            }
        }

        private void dvgClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dvgClientes_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            txt_codC.Text = dvgClientes.CurrentRow.Cells[0].Value.ToString();
            txt_nombreC.Text = dvgClientes.CurrentRow.Cells[1].Value.ToString();
            txt_nitC.Text = dvgClientes.CurrentRow.Cells[2].Value.ToString();


            if (dvgClientes.CurrentRow.Cells[2].Value.ToString() == "1")
            {
                rdb_actioC.Checked = true;
            }
            else
            {
                rdb_inactivoC.Checked = true;
            }


            tabControl3.SelectedTab = tabPage1;
        }

        private void txt_codC_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_nombreC_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_nombreC_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.soloLetras(e);
        }

        private void txt_nitC_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.soloNumeros(e);
        }

        private void txt_nitP_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.soloNumeros(e);
        }

        private void txt_codC_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.soloNumeros(e);
        }

        private void txt_codigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.soloNumeros(e);
        }

        private void txt_codP_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.soloNumeros(e);
        }

        private void txt_codM_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.soloNumeros(e);
        }

        private void txt_codT_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.soloNumeros(e);
        }

        private void textBox27_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.soloNumeros(e);
        }

        private void btn_ingresarU_Click(object sender, EventArgs e)
        {
            habilitarBotonesU();
            bloquearBotonesU();
            txt_nombreU.Text = "";
            txt_apellidoU.Text = "";
            txt_passwordU.Text = "";
            gpb_estadoU.Enabled = false;
            boton_ingreso = true;
            tabControl7.SelectedTab = tabPage9;
        }

        private void btn_modU_Click(object sender, EventArgs e)
        {

            habilitarBotonesU();
            bloquearBotonesU();
            boton_modificar = true;
            boton_ingreso = false;
        }

        private void btn_eliminarU_Click(object sender, EventArgs e)
        {
            habilitarBotonesU();
            bloquearBotonesU();
            boton_eliminar = true;
            boton_modificar = false;
            boton_ingreso = false;
        }

        private void btn_guardarU_Click(object sender, EventArgs e)
        {
            string sNombre = txt_nombreU.Text;
            string sapellido = txt_apellidoU.Text;
            string spassword = txt_passwordU.Text;


            if (boton_ingreso == true)
            {

                if (txt_nombreU.Text == "" || txt_apellidoU.Text == "" || txt_passwordU.Text == "")
                {
                    MessageBox.Show("Faltan campos por llenar");
                }
                else
                {

                    DataTable dtInsertar = logic.logicaInsertarusuarios(sNombre, sapellido, spassword);
                    MessageBox.Show("Usuario Ingresado Exitosamente");
                    dvg_usuarios.Rows.Clear();
                    limpiarFormU();
                    Actualizarusuarios();
                }

            }
            else if (boton_modificar == true)
            {
                if (txt_nombreU.Text == "" || txt_apellidoU.Text == "" || txt_passwordU.Text == "" || txt_codU.Text == "")
                {
                    MessageBox.Show("Faltan campos por llenar");
                }
                else
                {
                    int iCodigo = Convert.ToInt32(txt_codU.Text);
                    string sEstado = "";

                    if (rdb_actioU.Checked)
                        sEstado = "1";
                    else
                        sEstado = "0";


                    DataTable dtModificar = logic.logicaModificarusuarios(iCodigo, sNombre, sapellido, spassword, sEstado);
                    MessageBox.Show("Usuario Modificado Exitosamente");
                    dvg_usuarios.Rows.Clear();

                    limpiarFormU();
                    Actualizarusuarios();

                }

            }
            else if (boton_eliminar == true)
            {
                int iCodigo = Convert.ToInt32(txt_codU.Text);
                DataTable dtEliminar = logic.logicaEliminarusuarios(iCodigo);
                MessageBox.Show("usuario Eliminado Exitosamente");
                dvg_usuarios.Rows.Clear();
                limpiarFormP();
                Actualizarusuarios();
            }


            tabControl7.SelectedTab = tabPage11;
        }



        private void dvg_usuarios_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_codU.Text = dvg_usuarios.CurrentRow.Cells[0].Value.ToString();
            txt_nombreU.Text = dvg_usuarios.CurrentRow.Cells[1].Value.ToString();
            txt_apellidoU.Text = dvg_usuarios.CurrentRow.Cells[2].Value.ToString();
            txt_passwordU.Text = dvg_usuarios.CurrentRow.Cells[3].Value.ToString();


            if (dvg_usuarios.CurrentRow.Cells[3].Value.ToString() == "1")
            {
                rdb_actioU.Checked = true;
            }
            else
            {
                rdb_inactivoU.Checked = true;
            }


            tabControl7.SelectedTab = tabPage9;
        }

        private void button30_Click(object sender, EventArgs e)
        {
            dvg_usuarios.Rows.Clear();
            string sNombre = textBox30.Text;

            try
            {
                DataTable dtBuscar = logic.logicaBuscarusuarios(sNombre);

                foreach (DataRow row in dtBuscar.Rows)
                {
                    dvg_usuarios.Rows.Add(row[0].ToString(), row[1].ToString(), row[2].ToString(), row[5].ToString());

                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error en capa diseno recuperar Usuarios: " + ex.Message);
            }
        }

        private void textBox30_KeyPress(object sender, KeyPressEventArgs e)
        {
            dvg_usuarios.Rows.Clear();
            string sNombre = textBox30.Text;

            try
            {
                DataTable dtBuscar = logic.logicaBuscarusuarios(sNombre);

                foreach (DataRow row in dtBuscar.Rows)
                {
                    dvg_usuarios.Rows.Add(row[0].ToString(), row[1].ToString(), row[2].ToString(), row[5].ToString());

                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error en capa diseno recuperar Usuarios: " + ex.Message);
            }
        }

        private void tabControl7_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl7.SelectedTab == tabPage11)
            {
                Actualizarusuarios();
            }
        }

        private void button28_Click(object sender, EventArgs e)
        {
            limpiarFormU();
            bloquearTextBoxU();
            btn_ingresarU.Enabled = true;
            rdb_actioU.Checked = true;
            boton_eliminar = false;
            boton_modificar = false;
            boton_ingreso = false;
        }

      

        private void txt_precio1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_precio1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                e.Handled = true;
                return;
            }
        }

        private void txt_costo_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string combo = comboBox1.Text;

            if (combo == "Precio Venta 1")
            txt_preciofac.Text = "1";
               
            else if (combo == "Precio Venta 2")
                txt_preciofac.Text = "2";
            else if (combo == "Precio Venta 3")
                txt_preciofac.Text = "3";
            else
                txt_preciofac.Text = "4";


        }
        private void llenarTipoRepuesto()
        {
            comboBox2.Items.Clear();
            lIdTipoPago.Clear();
            try
            {
                DataTable dtobtenertipoRep = logic.logic_Obtenertiporep();

                foreach (DataRow row in dtobtenertipoRep.Rows)
                {
                    comboBox2.Items.Add(row[0].ToString() + " - " + row[1].ToString());
                    lIdTipoPago.Add(Convert.ToInt32(row[0].ToString()));
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error en capa diseno recuperando los tipos de pago: " + ex.Message);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
           dvg_TipoRep.Rows.Clear();
            string sNombre = txt_buscarRe.Text;

            try
            {
                DataTable dtBuscar = logic.logicaBuscarTipoRe(sNombre);

                foreach (DataRow row in dtBuscar.Rows)
                {
                    dvg_TipoRep.Rows.Add(row[0].ToString(), row[1].ToString(), row[3].ToString());

                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error en capa diseno recuperar Tipo de Repuestos " + ex.Message);
            }
        }


        void ActualizarTipoRepuesto()
        {

            dvg_TipoRep.Rows.Clear();
            DataTable dtobtenertipoRep = logic.logic_Obtenertiporep();
            foreach (DataRow row in dtobtenertipoRep.Rows)
            {
                dvg_TipoRep.Rows.Add(row[0].ToString(), row[1].ToString(), row[3].ToString());
            }
        }

        private void tabControl8_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl8.SelectedTab == tabPage5)
            {
                ActualizarTipoRepuesto();
            }
        }

        private void dvg_TipoRep_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dvg_TipoRep_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_cod_tipo_re.Text = dvg_TipoRep.CurrentRow.Cells[0].Value.ToString();
            txt_nombre_tipoRe.Text = dvg_TipoRep.CurrentRow.Cells[1].Value.ToString();


            if (dvg_TipoRep.CurrentRow.Cells[1].Value.ToString() == "1")
            {
                rdb_actioTP.Checked = true;
            }
            else
            {
                rdb_inactivoTP.Checked = true;
            }


            tabControl8.SelectedTab = tabPage3;
        }

        private void txt_buscarRe_KeyPress(object sender, KeyPressEventArgs e)
        {
            dvg_TipoRep.Rows.Clear();
            string sNombre = txt_buscarRe.Text;

            try
            {
                DataTable dtBuscar = logic.logicaBuscarTipoRe(sNombre);

                foreach (DataRow row in dtBuscar.Rows)
                {
                    dvg_TipoRep.Rows.Add(row[0].ToString(), row[1].ToString(), row[3].ToString());

                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error en capa diseno recuperar Tipo de Repuestos " + ex.Message);
            }
        }

        private void btn_tipoRe_Click(object sender, EventArgs e)
        {
            string sNombre = txt_nombre_tipoRe.Text;




            if (boton_ingreso == true)
            {

                if (txt_nombre_tipoRe.Text == "")
                {
                    MessageBox.Show("Faltan campos por llenar");
                }
                else
                {

                    DataTable dtInsertar = logic.logicaInsertarTipoRe(sNombre);
                    MessageBox.Show("Tipo de repuesto Ingresado Exitosamente");
                    dvg_TipoRep.Rows.Clear();
                    limpiarFormTP();
                    ActualizarTipoRepuesto();
                }

            }
            else if (boton_modificar == true)
            {
                if (txt_nombre_tipoRe.Text == "" || txt_cod_tipo_re.Text == "")
                {
                    MessageBox.Show("Faltan campos por llenar");
                }
                else
                {
                    int iCodigo = Convert.ToInt32(txt_cod_tipo_re.Text);
                    string sEstado = "";

                    if (rdb_actioTP.Checked)
                        sEstado = "1";
                    else
                        sEstado = "0";


                    DataTable dtModificar = logic.logicaModificarTipoRe(iCodigo, sNombre, sEstado);
                    MessageBox.Show("Tipo de Repuesto Modificado Exitosamente");
                    dvg_TipoRep.Rows.Clear();

                    limpiarFormTP();
                    ActualizarTipoRepuesto();

                }

            }
            else if (boton_eliminar == true)
            {
                int iCodigo = Convert.ToInt32(txt_cod_tipo_re.Text);
                DataTable dtEliminar = logic.logicaEliminarTipoRe(iCodigo);
                MessageBox.Show("Tipo de Repuesto Eliminado Exitosamente");
                dvg_TipoRep.Rows.Clear();
                limpiarFormTP();
                ActualizarTipoRepuesto();
            }


            tabControl8.SelectedTab = tabPage5;
        }

        private void btn_nuevoTP_Click(object sender, EventArgs e)
        {
            habilitarBotonesTP();
            bloquearBotonesTP();
            txt_nombre_tipoRe.Text = "";
            gpb_estadoTP.Enabled = false;
            boton_ingreso = true;
            tabControl8.SelectedTab = tabPage3;
        }

        private void btn_modTP_Click(object sender, EventArgs e)
        {
            habilitarBotonesTP();
            bloquearBotonesTP();
            boton_modificar = true;
            boton_ingreso = false;
        }

        private void btn_modEl_Click(object sender, EventArgs e)
        {
            habilitarBotonesTP();
            bloquearBotonesTP();
            boton_eliminar = true;
            boton_modificar = false;
            boton_ingreso = false;
        }

        private void btn_cancelTP_Click(object sender, EventArgs e)
        {
            limpiarFormTP();
            bloquearTextBoxTP();
            btn_nuevoTP.Enabled = true;
            rdb_actioTP.Checked = true;
            boton_eliminar = false;
            boton_modificar = false;
            boton_ingreso = false;
        }

        private void txt_codigo_TextChanged(object sender, EventArgs e)
        {
         
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            ExportarDatos(dvgClientes);
        }
        private void ExportarDatos(DataGridView dvgClientes)
        {
            try
            {
                Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application(); // Instancia a la libreria de Microsoft Office
                excel.Application.Workbooks.Add(true); //Con esto añadimos una hoja en el Excel para exportar los archivos
                int IndiceColumna = 0;
                foreach (DataGridViewColumn columna in dvgClientes.Columns) //Aquí empezamos a leer las columnas del listado a exportar
                {
                    IndiceColumna++;
                    excel.Cells[1, IndiceColumna] = columna.Name;
                }
                int IndiceFila = 0;
                foreach (DataGridViewRow fila in dvgClientes.Rows) //Aquí leemos las filas de las columnas leídas
                {
                    IndiceFila++;
                    IndiceColumna = 0;
                    foreach (DataGridViewColumn columna in dvgClientes.Columns)
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

        private void ExportarDatosR(DataGridView dvgRepuestos)
        {
            try
            {
                Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application(); // Instancia a la libreria de Microsoft Office
                excel.Application.Workbooks.Add(true); //Con esto añadimos una hoja en el Excel para exportar los archivos
                int IndiceColumna = 0;
                foreach (DataGridViewColumn columna in dvgRepuestos.Columns) //Aquí empezamos a leer las columnas del listado a exportar
                {
                    IndiceColumna++;
                    excel.Cells[1, IndiceColumna] = columna.Name;
                }
                int IndiceFila = 0;
                foreach (DataGridViewRow fila in dvgRepuestos.Rows) //Aquí leemos las filas de las columnas leídas
                {
                    IndiceFila++;
                    IndiceColumna = 0;
                    foreach (DataGridViewColumn columna in dvgRepuestos.Columns)
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
            ExportarDatosR(dvgRepuestos);
        }

        private void ExportarDatosP(DataGridView dvgProveedores)
        {
            try
            {
                Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application(); // Instancia a la libreria de Microsoft Office
                excel.Application.Workbooks.Add(true); //Con esto añadimos una hoja en el Excel para exportar los archivos
                int IndiceColumna = 0;
                foreach (DataGridViewColumn columna in dvgProveedores.Columns) //Aquí empezamos a leer las columnas del listado a exportar
                {
                    IndiceColumna++;
                    excel.Cells[1, IndiceColumna] = columna.Name;
                }
                int IndiceFila = 0;
                foreach (DataGridViewRow fila in dvgProveedores.Rows) //Aquí leemos las filas de las columnas leídas
                {
                    IndiceFila++;
                    IndiceColumna = 0;
                    foreach (DataGridViewColumn columna in dvgProveedores.Columns)
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
            ExportarDatosP(dvgProveedores);
        }
        private void ExportarDatosM(DataGridView dvgMarca)
        {
            try
            {
                Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application(); // Instancia a la libreria de Microsoft Office
                excel.Application.Workbooks.Add(true); //Con esto añadimos una hoja en el Excel para exportar los archivos
                int IndiceColumna = 0;
                foreach (DataGridViewColumn columna in dvgMarca.Columns) //Aquí empezamos a leer las columnas del listado a exportar
                {
                    IndiceColumna++;
                    excel.Cells[1, IndiceColumna] = columna.Name;
                }
                int IndiceFila = 0;
                foreach (DataGridViewRow fila in dvgMarca.Rows) //Aquí leemos las filas de las columnas leídas
                {
                    IndiceFila++;
                    IndiceColumna = 0;
                    foreach (DataGridViewColumn columna in dvgMarca.Columns)
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
        private void button4_Click(object sender, EventArgs e)
        {
            ExportarDatosM(dvgMarca);
        }
        private void ExportarDatosPago(DataGridView dvgPago)
        {
            try
            {
                Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application(); // Instancia a la libreria de Microsoft Office
                excel.Application.Workbooks.Add(true); //Con esto añadimos una hoja en el Excel para exportar los archivos
                int IndiceColumna = 0;
                foreach (DataGridViewColumn columna in dvgPago.Columns) //Aquí empezamos a leer las columnas del listado a exportar
                {
                    IndiceColumna++;
                    excel.Cells[1, IndiceColumna] = columna.Name;
                }
                int IndiceFila = 0;
                foreach (DataGridViewRow fila in dvgPago.Rows) //Aquí leemos las filas de las columnas leídas
                {
                    IndiceFila++;
                    IndiceColumna = 0;
                    foreach (DataGridViewColumn columna in dvgPago.Columns)
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
        private void button5_Click_1(object sender, EventArgs e)
        {
            ExportarDatosPago(dvgPago);
        }
        private void ExportarDatosTipo(DataGridView dvg_TipoRep)
        {
            try
            {
                Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application(); // Instancia a la libreria de Microsoft Office
                excel.Application.Workbooks.Add(true); //Con esto añadimos una hoja en el Excel para exportar los archivos
                int IndiceColumna = 0;
                foreach (DataGridViewColumn columna in dvg_TipoRep.Columns) //Aquí empezamos a leer las columnas del listado a exportar
                {
                    IndiceColumna++;
                    excel.Cells[1, IndiceColumna] = columna.Name;
                }
                int IndiceFila = 0;
                foreach (DataGridViewRow fila in dvg_TipoRep.Rows) //Aquí leemos las filas de las columnas leídas
                {
                    IndiceFila++;
                    IndiceColumna = 0;
                    foreach (DataGridViewColumn columna in dvg_TipoRep.Columns)
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
        private void button8_Click(object sender, EventArgs e)
        {
            ExportarDatosTipo(dvg_TipoRep);
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox15_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_precio2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_venta1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                e.Handled = true;
                return;
            }
        }

        private void txt_precio2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                e.Handled = true;
                return;
            }
        }

        private void txt_venta2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                e.Handled = true;
                return;
            }
        }

        private void txt_precio3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                e.Handled = true;
                return;
            }
        }

        private void txt_venta3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                e.Handled = true;
                return;
            }
        }

        private void txt_precio4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                e.Handled = true;
                return;
            }
        }

        private void txt_venta4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                e.Handled = true;
                return;
            }
        }

        private void txt_cantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                e.Handled = true;
                return;
            }
        }

        private void textBox20_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox25_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_buscarRe_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox30_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
