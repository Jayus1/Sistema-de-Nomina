using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SisNomina
{
    public partial class Login : Form
    {
        Usuarios usuarioLogin=new Usuarios();
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (usuarioLogin.LogIn(textUsername.Text, textpasword.Text, ref usuarioLogin) == true)
            {
                new MenuPrincipal(usuarioLogin).Show(); 
                this.Hide();
            }
            else
            {
                MessageBox.Show("El usuario o la contraseña es incorrecto, intenta de nuevo");
                textpasword.Clear();
                textUsername.Clear();
                textUsername.Focus();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            textUsername.Clear();
            textpasword.Clear();
            textUsername.Focus();

        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
