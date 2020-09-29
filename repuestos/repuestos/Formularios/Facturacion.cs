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
    public partial class Facturacion : Form
    {
        Logicpublic logic = new Logicpublic();
        bool boton_ingreso = true;
        DateTime fecha = DateTime.Now;
        List<int> lIdTipoPago = new List<int>();
        public Facturacion()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            frm_clientes clientes = new frm_clientes();
            AddOwnedForm(clientes);
            clientes.Show();
        }

        private void Facturacion_Load(object sender, EventArgs e)
        {
            lblFecha.Text = fecha.ToString("dd/MM/yyyy");
            llenarTipoPago();
            txtDesc.Text = "0";
            txtsubtotal_desc.Text = "0.00";
            txtSubtotal.Text = "0.00";
            txtTotal.Text = "0.00";
            txtPago.Text = "0.00";
            txtSaldo.Text = "0.00";
        }

        private void llenarTipoPago()
        {
            cbo_tipoPago.Items.Clear();
            lIdTipoPago.Clear();
            try
            {
                DataTable dtTiposPago = logic.logic_Obtenerpago();

                foreach (DataRow row in dtTiposPago.Rows)
                {
                    cbo_tipoPago.Items.Add(row[0].ToString() + " - " + row[1].ToString());
                    lIdTipoPago.Add(Convert.ToInt32(row[0].ToString()));
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error en capa diseno recuperando los tipos de pago: " + ex.Message);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frm_repuestos repuestos = new frm_repuestos(2);
            AddOwnedForm(repuestos);
            repuestos.Show();
        }

        public static int contadorFila = 0;
        public static double total = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtcodrep.Text) || string.IsNullOrEmpty(txtNombreRep.Text) || string.IsNullOrEmpty(txtPrecio.Text)
                    || string.IsNullOrEmpty(txtCant.Text))
            {
                MessageBox.Show("Faltan campos por llenar");
                return;
            }

            if (txt_facturarsinexistencias.Text == "1")
            {
                if (string.IsNullOrEmpty(txtcodrep.Text) || string.IsNullOrEmpty(txtNombreRep.Text) || string.IsNullOrEmpty(txtPrecio.Text)
                    || string.IsNullOrEmpty(txtCant.Text))
                {
                    MessageBox.Show("Faltan campos por llenar");
                }
                else
                {
                    bool productoExistente = false;
                    int posicionFila = 0;

                    //si no existe nada en el DGV
                    if (contadorFila == 0)
                    {
                        dgvFactDet.Rows.Add(txtcodrep.Text, txtNombreRep.Text, txtCant.Text, txtPrecio.Text);

                        double importe = Convert.ToDouble(dgvFactDet.Rows[contadorFila].Cells[2].Value)
                            * Convert.ToDouble(dgvFactDet.Rows[contadorFila].Cells[3].Value);

                        dgvFactDet.Rows[contadorFila].Cells[4].Value = importe;

                        contadorFila++;


                    }
                    else
                    {
                        //recorrera todas las filas del Dgv
                        foreach (DataGridViewRow Fila in dgvFactDet.Rows)
                        {
                            //si existe un código idéntico a cualquier del DGV
                            if (Fila.Cells[0].Value.ToString() == txtcodrep.Text)
                            {
                                productoExistente = true;
                                //posición del IdProducto identico
                                posicionFila = Fila.Index;
                            }
                        }

                        if (productoExistente == true)
                        {
                            dgvFactDet.Rows[posicionFila].Cells[2].Value = (Convert.ToDouble(txtCant.Text) +
                                Convert.ToDouble(dgvFactDet.Rows[posicionFila].Cells[2].Value)).ToString();

                            double importe = Convert.ToDouble(dgvFactDet.Rows[posicionFila].Cells[2].Value) * Convert.ToDouble(dgvFactDet.Rows[posicionFila].Cells[3].Value);

                            dgvFactDet.Rows[posicionFila].Cells[4].Value = importe;
                        }
                        else
                        {
                            dgvFactDet.Rows.Add(txtcodrep.Text, txtNombreRep.Text, txtCant.Text, txtPrecio.Text);

                            double importe = Convert.ToDouble(dgvFactDet.Rows[contadorFila].Cells[2].Value) * Convert.ToDouble(dgvFactDet.Rows[contadorFila].Cells[3].Value);

                            dgvFactDet.Rows[contadorFila].Cells[4].Value = importe;

                            contadorFila++;

                        }

                    }

                    total = 0;

                    //recorrera todas las filas del Dgv
                    foreach (DataGridViewRow Fila in dgvFactDet.Rows)
                    {
                        total += Convert.ToDouble(Fila.Cells[4].Value);
                    }
                    txtSubtotal.Text = " " + total.ToString();
                    txtSaldo.Text = total.ToString();

                    if (txtDesc.Text == "0" || txtDesc.Text == "")
                        txtTotal.Text = txtSubtotal.Text;

                    txtcodrep.Text = "";
                    txtNombreRep.Text = "";
                    txtPrecio.Text = "";
                    txtCant.Text = "";
                }
            }
            else
            {
                int existencias_actuales = Convert.ToInt32(txtexistencias_actuales.Text);
                int cantidad_actual = Convert.ToInt32(txtCant.Text);

                if (cantidad_actual > existencias_actuales)
                {
                    MessageBox.Show("No es permitido facturar con existencias 0 este repuesto");
                    return;
                }
            }

            
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (contadorFila > 0)
            {
                //eliminará el valor que tenía la fila seleccionada que se eliminará
                total = total - Convert.ToDouble(dgvFactDet.Rows[dgvFactDet.CurrentRow.Index].Cells[4].Value);
                txtSubtotal.Text = " " + total.ToString();

                dgvFactDet.Rows.RemoveAt(dgvFactDet.CurrentRow.Index);
                contadorFila--;
            }
            else
            {
                MessageBox.Show("No hay productos para eliminar");
            }
        }

       

        private void txtTotal_TextChanged(object sender, EventArgs e)
        {
            try
            {

                double total = Convert.ToDouble(txtTotal.Text);
                double pago = Convert.ToDouble(txtPago.Text);
                double saldo = 0.0;

                saldo = total - pago;

                txtSaldo.Text = saldo.ToString();
            }catch(Exception ex)
            {
                Console.WriteLine("Error " + ex.Message);
            }

        }

        private void txtPago_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                e.Handled = true;
                return;
            }
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                try
                {
                    double total = Convert.ToDouble(txtTotal.Text);
                    double pago = Convert.ToDouble(txtPago.Text);
                    double saldo = 0.0;

                    if (pago > total)
                    {
                        MessageBox.Show("El pago no puede ser mayor al total");
                        return;
                    }
                       

                    saldo = total - pago;

                    txtSaldo.Text = saldo.ToString();
                }
                catch (Exception ex)
                {
                    Console.Write("Error: " + ex.Message);
                }
            }
            
        }

        private void txtDesc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                e.Handled = true;
                return;
            }
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                try
                {
                    if (txtDesc.Text == "")
                        return;

                    double descuento = Convert.ToDouble(txtDesc.Text);
                    double subtotal = Convert.ToDouble(txtSubtotal.Text);

                    double total = subtotal - (subtotal * (descuento / 100));

                    txtsubtotal_desc.Text = (subtotal * (descuento / 100)).ToString();

                    txtTotal.Text = total.ToString();
                }
                catch (Exception ex)
                {
                    txtDesc.Text = "";
                    Console.WriteLine("Error: " + ex.Message);
                }
            }
           
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (contadorFila > 0 && cbo_tipoPago.SelectedItem != null)
            {
                try
                {
                    int iFactura = Convert.ToInt32(txtNoFactura.Text);
                    int iCliente = Convert.ToInt32(txtCodCliente.Text);
                    string sTipoPago = lIdTipoPago[cbo_tipoPago.SelectedIndex].ToString();
                    string serie = "";
                    string descuento = txtDesc.Text;
                    string fecha = lblFecha.Text;
                    double subtotal = Convert.ToDouble(txtSubtotal.Text);
                    double valor_descuento = Convert.ToDouble(txtsubtotal_desc.Text);
                    double total = Convert.ToDouble(txtTotal.Text);
                    string comentario = txtComentario.Text;
                    string estado = "";

                    double saldo = Convert.ToDouble(txtSaldo.Text);

                    if (saldo > 0)
                        estado = "deuda";
                    else
                        estado = "pagado";

                    logic.logicaInsertarFactEnc(iFactura, iCliente, Convert.ToInt32(sTipoPago), serie, descuento, fecha, subtotal, valor_descuento, total, comentario, estado);

                    foreach (DataGridViewRow row in dgvFactDet.Rows)
                    {
                        logic.logicaInsertarFactDet(iFactura, Convert.ToInt32(row.Cells[0].Value.ToString()), Convert.ToDouble(row.Cells[3].Value.ToString()), Convert.ToInt32(row.Cells[2].Value.ToString()));
                    }

                    if(sTipoPago == "1")
                    {
                        logic.logicaInsertarVentaEfectivo(iFactura, saldo, estado);
                    }
                    else if (sTipoPago == "2")
                    {
                        logic.logicaInsertarVentaCredito(iFactura, saldo, estado);
                    }

                   
                    MessageBox.Show("Factura Guardada Exitosamente");
                    limpiarForm();
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Ocurrio un problema, vuelva a intentarlo");
                    Console.WriteLine("Error en la insercion de facturas: " + ex.Message);
                    return;
                }

            }
            else
            {
                MessageBox.Show("Faltan campos por llenar");
            }
        }

        private void limpiarForm()
        {
            txtexistencias_actuales.Text = "";
            txt_facturarsinexistencias.Text = "";
            txtNoFactura.Text = "";
            txtCodCliente.Text = "";
            txtNombreCliente.Text = "";
            txtNit.Text = "";
            txtcodrep.Text = "";
            txtNombreRep.Text = "";
            txtPrecio.Text = "";
            txtCant.Text = "";
            cbo_tipoPago.Text = "";
            txtPago.Text = "";
            txtSaldo.Text = "";
            txtComentario.Text = "";
            txtDesc.Text = "0.00";
            txtsubtotal_desc.Text = "0.00";
            txtSubtotal.Text = "0.00";
            txtTotal.Text = "0.00";
            dgvFactDet.Rows.Clear();
            contadorFila = 0;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string sNombre = txtNombreCliente.Text;
            string snit = txtNit.Text;

            DataTable dtBuscar2 = logic.logicaBuscarnit(snit);
            foreach (DataRow row in dtBuscar2.Rows)
            {
                if (row[2].ToString() == txtNit.Text)
                {
                    MessageBox.Show("Nit de Cliente existente");
                    return;
                }
            }

            if (boton_ingreso == true)
            {

                if (txtNombreCliente.Text == "" || txtNit.Text == "")
                {
                   
                    MessageBox.Show("Faltan campos por llenar");
                }
                 
                else
                {

                    DataTable dtInsertar = logic.logicaInsertarclientes(sNombre, snit);
                    MessageBox.Show("Cliente Ingresado Exitosamente");
                
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limpiarForm();
        }

        private void cbo_tipoPago_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtPago_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {

                double total = Convert.ToDouble(txtTotal.Text);
                double pago = Convert.ToDouble(txtPago.Text);
                double saldo = 0.0;

                if (pago > total)
                {
                    MessageBox.Show("El pago no puede ser mayor al total");
                    txtPago.Text = "0";
                    return;
                }

                if (string.IsNullOrEmpty(txtPago.Text))
                {
                    txtSaldo.Text = total.ToString();
                }

                saldo = total - pago;

                txtSaldo.Text = saldo.ToString();
            }
            catch (Exception ex)
            {
                Console.Write("Error: " + ex.Message);
            }
        }

        private void txtNit_Enter(object sender, EventArgs e)
        {
          
        }

        private void txtNit_KeyPress(object sender, KeyPressEventArgs e)
        {

            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                e.Handled = true;
                return;
            }

            string sNit = txtNit.Text;
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                try
            {
                DataTable dtBuscar = logic.logicaBuscarnit(sNit);
                  
                   foreach (DataRow row in dtBuscar.Rows)
                {
                    
                    txtCodCliente.Text = row[0].ToString();
                    txtNombreCliente.Text = row[1].ToString();
                    txtNit.Text = row[2].ToString();
                    } 
                   

                }
            catch (Exception ex)
            {
                Console.WriteLine("Error en capa diseno recuperar clientes: " + ex.Message);
            }

            }
           

        }

        private void btnGuardarImprimir_Click(object sender, EventArgs e)
        {
            ContenedorFactura facturar = new ContenedorFactura();
            facturar.Show();
        }

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                e.Handled = true;
                return;
            }
        }

        private void txtSaldo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                e.Handled = true;
                return;
            }
        }

        private void txtSubtotal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                e.Handled = true;
                return;
            }
        }

        private void txtsubtotal_desc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                e.Handled = true;
                return;
            }
        }

        private void txtTotal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                e.Handled = true;
                return;
            }
        }

        private void txtCant_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                e.Handled = true;
                return;
            }
        }
    }
}
