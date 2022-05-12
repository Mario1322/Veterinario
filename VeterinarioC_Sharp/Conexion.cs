using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySqlConnector;

namespace VeterinarioC_Sharp
{
    class Conexion
    {
        public MySqlConnection conexion;

        public Conexion()
        {
            conexion = new MySqlConnection("Server = 127.0.0.1; " +
                                                       "Database = veterinario; " +
                                                       "Uid = root; " +
                                                       "Pwd =;" +
                                                       "Port = 3306;");
        }
        

        public Boolean loginVeterinario(String DNI, String contraseña)
        {
            try
            {
                conexion.Open();
                String sql = "SELECT DNI,contraseña FROM usuario WHERE DNI = '" + DNI + "'";
                MySqlCommand cmd = new MySqlCommand(sql, conexion);
                MySqlDataReader resultado = cmd.ExecuteReader();
                
                if (resultado.Read())
                {
                    string password = resultado.GetString("contraseña");
                    bool correcta = BCrypt.Net.BCrypt.Verify(contraseña, password);
                    conexion.Close();
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message.ToString());
                return false;
            }

            
        }
        public DataTable getDNI(String dni)
        {
            try
            {
                conexion.Open();
                MySqlCommand consulta = new MySqlCommand("SELECT * FROM animal WHERE DNI = '" + dni + "'", conexion);
                MySqlDataReader resultado = consulta.ExecuteReader();
                DataTable datos = new DataTable();
                datos.Load(resultado);
                conexion.Close();
                return datos;
            }

            catch (MySqlException e)
            {
                throw e;
            }
        }
        public DataTable getAnimalActual(String dni, String chip)
        {
            try
            {
                conexion.Open();
                MySqlCommand consulta = new MySqlCommand("SELECT * FROM animal WHERE DNI = '" + dni + "' AND CodigoChip = '" + chip + "'", conexion);
                MySqlDataReader resultado = consulta.ExecuteReader();
                DataTable datos = new DataTable();
                datos.Load(resultado);
                conexion.Close();
                return datos;
            }

            catch (MySqlException e)
            {
                throw e;
            }
        }

        public DataTable getUser(String dni)
        {
            try
            {
                conexion.Open();
                MySqlCommand consulta = new MySqlCommand("SELECT * FROM usuario WHERE DNI = '" + dni + "'", conexion);
                MySqlDataReader resultado = consulta.ExecuteReader();
                DataTable datos = new DataTable();
                datos.Load(resultado);
                conexion.Close();
                return datos;
            }

            catch (MySqlException e)
            {
                throw e;
            }
        }

    }
}
