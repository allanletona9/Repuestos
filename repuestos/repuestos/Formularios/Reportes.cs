using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace repuestos.Formularios
{
    public partial class Reportes : Form
    {
        public Reportes()
        {
            InitializeComponent();
        }

        private void Reportes_Load(object sender, EventArgs e)
        {
            

        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

            Repuestos reporterepuestos = new Repuestos();
            crystalReportViewer1.ReportSource = reporterepuestos;

        }

        private void crystalReportViewer2_Load(object sender, EventArgs e)
        {
            Clientes reporteclientes = new Clientes();
            crystalReportViewer2.ReportSource = reporteclientes;
        }

        private void crystalReportViewer3_Load(object sender, EventArgs e)
        {
            Proveedores reporteprov = new Proveedores();
            crystalReportViewer3.ReportSource = reporteprov;
        }
    }
}
