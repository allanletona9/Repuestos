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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            Txt_clave.UseSystemPasswordChar = true;
        }


        string nombreUsuario = "";
        public string obtenerNombreUsuario()
        {
            nombreUsuario = Txt_usuario.Text;
            return nombreUsuario;
        }


        private void button1_Click(object sender, EventArgs e)
        {

            Form1 principal = new Form1();
            AddOwnedForm(principal);
            principal.label2.Text = Txt_usuario.Text;
            this.Hide();
            principal.ShowDialog();
            this.Close();


            //ProcedimientoLogin procedimientoLogin = new ProcedimientoLogin();

            //if (Txt_usuario.Text.Trim() == "")
            //{
            //    MessageBox.Show("Debe ingresar un usuario");
            //}
            //else
            //{
            //    if (Txt_clave.Text.Trim() == "")
            //    {
            //        MessageBox.Show("Debe ingresar su contraseña");
            //    }
            //    else
            //    {
            //        try
            //        {
            //            bool bExisteUsuario = procedimientoLogin.llamarProcedimiento(Txt_usuario.Text, Txt_clave.Text);


            //            if (bExisteUsuario)
            //            {

            //                Form1 principal = new Form1();
            //                AddOwnedForm(principal);                        
            //                principal.label2.Text = Txt_usuario.Text;
            //                this.Hide();
            //                principal.ShowDialog();
            //                this.Close();
            //            }
            //            else
            //            {
            //                MessageBox.Show("Usuario o Contraseña Incorrecta", "Verificacion de Login", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //            }

            //        }
            //        catch (Exception ex)
            //        {
            //            Console.WriteLine(ex);
            //            MessageBox.Show("No Conecto La Base de Datos", "Verificar Conexión", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //        }
            //    }
            //}


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
            Txt_usuario.Clear();
            Txt_usuario.ForeColor = Color.WhiteSmoke;
        }

        private void textBox4_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox4_Click_1(object sender, EventArgs e)
        {
            Txt_clave.Clear();
            //Txt_clave.PasswordChar = false;
            Txt_clave.ForeColor = Color.WhiteSmoke;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == false)
            {
                Txt_clave.UseSystemPasswordChar = true;
            }
            else
            {
                Txt_clave.UseSystemPasswordChar = false;
            }
        }
    }
}
