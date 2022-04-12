using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SisNomina
{
    public partial class Login : Form
    {
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
            BD.Connect();

            string querys = "SELECT IdPersona, Username, Contraseña, Privilegio FROM Usuario WHERE Username= @username AND Contraseña= @password";
            SqlCommand command = new SqlCommand(querys, BD._connection);
            command.Parameters.AddWithValue("@username", textUsername.Text);
            command.Parameters.AddWithValue("@password", textpasword.Text);
            SqlDataReader lector = command.ExecuteReader();

            while (lector.Read())
            {
                BD.IdPersona = lector.GetInt32(0);
            }

            if (lector.HasRows == true)
            {
                new MenuPrincipal().Show(); 
                this.Hide();
            }
            else
            {
                MessageBox.Show("El usuario o la contraseña es incorrecto, intenta de nuevo");
                textpasword.Clear();
                textUsername.Clear();
                textUsername.Focus();
            }
            BD.Disconnect();
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
