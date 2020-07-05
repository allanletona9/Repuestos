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
using System.Data.SqlClient;

namespace repuestos.Formularios
{
    public partial class Mantenimientos : Form
    {
        Logicpublic logic = new Logicpublic();
        bool boton_ingreso = false;
        bool boton_modificar = false;
        bool boton_eliminar = false;
        public Mantenimientos()
        {
            InitializeComponent();
            LoadTheme();
            rdb_actio.Checked = true;
            rdb_actioC.Checked = true;
            rdb_actioP.Checked = true;
            rdb_actioM.Checked = true;
            rdb_actioT.Checked = true;
            Btn_guardar.Enabled = false;
            btn_guardarC.Enabled = false;
            btn_guardarP.Enabled = false;
            btn_guardarM.Enabled = false;
            btn_guardarT.Enabled = false;
            bloquearTextBox();
            bloquearTextBoxC();
            bloquearTextBoxP();
            bloquearTextBoxM();
            bloquearTextBoxT();
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

        private void tabPage9_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Load(object sender, EventArgs e)
        {
            //logic.logic_Obtenerclientes();

        }

        private void tabPage10_Load(object sender, EventArgs e)
        {
            logic.logic_ObtenerRepuestos();
        }
     
        private void Mantenimientos_Load(object sender, EventArgs e)
        {
           
           

        }
        void Actualizarcliente()
        {

            dvgClientes.Rows.Clear();
            DataTable dtobtenerclientes = logic.logic_Obtenerclientes();
            foreach (DataRow row in dtobtenerclientes.Rows)
            {
                dvgClientes.Rows.Add(row[0].ToString(), row[1].ToString(), row[2].ToString(), row[3].ToString());
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
                dvgProveedores.Rows.Add(row[0].ToString(), row[1].ToString(), row[2].ToString(), row[3].ToString(), row[4].ToString());
            }
        }
        void ActualizarMarca()
        {

            dvgMarca.Rows.Clear();
            DataTable dtobtenermarca = logic.logic_Obtenermarca();
            foreach (DataRow row in dtobtenermarca.Rows)
            {
                dvgMarca.Rows.Add(row[0].ToString(), row[1].ToString(), row[2].ToString());
            }
        }
        void ActualizarPago()
        {

            dvgPago.Rows.Clear();
            DataTable dtobtenerpago = logic.logic_Obtenerpago();
            foreach (DataRow row in dtobtenerpago.Rows)
            {
                dvgPago.Rows.Add(row[0].ToString(), row[1].ToString(), row[2].ToString());
            }
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            dvgRepuestos.Rows.Clear();
            string sNombre = txtBuscar.Text;

            try
            {
                DataTable dtBuscar = logic.logicaBuscarRepuestos(sNombre);

                foreach (DataRow row in dtBuscar.Rows)
                {
                 dvgRepuestos.Rows.Add(row[0].ToString(), row[1].ToString(), row[2].ToString(), row[3].ToString(), row[4].ToString());
                  
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
            tabControl3.SelectedTab = MantenimientoC;
        }
        void habilitarBotones()
        {
            txt_codigo.Enabled = false;
            txt_codR.Enabled = true;
            txt_precio1.Enabled = true;
            txt_precio2.Enabled = true;
            txt_precio3.Enabled = true;
            txt_precio4.Enabled = true;
            txt_venta1.Enabled = true;
            txt_venta2.Enabled = true;
            txt_venta3.Enabled = true;
            txt_venta4.Enabled = true;
            txt_codF.Enabled = true;
            txt_costo.Enabled = true;
            txt_descrip.Enabled = true;
            txt_cantidad.Enabled = true;
            gpb_estado.Enabled = true;
            gpb_fact_sin_exp.Enabled = true;
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
        void bloquearBotones()
        {
            Btn_eliminar.Enabled = false;
            Btn_ingresar.Enabled = false;
            Btn_modificar.Enabled = false;
            Btn_guardar.Enabled = true;
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
        void bloquearTextBox()
        {
            txt_codigo.Enabled = false;
            txt_codR.Enabled = false;
            txt_precio1.Enabled = false;
            txt_precio2.Enabled = false;
            txt_precio3.Enabled = false;
            txt_precio4.Enabled = false;
            txt_venta1.Enabled = false;
            txt_venta2.Enabled = false;
            txt_venta3.Enabled = false;
            txt_venta4.Enabled = false;
            txt_codF.Enabled = false;
            txt_costo.Enabled = false;
            txt_descrip.Enabled = false;
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
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            habilitarBotones();
            bloquearBotones();
            txt_costo.Text = "";
            txt_descrip.Text = "";
            txt_precio1.Text = "";    
            gpb_estado.Enabled = false;
            boton_ingreso = true;
            tabControl2.SelectedTab = MantenimientoR;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            dvgClientes.Rows.Clear();
            string sNombre = textBox10.Text;

            try
            {
                DataTable dtBuscar = logic.logicaBuscarclientes(sNombre);

                foreach (DataRow row in dtBuscar.Rows)
                {
                    dvgRepuestos.Rows.Add(row[0].ToString(), row[1].ToString(), row[2].ToString(), row[3].ToString());

                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error en capa diseno recuperar clientes: " + ex.Message);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            
            string sdescripcion = txt_descrip.Text;
            string sPrecio_unitario = txt_precio1.Text;
            int sid_tipo_repuesto = Convert.ToInt32(txt_codR.Text);
            string scod_fabricante =txt_codF.Text;  
            string scosto_repuesto1 =txt_precio1.Text;
            string scosto_repuesto2 = txt_precio2.Text;
            string scosto_repuesto3 = txt_precio3.Text;
            string scosto_repuesto4 = txt_precio4.Text;
            string sprecio_venta1= txt_venta1.Text;
            string sprecio_venta2 = txt_venta2.Text;
            string sprecio_venta3 = txt_venta3.Text;
            string sprecio_venta4 = txt_venta4.Text;
            string scantidad =txt_cantidad.Text;
            string sfacturar_sin_existencia =gpb_fact_sin_exp.Text;
            string sEstado1 = "";

            

            if (boton_ingreso == true)
            {
              
                if (txt_codF.Text == "" || txt_descrip.Text == "" || txt_precio1.Text == "" || txt_precio2.Text == "" || txt_precio3.Text == "" || txt_precio4.Text == "" || txt_venta1.Text == "" || txt_venta2.Text == "" || txt_venta3.Text == "" || txt_venta4.Text == "" || txt_cantidad.Text == "")
                {
                    if (rdb_actio1.Checked)
                        sEstado1 = "1";
                    else
                        sEstado1 = "0";
                    MessageBox.Show("Faltan campos por llenar");
                }

                else
                {
                
                    DataTable dtInsertar = logic.logicaInsertarRepuestos(sid_tipo_repuesto, scod_fabricante, sdescripcion, scosto_repuesto1, scosto_repuesto2, scosto_repuesto3, scosto_repuesto4, sprecio_venta1, sprecio_venta2, sprecio_venta3, sprecio_venta4, scantidad, sEstado1);
                    MessageBox.Show("Repuesto Ingresado Exitosamente");
                    dvgRepuestos.Rows.Clear();
                    limpiarForm();
                   // ActualizarGrid();
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
                    int iCodigo = Convert.ToInt32(txt_codigo.Text);
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


                    DataTable dtModificar = logic.logicaModificarRepuestos(iCodigo, sid_tipo_repuesto, scod_fabricante, sdescripcion, scosto_repuesto1, scosto_repuesto2, scosto_repuesto3, scosto_repuesto4, sprecio_venta1, sprecio_venta2, sprecio_venta3, sprecio_venta4, scantidad, sEstado2, sEstado);
                    MessageBox.Show("Repuesto Modificado Exitosamente");
                    dvgRepuestos.Rows.Clear();

                    limpiarForm();
                    //ActualizarGrid();

                }

            }
            else if (boton_eliminar == true)
            {
                int iCodigo = Convert.ToInt32(txt_codigo.Text);
                DataTable dtEliminar = logic.logicaEliminarRepuestos(iCodigo);
                MessageBox.Show("Repuesto Eliminado Exitosamente");
                dvgRepuestos.Rows.Clear();
                limpiarForm();
                //ActualizarGrid();
            }


            tabControl2.SelectedTab = MantenimientoR;
        }

        void limpiarForm()
        {
            Btn_guardar.Enabled = true;
            Btn_guardar.Enabled = false;
            Btn_modificar.Enabled = true;
            Btn_eliminar.Enabled = true;
            txt_costo.Text = " ";
            txt_descrip.Text = "";
            txt_precio1.Text = "";
            gpb_estado.Enabled = false;
            
        }
        void limpiarFormC()
        {
            btn_guardarC.Enabled = true;
            btn_guardarC.Enabled = false;
            btn_modC.Enabled = true;
            btn_eliminarC.Enabled = true;
            txt_nombreC.Text = " ";
            txt_nitC.Text = "";
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

        }
        void limpiarFormM()
        {
            btn_guardarM.Enabled = true;
            btn_guardarM.Enabled = false;
            btn_modificarM.Enabled = true;
            btn_eliminarM.Enabled = true;
            txt_nombreM.Text = " ";
            gpb_estadoM.Enabled = false;

        }
        void limpiarFormT()
        {
            btn_guardarT.Enabled = true;
            btn_guardarT.Enabled = false;
            btn_modT.Enabled = true;
            btn_eliminarT.Enabled = true;
            txt_nombreT.Text = " ";
            gpb_estadoT.Enabled = false;

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

            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txt_descrip_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_descrip_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void textBox8_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox13_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void textBox18_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void textBox23_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void textBox28_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void textBox29_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox29_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
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
            txt_costo.Text = dvgRepuestos.CurrentRow.Cells[1].Value.ToString();
            txt_descrip.Text = dvgRepuestos.CurrentRow.Cells[2].Value.ToString();
            txt_precio1.Text = dvgRepuestos.CurrentRow.Cells[3].Value.ToString();

            if (dvgRepuestos.CurrentRow.Cells[6].Value.ToString() == "1")
            {
                rdb_actio.Checked = true;
            }
            else
            {
                rdb_inactivo.Checked = true;
            }


            tabControl2.SelectedTab = MantenimientoR;
        }
        private void dvgClientes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            txt_codC.Text = dvgClientes.CurrentRow.Cells[0].Value.ToString();
            txt_nombreC.Text = dvgClientes.CurrentRow.Cells[1].Value.ToString();
            txt_nitC.Text = dvgClientes.CurrentRow.Cells[2].Value.ToString();
           

            if (dvgClientes.CurrentRow.Cells[3].Value.ToString() == "1")
            {
                rdb_actioC.Checked = true;
            }
            else
            {
                rdb_inactivoC.Checked = true;
            }


            tabControl3.SelectedTab = MantenimientoM;
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
            this.Close();
        }

        private void btn_cancelarP_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_cancelarM_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_cancelarT_Click(object sender, EventArgs e)
        {
            this.Close();
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
                    dvgRepuestos.Rows.Add(row[0].ToString(), row[1].ToString(), row[2].ToString(), row[3].ToString(), row[4].ToString());

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
                    dvgRepuestos.Rows.Add(row[0].ToString(), row[1].ToString(), row[2].ToString());

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
                    dvgRepuestos.Rows.Add(row[0].ToString(), row[1].ToString(), row[2].ToString());

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
                    // ActualizarGrid();
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
                    //ActualizarGrid();

                }

            }
            else if (boton_eliminar == true)
            {
                int iCodigo = Convert.ToInt32(txt_codC.Text);
                DataTable dtEliminar = logic.logicaEliminarclientes(iCodigo);
                MessageBox.Show("Cliente Eliminado Exitosamente");
                dvgClientes.Rows.Clear();
                limpiarFormP();
                //ActualizarGrid();
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
                    // ActualizarGrid();
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
                    int iCodigo = Convert.ToInt32(txt_codC.Text);
                    string sEstado = "";

                    if (rdb_actioP.Checked)
                        sEstado = "1";
                    else
                        sEstado = "0";


                    DataTable dtModificar = logic.logicaModificarproveedores(iCodigo, sNombre, snit,sdireccion, sEstado);
                    MessageBox.Show("Proveedor Modificado Exitosamente");
                    dvgProveedores.Rows.Clear();

                    limpiarFormP();
                    //ActualizarGrid();

                }

            }
            else if (boton_eliminar == true)
            {
                int iCodigo = Convert.ToInt32(txt_codP.Text);
                DataTable dtEliminar = logic.logicaEliminarproveedores(iCodigo);
                MessageBox.Show("Proveedor Eliminado Exitosamente");
                dvgProveedores.Rows.Clear();
                limpiarFormP();
                //ActualizarGrid();
            }


            tabControl4.SelectedTab = MantenimientoP;
        }

        private void btn_guardarM_Click(object sender, EventArgs e)
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
                    // ActualizarGrid();
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
                    int iCodigo = Convert.ToInt32(txt_codC.Text);
                    string sEstado = "";

                    if (rdb_actioT.Checked)
                        sEstado = "1";
                    else
                        sEstado = "0";


                    DataTable dtModificar = logic.logicaModificarpago(iCodigo, sNombre, sEstado);
                    MessageBox.Show("Tipo de pago Modificado Exitosamente");
                    dvgPago.Rows.Clear();

                    limpiarFormT();
                    //ActualizarGrid();

                }

            }
            else if (boton_eliminar == true)
            {
                int iCodigo = Convert.ToInt32(txt_codT.Text);
                DataTable dtEliminar = logic.logicaEliminarpago(iCodigo);
                MessageBox.Show("Tipo de pago Eliminado Exitosamente");
                dvgPago.Rows.Clear();
                limpiarFormT();
                //ActualizarGrid();
            }


            tabControl6.SelectedTab = MantenimientoT;
        }

        private void btn_guardarT_Click(object sender, EventArgs e)
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
                    // ActualizarGrid();
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
                    int iCodigo = Convert.ToInt32(txt_codC.Text);
                    string sEstado = "";

                    if (rdb_actioM.Checked)
                        sEstado = "1";
                    else
                        sEstado = "0";


                    DataTable dtModificar = logic.logicaModificarmarca(iCodigo, sNombre, sEstado);
                    MessageBox.Show("Marca Modificada Exitosamente");
                    dvgMarca.Rows.Clear();

                    limpiarFormM();
                    //ActualizarGrid();

                }

            }
            else if (boton_eliminar == true)
            {
                int iCodigo = Convert.ToInt32(txt_codM.Text);
                DataTable dtEliminar = logic.logicaEliminarmarca(iCodigo);
                MessageBox.Show("Marca Eliminada Exitosamente");
                dvgMarca.Rows.Clear();
                limpiarFormM();
                //ActualizarGrid();
            }


            tabControl5.SelectedTab = MantenimientoM;
        }

        private void dvgProveedores_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_codP.Text = dvgProveedores.CurrentRow.Cells[0].Value.ToString();
            txt_nombreP.Text = dvgProveedores.CurrentRow.Cells[1].Value.ToString();
            txt_nitP.Text = dvgProveedores.CurrentRow.Cells[2].Value.ToString();
            txt_direccionP.Text = dvgProveedores.CurrentRow.Cells[3].Value.ToString();

            if (dvgProveedores.CurrentRow.Cells[4].Value.ToString() == "1")
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
           

            if (dvgMarca.CurrentRow.Cells[2].Value.ToString() == "1")
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


            if (dvgPago.CurrentRow.Cells[2].Value.ToString() == "1")
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
    }
}
