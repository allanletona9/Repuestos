﻿using System;
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
            logic.logic_Obtenerclientes();

        }

        private void tabPage10_Load(object sender, EventArgs e)
        {
            logic.logic_ObtenerRepuestos();
        }
     
        private void Mantenimientos_Load(object sender, EventArgs e)
        {
           
           

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
            txt_nombre.Enabled = true;
            txt_descrip.Enabled = true;
            txt_precio.Enabled = true;
            gpb_estado.Enabled = true;
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
            txt_nombre.Enabled = false;
            txt_descrip.Enabled = false;
            txt_precio.Enabled = false;
            gpb_estado.Enabled = false;
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
            txt_nombre.Text = "";
            txt_descrip.Text = "";
            txt_precio.Text = "";    
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
            string sNombre = txt_nombre.Text;
            string sDescripcion = txt_descrip.Text;
            string sPrecio_unitario = txt_precio.Text;
           

            if (boton_ingreso == true)
            {

                if (txt_nombre.Text == "" || txt_descrip.Text == "" || txt_precio.Text == "" )
                {
                    MessageBox.Show("Faltan campos por llenar");
                }
                else
                {
                
                    DataTable dtInsertar = logic.logicaInsertarRepuestos(sNombre, sDescripcion, sPrecio_unitario);
                    MessageBox.Show("Repuesto Ingresado Exitosamente");
                    dvgRepuestos.Rows.Clear();
                    limpiarForm();
                   // ActualizarGrid();
                }

            }
            else if (boton_modificar == true)
            {
                if (txt_nombre.Text == "" || txt_descrip.Text == "" || txt_precio.Text == "" || txt_codigo.Text == "")
                {
                    MessageBox.Show("Faltan campos por llenar");
                }
                else
                {
                    int iCodigo = Convert.ToInt32(txt_codigo.Text);
                    string sEstado = "";

                    if (rdb_actio.Checked)
                        sEstado = "1";
                    else
                        sEstado = "0";


                    DataTable dtModificar = logic.logicaModificarRepuestos(iCodigo, sNombre, sDescripcion, sPrecio_unitario, sEstado);
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
            txt_nombre.Text = " ";
            txt_descrip.Text = "";
            txt_precio.Text = "";
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
            txt_nombre.Text = dvgRepuestos.CurrentRow.Cells[1].Value.ToString();
            txt_descrip.Text = dvgRepuestos.CurrentRow.Cells[2].Value.ToString();
            txt_precio.Text = dvgRepuestos.CurrentRow.Cells[3].Value.ToString();

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

            txt_codC.Text = dvgRepuestos.CurrentRow.Cells[0].Value.ToString();
            txt_nombreC.Text = dvgRepuestos.CurrentRow.Cells[1].Value.ToString();
            txt_nitC.Text = dvgRepuestos.CurrentRow.Cells[2].Value.ToString();
           

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
                int iCodigo = Convert.ToInt32(txt_codC.Text);
                DataTable dtEliminar = logic.logicaEliminarproveedores(iCodigo);
                MessageBox.Show("Proveedor Eliminado Exitosamente");
                dvgProveedores.Rows.Clear();
                limpiarFormP();
                //ActualizarGrid();
            }


            tabControl4.SelectedTab = MantenimientoP;
        }
    }
}
