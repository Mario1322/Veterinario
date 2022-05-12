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


namespace VeterinarioC_Sharp
{

    public partial class Cliente : Form
    {
        Conexion conexion = new Conexion();
        public Image imagen;
        public Cliente()
        {

            InitializeComponent();
            CenterToScreen();

            //Hacer transparente los label estando encima de una imagen
            //Labels del tab Usuario
            labelNombreUser.Parent = fondoUsuario;
            labelNombreUser.BackColor = Color.Transparent;
            labelApellidos.Parent = fondoUsuario;
            labelApellidos.BackColor = Color.Transparent;
            labelApellidos.Parent = fondoUsuario;
            labelApellidos.BackColor = Color.Transparent;
            labelApellidos.Parent = fondoUsuario;
            labelApellidos.BackColor = Color.Transparent;

            //Labels del tab Mi Mascota
            imagenAnimal.Parent = fondoMiMascota;
            imagenAnimal.BackColor = Color.Transparent;
            nombre.Parent = fondoMiMascota;
            nombre.BackColor = Color.Transparent;
            chip.Parent = fondoMiMascota;
            chip.BackColor = Color.Transparent;
            raza.Parent = fondoMiMascota;
            raza.BackColor = Color.Transparent;
            especie.Parent = fondoMiMascota;
            especie.BackColor = Color.Transparent;
            sexo.Parent = fondoMiMascota;
            sexo.BackColor = Color.Transparent;
            nacimiento.Parent = fondoMiMascota;
            nacimiento.BackColor = Color.Transparent;
            color.Parent = fondoMiMascota;
            color.BackColor = Color.Transparent;
            estancia.Parent = fondoMiMascota;
            estancia.BackColor = Color.Transparent;
            labelNombre.Parent = fondoMiMascota;
            labelNombre.BackColor = Color.Transparent;
            labelChip.Parent = fondoMiMascota;
            labelChip.BackColor = Color.Transparent;
            labelRaza.Parent = fondoMiMascota;
            labelRaza.BackColor = Color.Transparent;
            labelEspecie.Parent = fondoMiMascota;
            labelEspecie.BackColor = Color.Transparent;
            labelSexo.Parent = fondoMiMascota;
            labelSexo.BackColor = Color.Transparent;
            labelNacimiento.Parent = fondoMiMascota;
            labelNacimiento.BackColor = Color.Transparent;
            labelColor.Parent = fondoMiMascota;
            labelColor.BackColor = Color.Transparent;
            labelEstancia.Parent = fondoMiMascota;
            labelEstancia.BackColor = Color.Transparent;
            animalElegido.Parent = fondoUsuario;
            animalElegido.BackColor = Color.Transparent;
            holaUsuario.Parent = fondoUsuario;
            holaUsuario.BackColor = Color.Transparent;


            //Labels del tab Consultorio
            enviaConsulta.Parent = fondoConsultorio;
            enviaConsulta.BackColor = Color.Transparent;

            //Labels del tab Pedir Cita
            fechaElegida.Parent = fondoPedirCita;
            fechaElegida.BackColor = Color.Transparent;
            labelFechaElegida.Parent = fondoPedirCita;
            labelFechaElegida.BackColor = Color.Transparent;

            holaUsuario.Text = "";
            labelChip.Text = "";
            labelNombre.Text = "";
            labelEspecie.Text = "";
            labelRaza.Text = "";
            labelSexo.Text = "";
            labelColor.Text = "";
            labelNacimiento.Text = "";
            labelEstancia.Text = "";
            labelNombreUser.Text = "";
            labelApellidos.Text = "";
            labelFechaElegida.Text = "";
        }

        
        private void cerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public void getChip(String chip)
        {
            labelChip.Text = chip;
        }
        public void getNombre(String nombre)
        {
            labelNombre.Text = nombre;
        }
        public void getEspecie(String especie)
        {
            labelEspecie.Text = especie;
        }
        public void getRaza(String raza)
        {
            labelRaza.Text = raza;
        }
        public void getSexo(String sexo)
        {
            labelSexo.Text = sexo;
        }
        public void getColor(String color)
        {
            labelColor.Text = color;
        }
        public void getNacimiento(String nacimiento)
        {
            labelNacimiento.Text = nacimiento;
        }
        public void getEstancia(String estancia)
        {
            labelEstancia.Text = estancia;
        }
        public void getNombreUser(String nombreUser)
        {
            holaUsuario.Text = "HOLA " + nombreUser;
            labelNombreUser.Text = nombreUser;
        }
        public void getApellidos(String apellidos)
        {
            labelApellidos.Text = apellidos;
        }


        
        private void enviar_Click(object sender, EventArgs e)
        {
            conexion.conexion.Open();
            String sql = "INSERT INTO consulta(Texto,DNI,Nombre,NombreAnimal) values('" + textoConsulta.Text + "' , '" + Acceso.dniActual + "' , '" + labelNombreUser.Text + "' , '" + labelNombre.Text + "')";
            MySqlCommand cmd = new MySqlCommand(sql, conexion.conexion);

            textoConsulta.Text = "";
            try
            {
                cmd.ExecuteNonQuery();
                conexion.conexion.Close();
                MessageBox.Show("Consulta enviada");
            }
            catch (MySqlException)
            {
                MessageBox.Show("Error al enviar la consulta");
            }
        }
        private void buttonCita_Click(object sender, EventArgs e)
        {
            conexion.conexion.Open();
            String sql = "INSERT INTO cita(Fecha,DNI,Nombre,NombreAnimal) values('" + labelFechaElegida.Text + "' , '" + Acceso.dniActual + "' , '" + labelNombreUser.Text + "' , '" + labelNombre.Text + "')";
            MySqlCommand cmd = new MySqlCommand(sql, conexion.conexion);
            try
            {
                cmd.ExecuteNonQuery();
                conexion.conexion.Close();
                MessageBox.Show("Consulta enviada");
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error al enviar la cita" + ex.ToString());
            }
        }

        private void calendario_DateChanged(object sender, DateRangeEventArgs e)
        {
            labelFechaElegida.Text = calendario.SelectionRange.Start.ToString("yyyy-MM-dd") + " " + desplegableHora.Text;
        }

        private void desplegableHora_SelectedIndexChanged(object sender, EventArgs e)
        {
            labelFechaElegida.Text = calendario.SelectionRange.Start.ToString("yyyy-MM-dd") + " " + desplegableHora.Text;
        }
        bool click = true;
        private void desplegableAnimales_Click(object sender, EventArgs e)
        {
            if (click)
            {
                try
                {
                    click = false;
                    DataTable nombreAnimales = new DataTable();
                    nombreAnimales = conexion.getDNI(Acceso.dniActual);

                    String animal1 = nombreAnimales.Rows[0]["Nombre"].ToString();

                    desplegableAnimales.Items.Insert(0, animal1);

                    if (nombreAnimales.Rows.Count > 1)
                    {
                        String animal2 = nombreAnimales.Rows[1]["Nombre"].ToString();
                        desplegableAnimales.Items.Insert(1, animal2);
                    }


                    conexion.conexion.Close();


                }

                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }

        }

        private void desplegableAnimales_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable datosUser = new DataTable();
            datosUser = conexion.getDNI(Acceso.dniActual);
            getNombre(datosUser.Rows[desplegableAnimales.SelectedIndex]["Nombre"].ToString());
            getRaza(datosUser.Rows[desplegableAnimales.SelectedIndex]["Raza"].ToString());
            getChip(datosUser.Rows[desplegableAnimales.SelectedIndex]["CodigoChip"].ToString());
            getNombre(datosUser.Rows[desplegableAnimales.SelectedIndex]["Nombre"].ToString());
            getEspecie(datosUser.Rows[desplegableAnimales.SelectedIndex]["Especie"].ToString());
            getRaza(datosUser.Rows[desplegableAnimales.SelectedIndex]["Raza"].ToString());
            getSexo(datosUser.Rows[desplegableAnimales.SelectedIndex]["Sexo"].ToString());
            getColor(datosUser.Rows[desplegableAnimales.SelectedIndex]["Color"].ToString());
            getNacimiento(datosUser.Rows[desplegableAnimales.SelectedIndex]["FechaNacimiento"].ToString());
            getEstancia(datosUser.Rows[desplegableAnimales.SelectedIndex]["LugarEstancia"].ToString());
            imagenAnimal.Image = Image.FromFile(".\\Imagenes\\img" + labelNombre.Text + ".png");
        }
        public void getImagen()
        {
            try
            {
                imagenAnimal.Image = Image.FromFile(".\\Imagenes\\img" + labelNombre.Text + ".png");
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }

        }
    }
}
