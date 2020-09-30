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
    public partial class Consultas : Form
    {
        Logicpublic logic = new Logicpublic();

        public Consultas()
        {
            InitializeComponent();
        }

        private void MantenimientoProveedores_Load(object sender, EventArgs e)
        {
            LoadTheme();
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
                    btn.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;
                }
            }
          
        }

        private void button6_Click(object sender, EventArgs e)
        {
            frm_repuestos repuestos = new frm_repuestos(3);
            AddOwnedForm(repuestos);
            repuestos.Show();
        }

        public static int contadorFila = 0;
        public static double total = 0;
        private void btnAgregarRep_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCodigoProd.Text) || string.IsNullOrEmpty(txtDescripcion.Text) || string.IsNullOrEmpty(txtCantidad.Text))
            {
                MessageBox.Show("Faltan campos por llenar");
                return;
            }

            bool productoExistente = false;
            int posicionFila = 0;

            //si no existe nada en el DGV
            if (contadorFila == 0)
            {
                dgvDevoluciones.Rows.Add(txtCodigoProd.Text, txtDescripcion.Text, txtCantidad.Text);

                contadorFila++;
            }
            else
            {
                //recorrera todas las filas del Dgv
                foreach (DataGridViewRow Fila in dgvDevoluciones.Rows)
                {
                    //si existe un código idéntico a cualquier del DGV
                    if (Fila.Cells[0].Value.ToString() == txtCodigoProd.Text)
                    {
                        productoExistente = true;
                        //posición del IdProducto identico
                        posicionFila = Fila.Index;
                    }
                }

                if (productoExistente == true)
                {
                    dgvDevoluciones.Rows[posicionFila].Cells[2].Value = (Convert.ToDouble(txtCodigoProd.Text) +
                        Convert.ToDouble(dgvDevoluciones.Rows[posicionFila].Cells[2].Value)).ToString();
                }
                else
                {
                    dgvDevoluciones.Rows.Add(txtCodigoProd.Text, txtDescripcion.Text, txtCantidad.Text);


                    contadorFila++;

                }

            }

            total = 0;

            //recorrera todas las filas del Dgv

            txtCantidad.Text = "";
            txtCodigoProd.Text = "";
            txtDescripcion.Text = "";

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void txtCodigoProd_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            if (contadorFila > 0)
            {
                //eliminará el valor que tenía la fila seleccionada que se eliminará

                dgvDevoluciones.Rows.RemoveAt(dgvDevoluciones.CurrentRow.Index);
                contadorFila--;
            }
            else
            {
                MessageBox.Show("No hay repuestos para eliminar");
            }
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvDevoluciones.Rows)
            {
                logic.insertarDevolucion(Convert.ToInt32(row.Cells[0].Value.ToString()), Convert.ToInt32(row.Cells[2].Value.ToString()));
            }

            //Eliminacion y actualizacion de inventario

            bool actualiza = logic.aumentarInventario();

            if (actualiza)
            {
                MessageBox.Show("Devolucion registrada correctamente");
                txtCodigoProd.Text = "";
                txtDescripcion.Text = "";
                txtCantidad.Text = "";
                dgvDevoluciones.Rows.Clear();
                contadorFila = 0;

            }
            else
            {
                MessageBox.Show("Error en la devolucion, intentelo de nuevo");
            }
        }
    }
}
