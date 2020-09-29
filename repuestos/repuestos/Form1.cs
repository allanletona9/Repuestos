using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using repuestos.Formularios;
namespace repuestos
{
    public partial class Form1 : Form
    {
        //FIELDS
        private Button currentButton;
        private Random random;
        private int tempIndex;
        private Form activeForm;
        //constructor
        public string _Mensaje;
        public Form1()
        {
            InitializeComponent();
            random = new Random();
            btnCerrar.Visible = false;
            this.Text = string.Empty;
            this.ControlBox = false;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        //metodos
        private Color SelectThemeColor()
        {
            int index = random.Next(ThemeColor.ColorList.Count);
            while (tempIndex == index)
            {
               index = random.Next(ThemeColor.ColorList.Count);
            }
            tempIndex = index;
            string color = ThemeColor.ColorList[index];
            return ColorTranslator.FromHtml(color);
        }

        private void ActivateButton(object btnSender)
        {
            if(btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    Color color = SelectThemeColor();
                    currentButton = (Button)(btnSender);
                    currentButton.BackColor=color;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font= new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    panelTitulo.BackColor = color;
                    panelLogo.BackColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                    ThemeColor.PrimaryColor = color;
                    ThemeColor.SecondaryColor= ThemeColor.ChangeColorBrightness(color, -0.3);
                    btnCerrar.Visible = true;
                }
            }

        }

        private void DisableButton()
        {
            foreach(Control previousBtn in panelMenu.Controls)
            {
                if (previousBtn.GetType()==typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(51, 51, 76);
                    previousBtn.ForeColor = Color.Gainsboro;
                    previousBtn.Font= new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }

        }
        private void OpenChildForm(Form childForm,object btnSender)
        {

            if (activeForm!=null)
            {
                activeForm.Close();
            }
            ActivateButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(childForm);
            this.panelContenedor.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            panelTitulo.Text = childForm.Text;
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

       
        private void Form1_Load(object sender, EventArgs e)
        {
           
            Login mv = new Login();
            mv.Close();

        }

        private void btnfacturacion_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Formularios.Facturacion(), sender);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Formularios.Consultas(), sender);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Formularios.Reportes(), sender);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Formularios.Mantenimientos(), sender);
        }

        private void button5_Click(object sender, EventArgs e)
        {
         
            OpenChildForm(new Formularios.Inventario(), sender);
        }

        private void button6_Click(object sender, EventArgs e)
        {
           
            this.Hide();
            Login Log = new Login();
            Log.ShowDialog();

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
                activeForm.Close();
            Reset();
        }
        private void Reset()
        {
            DisableButton();
            lbltitulo.Text = "INICIO";
            panelTitulo.BackColor = Color.FromArgb(0,150,136);
            currentButton = null;
            btnCerrar.Visible = false;
        }

        private void panelTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;
                    }

        private void btnMinimized_Click(object sender, EventArgs e)
        {
            this.WindowState =FormWindowState.Minimized;
        }

        private void horafecha_Tick(object sender, EventArgs e)
        {
            lblhora.Text = DateTime.Now.ToString("hh:mm:ss");
            lblfecha.Text = DateTime.Now.ToLongDateString();
        }
    }
}
