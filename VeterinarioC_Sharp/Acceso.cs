using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySqlConnector;
using BCrypt.Net;


namespace VeterinarioC_Sharp
{ 

    public partial class Acceso : Form
    {
        DataTable datosAnimal = new DataTable();
        DataTable datosUser = new DataTable();

        Cliente v2 = new Cliente();
        Conexion conexion = new Conexion();
        public Acceso()
        {
            //String myHash = BCrypt.Net.BCrypt.HashPassword("1234", BCrypt.Net.BCrypt.GenerateSalt());

            //Console.WriteLine(myHash);

            InitializeComponent();
            CenterToScreen();
        }
        public static string dniActual = "";
        

        private void entrar_Click(object sender, EventArgs e)
        {
            //String textoPass = pass.Text;
            //String myHash = BCrypt.Net.BCrypt.HashPassword(textoPass, BCrypt.Net.BCrypt.GenerateSalt());

            if (conexion.loginVeterinario(user.Text, pass.Text))
            {
                dniActual = user.Text;
                datosAnimal = conexion.getDNI(dniActual);
                datosUser = conexion.getUser(dniActual);
                v2.getChip(datosAnimal.Rows[0]["CodigoChip"].ToString());
                v2.getNombre(datosAnimal.Rows[0]["Nombre"].ToString()); 
                v2.getEspecie(datosAnimal.Rows[0]["Especie"].ToString());
                v2.getRaza(datosAnimal.Rows[0]["Raza"].ToString());
                v2.getSexo(datosAnimal.Rows[0]["Sexo"].ToString());
                v2.getColor(datosAnimal.Rows[0]["Color"].ToString());
                v2.getNacimiento(datosAnimal.Rows[0]["FechaNacimiento"].ToString());
                v2.getEstancia(datosAnimal.Rows[0]["LugarEstancia"].ToString());
                v2.getNombreUser(datosUser.Rows[0]["Nombre"].ToString());
                v2.getApellidos(datosUser.Rows[0]["Apellidos"].ToString());
                v2.getImagen();
                this.Hide();
                v2.Show();
                MessageBox.Show("Bienvenido");
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos");
            }

            

        }

        private void cerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void user_BorraTexto(object sender, MouseEventArgs e)
        {
            if (user.Text == "Ingrese su Usuario")
            {
                user.Clear();
            }

            if (pass.Text == "")
            {
                pass.Text = "Ingrese su Contraseña";
                pass.UseSystemPasswordChar = false;
            }
         }

        private void pass_BorraTexto(object sender, MouseEventArgs e)
        {
            if (pass.Text=="Ingrese su Contraseña")
            {
                pass.Clear();
                pass.UseSystemPasswordChar = true;
            }

            if (user.Text == "")
            {
                user.Text = "Ingrese su Usuario";
            }
        }

        private void mostrarOcultarPass(object sender, EventArgs e)
        {
            if (muestra.Checked)
            {
                pass.UseSystemPasswordChar = false;
            }
            else
            {
                pass.UseSystemPasswordChar = true;
            }
        }

        private void reiniciarText(object sender, MouseEventArgs e)
        {
            if (user.Text == "")
            {
                user.Text = "Ingrese su Usuario";
            }

            if (pass.Text == "")
            {
                pass.Text = "Ingrese su Contraseña";
                pass.UseSystemPasswordChar = false;
            }
        }

    }
}
