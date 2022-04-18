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
    public partial class Frm_changePassword : Form
    {
        bool sidebarExpand=true;
        bool maintenceExpand;
        bool processExpand;
        bool consultExpand;
        bool reportExpand;
        bool toolExpand;
        bool helpExpand;
        bool exitExpand;

        public Frm_changePassword()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                sidebar.Width -= 10;
                if (sidebar.Width == sidebar.MinimumSize.Width)
                {
                    sidebarExpand = false;
                    sidebarTimer.Stop();
                }
            }
            else
            {
                sidebar.Width += 10;
                if (sidebar.Width == sidebar.MaximumSize.Width)
                {
                    sidebarExpand = true;
                    sidebarTimer.Stop();
                }
            }
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void menuButton_Click(object sender, EventArgs e)
        {
            sidebarTimer.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Frm_createUser().Show();
            this.Hide();
        }

        private void homeContainer_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void homeTimer_Tick(object sender, EventArgs e)
        {
            if(maintenceExpand)
            {
                maintenceContainer.Height += 10;
                if(maintenceContainer.Height==maintenceContainer.MaximumSize.Height)
                {
                    maintenceExpand = false;
                    maintenceTimer.Stop();
                }
            }
            else
            {
                maintenceContainer.Height -= 10;
                if(maintenceContainer.Height==maintenceContainer.MinimumSize.Height)
                {
                    maintenceExpand = true;
                    maintenceTimer.Stop();
                }
            }
        }

        private void panel10_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel9_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button15_Click(object sender, EventArgs e)
        {
            new Frm_lookInNomin().Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (BD.privilegio == "Administrador")
             {
               processTimer.Start();   
             }
        }

        private void processTimer_Tick(object sender, EventArgs e)
        {
            if (processExpand)
            {
                processContainer.Height += 10;
                if (processContainer.Height == processContainer.MaximumSize.Height)
                {
                    processExpand = false;
                    processTimer.Stop();
                }
            }
            else
            {
                processContainer.Height -= 10;
                if (processContainer.Height == processContainer.MinimumSize.Height)
                {
                    processExpand = true;
                    processTimer.Stop();
                }
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            new Frm_lookPayments().Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            reportTimer.Start();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (BD.privilegio == "Administrador")
             {
                consultTimer.Start();
             }
        }

        private void consultTimer_Tick(object sender, EventArgs e)
        {
            if (consultExpand)
            {
                consultContainer.Height += 10;
                if (consultContainer.Height == consultContainer.MaximumSize.Height)
                {
                    consultExpand = false;
                    consultTimer.Stop();
                }
            }
            else
            {
                consultContainer.Height -= 10;
                if (consultContainer.Height == consultContainer.MinimumSize.Height)
                {
                    consultExpand = true;
                    consultTimer.Stop();
                }
            }
        }

        private void reportTimer_Tick(object sender, EventArgs e)
        {
            if (reportExpand)
            {
                reportContainer.Height += 10;
                if (reportContainer.Height == reportContainer.MaximumSize.Height)
                {
                    reportExpand = false;
                    reportTimer.Stop();
                }
            }
            else
            {
                reportContainer.Height -= 10;
                if (reportContainer.Height == reportContainer.MinimumSize.Height)
                {
                    reportExpand = true;
                    reportTimer.Stop();
                }
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            toolTimer.Start();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            helpTimer.Start();
        }

        private void toolTimer_Tick(object sender, EventArgs e)
        {
            if (toolExpand)
            {
                toolContainer.Height += 10;
                if (toolContainer.Height == toolContainer.MaximumSize.Height)
                {
                    toolExpand = false;
                    toolTimer.Stop();
                }
            }
            else
            {
                toolContainer.Height -= 10;
                if (toolContainer.Height == toolContainer.MinimumSize.Height)
                {
                    toolExpand = true;
                    toolTimer.Stop();
                }
            }
        }

        private void helpTimer_Tick(object sender, EventArgs e)
        {
            if (helpExpand)
            {
                helpContainer.Height += 10;
                if (helpContainer.Height == helpContainer.MaximumSize.Height)
                {
                    helpExpand = false;
                    helpTimer.Stop();
                }
            }
            else
            {
                helpContainer.Height -= 10;
                if (helpContainer.Height == helpContainer.MinimumSize.Height)
                {
                    helpExpand = true;
                    helpTimer.Stop();
                }
            }
        }

        private void panel18_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            new MenuPrincipal().Show();
            this.Hide();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            new Frm_editUser().Show();
            this.Hide();
        }

        private void buttoMaintence(object sender, EventArgs e)
        {
            if (BD.privilegio == "Administrador")
             {
                maintenceTimer.Start();   
             }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            new Frm_addEmployee().Show();
            this.Hide();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            new Frm_addOT().Show();
            this.Hide();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            new Frm_addReduce().Show();
            this.Hide();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            new Frm_lookNomin().Show();
            this.Hide();
        }

        private void button16s_Click(object sender, EventArgs e)
        {
            new Frm_lookWorkHours().Show();
            this.Hide();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            new Frm_lookOTs().Show();
            this.Hide();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            new Frm_editEmployee().Show();
            this.Hide();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            new Frm_changePassword().Show();
            this.Hide();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            new Frm_instrution().Show();
            this.Hide();
        }

        private void button22_Click(object sender, EventArgs e)
        {
            new Frm_question().Show();
            this.Hide();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel33_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel32_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void textUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button13_Click_1(object sender, EventArgs e)
        {
            textPasswordC.Clear();
            textPasswordN.Clear();
            textPasswordNN.Clear();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            BD.Connect();

            string querys = "SELECT Contraseña FROM Usuario WHERE Contraseña= @Password AND IdPersona= @id";
            SqlCommand command = new SqlCommand(querys, BD._connection);
            command.Parameters.AddWithValue("@Password", textPasswordC.Text);
            command.Parameters.AddWithValue("@id", BD.IdPersona);
            SqlDataReader reader = command.ExecuteReader();

            if (reader.HasRows)
            {
                if(textPasswordN.Text==textPasswordNN.Text)
                {
                    reader.Close();
                    querys = "UPDATE Usuario SET Contraseña= @PasswordN WHERE Contraseña= @Password AND IdPersona= @id";
                    command=new SqlCommand(querys, BD._connection);
                    command.Parameters.AddWithValue("@PasswordN", textPasswordN.Text);
                    command.Parameters.AddWithValue("@Password", textPasswordC.Text);
                    command.Parameters.AddWithValue("@id", BD.IdPersona);
                    command.ExecuteNonQuery();

                    MessageBox.Show("Contraseña cambiada exitosamente");
                }
                else
                {
                    MessageBox.Show("Las contraseñas no coinciden");
                }
            }
            else
            {
                MessageBox.Show("La contraseña actual es incorrecta");
            }

            textPasswordC.Clear();
            textPasswordN.Clear();
            textPasswordNN.Clear();

            BD.Disconnect();
        }

        private void button23_Click(object sender, EventArgs e)
        {
            new Frm_addPayment().Show();
            this.Hide();
        }

        private void button26_Click(object sender, EventArgs e)
        {
            exitTimer.Start();
        }

        private void button25_Click(object sender, EventArgs e)
        {
            new Login().Show();
            this.Hide();
            BD.IdEmpleado = 0;
            BD.IdPersona = 0;
            BD.privilegio = null;
        }

        private void button24_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void exitTimer_Tick(object sender, EventArgs e)
        {
            if (exitExpand)
            {
                exitContainer.Height += 10;
                if (exitContainer.Height == exitContainer.MaximumSize.Height)
                {
                    exitExpand = false;
                    exitTimer.Stop();
                }
            }
            else
            {
                exitContainer.Height -= 10;
                if (exitContainer.Height == exitContainer.MinimumSize.Height)
                {
                    exitExpand = true;
                    exitTimer.Stop();
                }
            }
        }
    }
}
