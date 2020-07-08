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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

   

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 principal = new Form1();
            AddOwnedForm(principal);
            principal.Show();
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
 


        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
            textBox2.PasswordChar = '*';
            textBox1.ForeColor = Color.WhiteSmoke;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            
            //textBox1.Select(textBox1.TextLength, 0);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox3_Click(object sender, EventArgs e)
        {
            textBox3.Clear();
            textBox3.ForeColor = Color.WhiteSmoke;
        }

        private void textBox4_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox4_Click_1(object sender, EventArgs e)
        {
            textBox4.Clear();
            textBox4.PasswordChar = '*';
            textBox4.ForeColor = Color.WhiteSmoke;
        }
    }
}
