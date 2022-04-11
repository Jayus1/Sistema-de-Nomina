using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SisNomina
{
    public class Usuarios: Empleado
    {
        public int IdUsuario { get; set; }
        public string Username { get; set; }  
        public string Password { get; set; }
        public string Privilegios { get; set; }

        public bool LogIn(string username, string password, ref Usuarios usuario)
        {
            Connect();
            bool valido = false;

            string querys = "SELECT IdPersona, Username, Contraseña, Privilegio FROM Usuario WHERE Username= @username AND Contraseña= @password";
            SqlCommand command = new SqlCommand(querys, _connection);
            command.Parameters.AddWithValue("@username", username);
            command.Parameters.AddWithValue("@password", password);
            SqlDataReader lector = command.ExecuteReader();
            Console.WriteLine(lector.ToString());


            if (lector.HasRows==true)
            {
                valido = true;
                MenuScreen(ref usuario,lector);
            }
            Disconnect();
            return valido;
        }

        public void MenuScreen(ref Usuarios usuario, SqlDataReader lector)
        {
            Connect();
            while (lector.Read())
            {
                usuario.IdPersona = lector.GetInt32(0);
                usuario.Username = lector.GetString(1);
                usuario.Privilegios = lector.GetString(3);
            }
            string querys = "SELECT Nombres, Apellidos, Cedula, FechaDeNacimiento, Direccion, Telefono, Correo FROM Persona WHERE ID= @IdPersona";
            SqlCommand command = new SqlCommand(querys, _connection);
            command.Parameters.AddWithValue("@IdPersona", usuario.IdPersona);
            lector = command.ExecuteReader();
            while (lector.Read())
            {
                usuario.Name = lector.GetString(0);
                usuario.Apellido = lector.GetString(1);
                usuario.Direccion = lector.GetString(4);
                usuario.Telefono = lector.GetInt64(5);
            }
            lector.Close();
            querys = "SELECT ID, Puesto, Departamento, SueldoXHora FROM Empleado WHere IdPersona= @idpersona";
            command = new SqlCommand(querys, _connection);
            command.Parameters.AddWithValue("@IdPersona", usuario.IdPersona);
            lector=command.ExecuteReader();
            while (lector.Read())
            {
                usuario.IdEmpleado = lector.GetInt32(0);
                usuario.Puesto = lector.GetString(1);
                usuario.Departamento = lector.GetString(2);
                usuario.SueldoPorHora = Convert.ToSingle((decimal)lector.GetSqlMoney(3));
            }


            Disconnect();

        }

    }
}
  