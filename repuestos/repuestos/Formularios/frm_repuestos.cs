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

namespace repuestos.Formularios
{
    public partial class frm_repuestos : Form
    {
        Logicpublic logic = new Logicpublic();
        int iParametro;
        public frm_repuestos(int iParametro)
        {
            InitializeComponent();
            this.iParametro = iParametro;

        }

        private void frm_repuestos_Load(object sender, EventArgs e)
        {
            ActualizarRepuestos();
        }

        void ActualizarRepuestos()
        {
            dgvRepuestos.Rows.Clear();
            DataTable dtInventario = logic.logic_obtenerRepuestosVentas();
            foreach (DataRow row in dtInventario.Rows)
            {
                string sPrecioFactura = row[6].ToString();
                string precio;

                if (sPrecioFactura == "1")
                    precio = row[8].ToString();
                else if (sPrecioFactura == "2")
                    precio = row[9].ToString();
                else if (sPrecioFactura == "3")
                    precio = row[10].ToString();
                else
                    precio = row[11].ToString();

                dgvRepuestos.Rows.Add(row[0].ToString(), row[2].ToString(), row[3].ToString(), precio.ToString(), row[7].ToString(), row[5].ToString());
            }
        }

        private void dgvRepuestos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (iParametro == 1)
            {
                Inventario invt = Owner as Inventario;
                invt.txtcodigoprod1.Text = dgvRepuestos.CurrentRow.Cells[0].Value.ToString();
                this.Close();
            }else if(iParametro == 2)
            {
                Facturacion fact = Owner as Facturacion;
                fact.txtcodrep.Text = dgvRepuestos.CurrentRow.Cells[0].Value.ToString();
                fact.txtNombreRep.Text = dgvRepuestos.CurrentRow.Cells[2].Value.ToString();
                fact.txtPrecio.Text = dgvRepuestos.CurrentRow.Cells[3].Value.ToString();
                fact.txt_facturarsinexistencias.Text = dgvRepuestos.CurrentRow.Cells[4].Value.ToString();
                fact.txtexistencias_actuales.Text = dgvRepuestos.CurrentRow.Cells[5].Value.ToString();
                this.Close();
            }
            else if(iParametro == 3)
            {
                Consultas consults = Owner as Consultas;
                consults.txtCodigoProd.Text = dgvRepuestos.CurrentRow.Cells[0].Value.ToString();
                consults.txtDescripcion.Text = dgvRepuestos.CurrentRow.Cells[2].Value.ToString();
                this.Close();
            }
            else if(iParametro == 4)
            {
                Inventario orden = Owner as Inventario;
                orden.textBox12.Text = dgvRepuestos.CurrentRow.Cells[0].Value.ToString();
                orden.textBox2.Text = dgvRepuestos.CurrentRow.Cells[3].Value.ToString();
                orden.textBox3.Text = dgvRepuestos.CurrentRow.Cells[2].Value.ToString();
                this.Close();
            }
            
        }

        private void dgvRepuestos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

        }
    }
}
