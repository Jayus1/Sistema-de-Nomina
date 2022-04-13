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
    
    public partial class MenuPrincipal : Form
    {
        bool sidebarExpand=true;
        bool maintenceExpand;
        bool processExpand;
        bool consultExpand;
        bool reportExpand;
        bool toolExpand;
        bool helpExpand;
        public MenuPrincipal()
        {
            InitializeComponent();

            BD.Connect();

            String querys = "SELECT Persona.Nombres, Persona.Apellidos,  Persona.Direccion, Persona.Telefono, Empleado.SueldoFijo, Empleado.ID, Empleado.Puesto, Empleado.Departamento FROM Persona INNER JOIN Empleado ON Persona.Id=Empleado.IdPersona WHERE Persona.Id= @IdPersona";
            SqlCommand command = new SqlCommand(querys,BD._connection);
            command.Parameters.AddWithValue("@IdPersona", BD.IdPersona);
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                labelNombre.Text = reader.GetString(0) + " " + reader.GetString(1);
                labelDireccion.Text = reader.GetString(2);
                labelTelefono.Text = Convert.ToString(reader.GetInt64(3));

                labelSueldoXHora.Text =Convert.ToString(reader.GetInt32(4));
                labelPuestoDeTrabajo.Text = reader.GetString(6);
                labeID.Text = Convert.ToString(reader.GetInt32(5));
                BD.IdEmpleado = reader.GetInt32(5);
                labeDepartamento.Text = reader.GetString(7);
            }
            reader.Close();
            querys = "SELECT Privilegio FROM Usuario WHERE Id = @IdPersona ";
            command = new SqlCommand(querys, BD._connection);
            command.Parameters.AddWithValue("@IdPersona", BD.IdPersona);
            reader = command.ExecuteReader();

            while (reader.Read())
            {
                labelPrivilegio.Text = reader.GetString(0);
                BD.privilegio= reader.GetString(0);
            }
            reader.Close();
            BD.Disconnect();
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
            processTimer.Start();
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
            consultTimer.Start();
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
            maintenceTimer.Start();
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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void labelApellido_Click(object sender, EventArgs e)
        {

        }

        private void panelMenuPrincipal_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
