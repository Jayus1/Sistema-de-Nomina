﻿using System;
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
    public partial class Frm_editUser : Form
    {
        bool sidebarExpand=true;
        bool maintenceExpand;
        bool processExpand;
        bool consultExpand;
        bool reportExpand;
        bool toolExpand;
        bool helpExpand;
        int IdPersona;
        //int IdEmpleado;
        public Frm_editUser()
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel16_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button23_Click(object sender, EventArgs e)
        {
            textUsername.Clear();
            textID.Clear();
            textPassword.Clear();
            textPasswordN.Clear();
            comboBoxRango.Items.Clear();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            BD.Connect();

            String querys = "SELECT Persona.ID, Empleado.ID FROM Empleado INNER JOIN Persona ON Empleado.IdPersona=Persona.ID WHERE Empleado.ID= @ID ";
            SqlCommand command = new SqlCommand(querys, BD._connection);
            command.Parameters.AddWithValue("@ID", textID.Text);
            SqlDataReader reader = command.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    IdPersona = reader.GetInt32(0);
                }
                if (textPassword.Text == textPasswordN.Text)
                {
                    querys = "UPDATE Usuario SET Username= @UserName, Contraseña= @Contraseña, Privilegio= @Privilegio WHERE IdPersona= @IdPersona";
                    command = new SqlCommand(querys, BD._connection);
                    command.Parameters.AddWithValue("@IdPersona", IdPersona);
                    command.Parameters.AddWithValue("@UserName", textUsername.Text);
                    command.Parameters.AddWithValue("@Contraseña", textPassword.Text);
                    command.Parameters.AddWithValue("@Privilegio", comboBoxRango.Items.ToString());
                    command.ExecuteNonQuery();

                    MessageBox.Show("Se ha editado el usuario exitosamente!!!");

                }
                else
                {
                    MessageBox.Show("Las contraseñas son diferentes");
                }
            }
            else
            {
                MessageBox.Show("El empleado no se encuentra");
            }
            textUsername.Clear();
            textID.Clear();
            textPassword.Clear();
            textPasswordN.Clear();
            comboBoxRango.Items.Clear();
            BD.Disconnect();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            BD.Connect();

            String querys = "SELECT Persona.ID, Empleado.ID FROM Empleado INNER JOIN Persona ON Empleado.IdPersona=Persona.ID WHERE Empleado.ID= @ID ";
            SqlCommand command = new SqlCommand(querys, BD._connection);
            command.Parameters.AddWithValue("@ID", textID.Text);
            SqlDataReader reader = command.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    IdPersona = reader.GetInt32(0);
                    reader.Close();
                    querys = "SELECT Username,Contraseña, Privilegio FROM Usuario WHERE IdPersona= @IdPersona";
                    command = new SqlCommand(querys, BD._connection);
                    command.Parameters.AddWithValue("@IdPersona", IdPersona);
                    reader = command.ExecuteReader();

                    while(reader.Read())
                    {
                        textUsername.Text = reader.GetString(0);
                        textPassword.Text = reader.GetString(1);
                        comboBoxRango.Text = reader.GetString(2);
                    }

                }
                
            }
            else
            {
                MessageBox.Show("El empleado no se encuentra");
            }
            BD.Disconnect();
        }
    }
}
