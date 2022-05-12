
namespace VeterinarioC_Sharp
{
    partial class Cliente
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cliente));
            this.panel1 = new System.Windows.Forms.Panel();
            this.cerrar = new System.Windows.Forms.Button();
            this.tabs = new System.Windows.Forms.TabControl();
            this.usuario = new System.Windows.Forms.TabPage();
            this.holaUsuario = new System.Windows.Forms.Label();
            this.animalElegido = new System.Windows.Forms.Label();
            this.labelApellidos = new System.Windows.Forms.Label();
            this.labelNombreUser = new System.Windows.Forms.Label();
            this.fondoUsuario = new System.Windows.Forms.PictureBox();
            this.miMascota = new System.Windows.Forms.TabPage();
            this.imagenAnimal = new System.Windows.Forms.PictureBox();
            this.estancia = new System.Windows.Forms.Label();
            this.nacimiento = new System.Windows.Forms.Label();
            this.color = new System.Windows.Forms.Label();
            this.sexo = new System.Windows.Forms.Label();
            this.especie = new System.Windows.Forms.Label();
            this.raza = new System.Windows.Forms.Label();
            this.nombre = new System.Windows.Forms.Label();
            this.chip = new System.Windows.Forms.Label();
            this.labelEstancia = new System.Windows.Forms.Label();
            this.labelNacimiento = new System.Windows.Forms.Label();
            this.labelColor = new System.Windows.Forms.Label();
            this.labelSexo = new System.Windows.Forms.Label();
            this.labelEspecie = new System.Windows.Forms.Label();
            this.labelRaza = new System.Windows.Forms.Label();
            this.labelNombre = new System.Windows.Forms.Label();
            this.labelChip = new System.Windows.Forms.Label();
            this.fondoMiMascota = new System.Windows.Forms.PictureBox();
            this.consultorio = new System.Windows.Forms.TabPage();
            this.enviaConsulta = new System.Windows.Forms.Label();
            this.enviar = new System.Windows.Forms.Button();
            this.textoConsulta = new System.Windows.Forms.TextBox();
            this.fondoConsultorio = new System.Windows.Forms.PictureBox();
            this.pedirCita = new System.Windows.Forms.TabPage();
            this.fechaElegida = new System.Windows.Forms.Label();
            this.buttonCita = new System.Windows.Forms.Button();
            this.desplegableHora = new System.Windows.Forms.ComboBox();
            this.labelFechaElegida = new System.Windows.Forms.Label();
            this.calendario = new System.Windows.Forms.MonthCalendar();
            this.fondoPedirCita = new System.Windows.Forms.PictureBox();
            this.desplegableAnimales = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.tabs.SuspendLayout();
            this.usuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fondoUsuario)).BeginInit();
            this.miMascota.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imagenAnimal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fondoMiMascota)).BeginInit();
            this.consultorio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fondoConsultorio)).BeginInit();
            this.pedirCita.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fondoPedirCita)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(168)))), ((int)(((byte)(207)))));
            this.panel1.Controls.Add(this.cerrar);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(655, 43);
            this.panel1.TabIndex = 1;
            // 
            // cerrar
            // 
            this.cerrar.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.cerrar.FlatAppearance.BorderSize = 0;
            this.cerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.cerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cerrar.Location = new System.Drawing.Point(605, 2);
            this.cerrar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cerrar.Name = "cerrar";
            this.cerrar.Size = new System.Drawing.Size(45, 38);
            this.cerrar.TabIndex = 0;
            this.cerrar.Text = "❌";
            this.cerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cerrar.UseVisualStyleBackColor = true;
            this.cerrar.Click += new System.EventHandler(this.cerrar_Click);
            // 
            // tabs
            // 
            this.tabs.Controls.Add(this.usuario);
            this.tabs.Controls.Add(this.miMascota);
            this.tabs.Controls.Add(this.consultorio);
            this.tabs.Controls.Add(this.pedirCita);
            this.tabs.Location = new System.Drawing.Point(0, 43);
            this.tabs.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabs.Multiline = true;
            this.tabs.Name = "tabs";
            this.tabs.SelectedIndex = 0;
            this.tabs.Size = new System.Drawing.Size(655, 510);
            this.tabs.TabIndex = 18;
            // 
            // usuario
            // 
            this.usuario.Controls.Add(this.holaUsuario);
            this.usuario.Controls.Add(this.desplegableAnimales);
            this.usuario.Controls.Add(this.animalElegido);
            this.usuario.Controls.Add(this.labelApellidos);
            this.usuario.Controls.Add(this.labelNombreUser);
            this.usuario.Controls.Add(this.fondoUsuario);
            this.usuario.Location = new System.Drawing.Point(4, 25);
            this.usuario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.usuario.Name = "usuario";
            this.usuario.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.usuario.Size = new System.Drawing.Size(647, 481);
            this.usuario.TabIndex = 2;
            this.usuario.Text = "USUARIO";
            this.usuario.UseVisualStyleBackColor = true;
            // 
            // holaUsuario
            // 
            this.holaUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.holaUsuario.Location = new System.Drawing.Point(101, 22);
            this.holaUsuario.Name = "holaUsuario";
            this.holaUsuario.Size = new System.Drawing.Size(404, 41);
            this.holaUsuario.TabIndex = 6;
            this.holaUsuario.Text = "HOLA USUARIO";
            this.holaUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // animalElegido
            // 
            this.animalElegido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.animalElegido.Location = new System.Drawing.Point(27, 166);
            this.animalElegido.Name = "animalElegido";
            this.animalElegido.Size = new System.Drawing.Size(211, 28);
            this.animalElegido.TabIndex = 4;
            this.animalElegido.Text = "Selecciona tu animal";
            // 
            // labelApellidos
            // 
            this.labelApellidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelApellidos.Location = new System.Drawing.Point(238, 124);
            this.labelApellidos.Name = "labelApellidos";
            this.labelApellidos.Size = new System.Drawing.Size(211, 28);
            this.labelApellidos.TabIndex = 1;
            this.labelApellidos.Text = "Apellidos";
            this.labelApellidos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelNombreUser
            // 
            this.labelNombreUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombreUser.Location = new System.Drawing.Point(27, 124);
            this.labelNombreUser.Name = "labelNombreUser";
            this.labelNombreUser.Size = new System.Drawing.Size(211, 28);
            this.labelNombreUser.TabIndex = 0;
            this.labelNombreUser.Text = "NombreUser";
            this.labelNombreUser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // fondoUsuario
            // 
            this.fondoUsuario.Image = ((System.Drawing.Image)(resources.GetObject("fondoUsuario.Image")));
            this.fondoUsuario.Location = new System.Drawing.Point(-4, 0);
            this.fondoUsuario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.fondoUsuario.Name = "fondoUsuario";
            this.fondoUsuario.Size = new System.Drawing.Size(651, 485);
            this.fondoUsuario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.fondoUsuario.TabIndex = 2;
            this.fondoUsuario.TabStop = false;
            // 
            // miMascota
            // 
            this.miMascota.Controls.Add(this.imagenAnimal);
            this.miMascota.Controls.Add(this.estancia);
            this.miMascota.Controls.Add(this.nacimiento);
            this.miMascota.Controls.Add(this.color);
            this.miMascota.Controls.Add(this.sexo);
            this.miMascota.Controls.Add(this.especie);
            this.miMascota.Controls.Add(this.raza);
            this.miMascota.Controls.Add(this.nombre);
            this.miMascota.Controls.Add(this.chip);
            this.miMascota.Controls.Add(this.labelEstancia);
            this.miMascota.Controls.Add(this.labelNacimiento);
            this.miMascota.Controls.Add(this.labelColor);
            this.miMascota.Controls.Add(this.labelSexo);
            this.miMascota.Controls.Add(this.labelEspecie);
            this.miMascota.Controls.Add(this.labelRaza);
            this.miMascota.Controls.Add(this.labelNombre);
            this.miMascota.Controls.Add(this.labelChip);
            this.miMascota.Controls.Add(this.fondoMiMascota);
            this.miMascota.Location = new System.Drawing.Point(4, 25);
            this.miMascota.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.miMascota.Name = "miMascota";
            this.miMascota.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.miMascota.Size = new System.Drawing.Size(647, 481);
            this.miMascota.TabIndex = 0;
            this.miMascota.Text = "MI MASCOTA";
            this.miMascota.UseVisualStyleBackColor = true;
            // 
            // imagenAnimal
            // 
            this.imagenAnimal.Location = new System.Drawing.Point(32, 32);
            this.imagenAnimal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.imagenAnimal.Name = "imagenAnimal";
            this.imagenAnimal.Size = new System.Drawing.Size(311, 313);
            this.imagenAnimal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imagenAnimal.TabIndex = 34;
            this.imagenAnimal.TabStop = false;
            // 
            // estancia
            // 
            this.estancia.BackColor = System.Drawing.Color.Transparent;
            this.estancia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.estancia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.estancia.Location = new System.Drawing.Point(363, 214);
            this.estancia.Name = "estancia";
            this.estancia.Size = new System.Drawing.Size(99, 26);
            this.estancia.TabIndex = 33;
            this.estancia.Text = "Vivienda:";
            // 
            // nacimiento
            // 
            this.nacimiento.BackColor = System.Drawing.Color.Transparent;
            this.nacimiento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nacimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nacimiento.Location = new System.Drawing.Point(363, 162);
            this.nacimiento.Name = "nacimiento";
            this.nacimiento.Size = new System.Drawing.Size(120, 26);
            this.nacimiento.TabIndex = 32;
            this.nacimiento.Text = "Nacimiento:";
            // 
            // color
            // 
            this.color.BackColor = System.Drawing.Color.Transparent;
            this.color.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.color.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.color.Location = new System.Drawing.Point(363, 188);
            this.color.Name = "color";
            this.color.Size = new System.Drawing.Size(77, 26);
            this.color.TabIndex = 31;
            this.color.Text = "Color:";
            // 
            // sexo
            // 
            this.sexo.BackColor = System.Drawing.Color.Transparent;
            this.sexo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sexo.Location = new System.Drawing.Point(363, 135);
            this.sexo.Name = "sexo";
            this.sexo.Size = new System.Drawing.Size(73, 26);
            this.sexo.TabIndex = 30;
            this.sexo.Text = "Sexo:";
            // 
            // especie
            // 
            this.especie.BackColor = System.Drawing.Color.Transparent;
            this.especie.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.especie.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.especie.Location = new System.Drawing.Point(363, 110);
            this.especie.Name = "especie";
            this.especie.Size = new System.Drawing.Size(93, 26);
            this.especie.TabIndex = 29;
            this.especie.Text = "Especie:";
            // 
            // raza
            // 
            this.raza.BackColor = System.Drawing.Color.Transparent;
            this.raza.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.raza.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.raza.Location = new System.Drawing.Point(363, 84);
            this.raza.Name = "raza";
            this.raza.Size = new System.Drawing.Size(73, 26);
            this.raza.TabIndex = 28;
            this.raza.Text = "Raza:";
            // 
            // nombre
            // 
            this.nombre.BackColor = System.Drawing.Color.Transparent;
            this.nombre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombre.Location = new System.Drawing.Point(363, 32);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(93, 26);
            this.nombre.TabIndex = 27;
            this.nombre.Text = "Nombre:";
            // 
            // chip
            // 
            this.chip.BackColor = System.Drawing.Color.Transparent;
            this.chip.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chip.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chip.Location = new System.Drawing.Point(363, 58);
            this.chip.Name = "chip";
            this.chip.Size = new System.Drawing.Size(73, 26);
            this.chip.TabIndex = 26;
            this.chip.Text = "Chip:";
            // 
            // labelEstancia
            // 
            this.labelEstancia.BackColor = System.Drawing.Color.Transparent;
            this.labelEstancia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelEstancia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEstancia.Location = new System.Drawing.Point(481, 214);
            this.labelEstancia.Name = "labelEstancia";
            this.labelEstancia.Size = new System.Drawing.Size(139, 118);
            this.labelEstancia.TabIndex = 25;
            this.labelEstancia.Text = "estancia";
            // 
            // labelNacimiento
            // 
            this.labelNacimiento.BackColor = System.Drawing.Color.Transparent;
            this.labelNacimiento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelNacimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNacimiento.Location = new System.Drawing.Point(481, 162);
            this.labelNacimiento.Name = "labelNacimiento";
            this.labelNacimiento.Size = new System.Drawing.Size(139, 26);
            this.labelNacimiento.TabIndex = 24;
            this.labelNacimiento.Text = "naicimiento";
            // 
            // labelColor
            // 
            this.labelColor.BackColor = System.Drawing.Color.Transparent;
            this.labelColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelColor.Location = new System.Drawing.Point(481, 188);
            this.labelColor.Name = "labelColor";
            this.labelColor.Size = new System.Drawing.Size(139, 26);
            this.labelColor.TabIndex = 23;
            this.labelColor.Text = "color";
            // 
            // labelSexo
            // 
            this.labelSexo.BackColor = System.Drawing.Color.Transparent;
            this.labelSexo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelSexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSexo.Location = new System.Drawing.Point(481, 135);
            this.labelSexo.Name = "labelSexo";
            this.labelSexo.Size = new System.Drawing.Size(139, 26);
            this.labelSexo.TabIndex = 22;
            this.labelSexo.Text = "sexo";
            // 
            // labelEspecie
            // 
            this.labelEspecie.BackColor = System.Drawing.Color.Transparent;
            this.labelEspecie.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelEspecie.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEspecie.Location = new System.Drawing.Point(481, 110);
            this.labelEspecie.Name = "labelEspecie";
            this.labelEspecie.Size = new System.Drawing.Size(139, 26);
            this.labelEspecie.TabIndex = 21;
            this.labelEspecie.Text = "especie";
            // 
            // labelRaza
            // 
            this.labelRaza.BackColor = System.Drawing.Color.Transparent;
            this.labelRaza.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelRaza.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRaza.Location = new System.Drawing.Point(481, 84);
            this.labelRaza.Name = "labelRaza";
            this.labelRaza.Size = new System.Drawing.Size(139, 26);
            this.labelRaza.TabIndex = 20;
            this.labelRaza.Text = "raza";
            // 
            // labelNombre
            // 
            this.labelNombre.BackColor = System.Drawing.Color.Transparent;
            this.labelNombre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombre.Location = new System.Drawing.Point(481, 32);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(139, 26);
            this.labelNombre.TabIndex = 19;
            this.labelNombre.Text = "nombre";
            // 
            // labelChip
            // 
            this.labelChip.BackColor = System.Drawing.Color.Transparent;
            this.labelChip.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelChip.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelChip.Location = new System.Drawing.Point(481, 58);
            this.labelChip.Name = "labelChip";
            this.labelChip.Size = new System.Drawing.Size(139, 26);
            this.labelChip.TabIndex = 18;
            this.labelChip.Text = "chip";
            // 
            // fondoMiMascota
            // 
            this.fondoMiMascota.Image = ((System.Drawing.Image)(resources.GetObject("fondoMiMascota.Image")));
            this.fondoMiMascota.Location = new System.Drawing.Point(-7, 0);
            this.fondoMiMascota.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.fondoMiMascota.Name = "fondoMiMascota";
            this.fondoMiMascota.Size = new System.Drawing.Size(651, 485);
            this.fondoMiMascota.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.fondoMiMascota.TabIndex = 35;
            this.fondoMiMascota.TabStop = false;
            // 
            // consultorio
            // 
            this.consultorio.Controls.Add(this.enviaConsulta);
            this.consultorio.Controls.Add(this.enviar);
            this.consultorio.Controls.Add(this.textoConsulta);
            this.consultorio.Controls.Add(this.fondoConsultorio);
            this.consultorio.Location = new System.Drawing.Point(4, 25);
            this.consultorio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.consultorio.Name = "consultorio";
            this.consultorio.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.consultorio.Size = new System.Drawing.Size(647, 481);
            this.consultorio.TabIndex = 1;
            this.consultorio.Text = "CONSULTORIO";
            this.consultorio.UseVisualStyleBackColor = true;
            // 
            // enviaConsulta
            // 
            this.enviaConsulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enviaConsulta.ForeColor = System.Drawing.Color.Black;
            this.enviaConsulta.Location = new System.Drawing.Point(47, 44);
            this.enviaConsulta.Name = "enviaConsulta";
            this.enviaConsulta.Size = new System.Drawing.Size(297, 34);
            this.enviaConsulta.TabIndex = 8;
            this.enviaConsulta.Text = "Envía tu consulta🐾";
            // 
            // enviar
            // 
            this.enviar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(168)))), ((int)(((byte)(207)))));
            this.enviar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(168)))), ((int)(((byte)(207)))));
            this.enviar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(168)))), ((int)(((byte)(207)))));
            this.enviar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(168)))), ((int)(((byte)(207)))));
            this.enviar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.enviar.Font = new System.Drawing.Font("Yu Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enviar.ForeColor = System.Drawing.Color.White;
            this.enviar.Location = new System.Drawing.Point(231, 391);
            this.enviar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.enviar.Name = "enviar";
            this.enviar.Size = new System.Drawing.Size(149, 38);
            this.enviar.TabIndex = 7;
            this.enviar.Text = "Enviar";
            this.enviar.UseVisualStyleBackColor = false;
            this.enviar.Click += new System.EventHandler(this.enviar_Click);
            // 
            // textoConsulta
            // 
            this.textoConsulta.Location = new System.Drawing.Point(47, 86);
            this.textoConsulta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textoConsulta.Multiline = true;
            this.textoConsulta.Name = "textoConsulta";
            this.textoConsulta.Size = new System.Drawing.Size(493, 218);
            this.textoConsulta.TabIndex = 0;
            // 
            // fondoConsultorio
            // 
            this.fondoConsultorio.Image = ((System.Drawing.Image)(resources.GetObject("fondoConsultorio.Image")));
            this.fondoConsultorio.Location = new System.Drawing.Point(-4, -2);
            this.fondoConsultorio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.fondoConsultorio.Name = "fondoConsultorio";
            this.fondoConsultorio.Size = new System.Drawing.Size(651, 485);
            this.fondoConsultorio.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.fondoConsultorio.TabIndex = 9;
            this.fondoConsultorio.TabStop = false;
            // 
            // pedirCita
            // 
            this.pedirCita.Controls.Add(this.fechaElegida);
            this.pedirCita.Controls.Add(this.buttonCita);
            this.pedirCita.Controls.Add(this.desplegableHora);
            this.pedirCita.Controls.Add(this.labelFechaElegida);
            this.pedirCita.Controls.Add(this.calendario);
            this.pedirCita.Controls.Add(this.fondoPedirCita);
            this.pedirCita.Location = new System.Drawing.Point(4, 25);
            this.pedirCita.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pedirCita.Name = "pedirCita";
            this.pedirCita.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pedirCita.Size = new System.Drawing.Size(647, 481);
            this.pedirCita.TabIndex = 3;
            this.pedirCita.Text = "PEDIR CITA";
            this.pedirCita.UseVisualStyleBackColor = true;
            // 
            // fechaElegida
            // 
            this.fechaElegida.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fechaElegida.Location = new System.Drawing.Point(308, 27);
            this.fechaElegida.Name = "fechaElegida";
            this.fechaElegida.Size = new System.Drawing.Size(157, 31);
            this.fechaElegida.TabIndex = 9;
            this.fechaElegida.Text = "Fecha Elegida:";
            // 
            // buttonCita
            // 
            this.buttonCita.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(168)))), ((int)(((byte)(207)))));
            this.buttonCita.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(168)))), ((int)(((byte)(207)))));
            this.buttonCita.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(168)))), ((int)(((byte)(207)))));
            this.buttonCita.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(168)))), ((int)(((byte)(207)))));
            this.buttonCita.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonCita.Font = new System.Drawing.Font("Yu Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCita.ForeColor = System.Drawing.Color.White;
            this.buttonCita.Location = new System.Drawing.Point(231, 391);
            this.buttonCita.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonCita.Name = "buttonCita";
            this.buttonCita.Size = new System.Drawing.Size(149, 38);
            this.buttonCita.TabIndex = 8;
            this.buttonCita.Text = "Pedir";
            this.buttonCita.UseVisualStyleBackColor = false;
            this.buttonCita.Click += new System.EventHandler(this.buttonCita_Click);
            // 
            // desplegableHora
            // 
            this.desplegableHora.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.desplegableHora.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.desplegableHora.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.desplegableHora.FormattingEnabled = true;
            this.desplegableHora.Items.AddRange(new object[] {
            "10:00:00",
            "10:30:00",
            "11:00:00",
            "11:30:00",
            "12:00:00",
            "12:30:00",
            "13:00:00",
            "13:30:00",
            "14:00:00",
            "16:00:00",
            "16:30:00",
            "17:00:00",
            "17:30:00",
            "18:00:00"});
            this.desplegableHora.Location = new System.Drawing.Point(25, 246);
            this.desplegableHora.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.desplegableHora.Name = "desplegableHora";
            this.desplegableHora.Size = new System.Drawing.Size(256, 24);
            this.desplegableHora.TabIndex = 2;
            this.desplegableHora.SelectedIndexChanged += new System.EventHandler(this.desplegableHora_SelectedIndexChanged);
            // 
            // labelFechaElegida
            // 
            this.labelFechaElegida.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFechaElegida.Location = new System.Drawing.Point(471, 27);
            this.labelFechaElegida.Name = "labelFechaElegida";
            this.labelFechaElegida.Size = new System.Drawing.Size(166, 31);
            this.labelFechaElegida.TabIndex = 1;
            this.labelFechaElegida.Text = "FechaElegida";
            // 
            // calendario
            // 
            this.calendario.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.calendario.Location = new System.Drawing.Point(25, 27);
            this.calendario.MaxSelectionCount = 1;
            this.calendario.MinDate = new System.DateTime(2022, 5, 10, 19, 26, 27, 0);
            this.calendario.Name = "calendario";
            this.calendario.ShowTodayCircle = false;
            this.calendario.TabIndex = 0;
            this.calendario.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.calendario_DateChanged);
            // 
            // fondoPedirCita
            // 
            this.fondoPedirCita.Image = ((System.Drawing.Image)(resources.GetObject("fondoPedirCita.Image")));
            this.fondoPedirCita.Location = new System.Drawing.Point(-4, -2);
            this.fondoPedirCita.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.fondoPedirCita.Name = "fondoPedirCita";
            this.fondoPedirCita.Size = new System.Drawing.Size(655, 485);
            this.fondoPedirCita.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.fondoPedirCita.TabIndex = 10;
            this.fondoPedirCita.TabStop = false;
            // 
            // desplegableAnimales
            // 
            this.desplegableAnimales.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.desplegableAnimales.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.desplegableAnimales.FormattingEnabled = true;
            this.desplegableAnimales.Location = new System.Drawing.Point(243, 166);
            this.desplegableAnimales.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.desplegableAnimales.Name = "desplegableAnimales";
            this.desplegableAnimales.Size = new System.Drawing.Size(187, 28);
            this.desplegableAnimales.TabIndex = 5;
            this.desplegableAnimales.SelectedIndexChanged += new System.EventHandler(this.desplegableAnimales_SelectedIndexChanged);
            this.desplegableAnimales.Click += new System.EventHandler(this.desplegableAnimales_Click);
            // 
            // Cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 553);
            this.Controls.Add(this.tabs);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Cliente";
            this.Text = "Inicio";
            this.panel1.ResumeLayout(false);
            this.tabs.ResumeLayout(false);
            this.usuario.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fondoUsuario)).EndInit();
            this.miMascota.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imagenAnimal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fondoMiMascota)).EndInit();
            this.consultorio.ResumeLayout(false);
            this.consultorio.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fondoConsultorio)).EndInit();
            this.pedirCita.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fondoPedirCita)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl tabs;
        private System.Windows.Forms.TabPage miMascota;
        private System.Windows.Forms.Label estancia;
        private System.Windows.Forms.Label nacimiento;
        private System.Windows.Forms.Label color;
        private System.Windows.Forms.Label sexo;
        private System.Windows.Forms.Label especie;
        private System.Windows.Forms.Label raza;
        private System.Windows.Forms.Label nombre;
        private System.Windows.Forms.Label chip;
        private System.Windows.Forms.Label labelEstancia;
        private System.Windows.Forms.Label labelNacimiento;
        private System.Windows.Forms.Label labelColor;
        private System.Windows.Forms.Label labelSexo;
        private System.Windows.Forms.Label labelEspecie;
        private System.Windows.Forms.Label labelRaza;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.Label labelChip;
        private System.Windows.Forms.TabPage consultorio;
        private System.Windows.Forms.PictureBox imagenAnimal;
        private System.Windows.Forms.TextBox textoConsulta;
        private System.Windows.Forms.Button enviar;
        private System.Windows.Forms.Label enviaConsulta;
        private System.Windows.Forms.TabPage usuario;
        private System.Windows.Forms.Label labelApellidos;
        private System.Windows.Forms.Label labelNombreUser;
        private System.Windows.Forms.TabPage pedirCita;
        private System.Windows.Forms.MonthCalendar calendario;
        private System.Windows.Forms.Button cerrar;
        private System.Windows.Forms.Label labelFechaElegida;
        private System.Windows.Forms.ComboBox desplegableHora;
        private System.Windows.Forms.Label fechaElegida;
        private System.Windows.Forms.Button buttonCita;
        private System.Windows.Forms.PictureBox fondoUsuario;
        private System.Windows.Forms.PictureBox fondoMiMascota;
        private System.Windows.Forms.PictureBox fondoConsultorio;
        private System.Windows.Forms.PictureBox fondoPedirCita;
        private System.Windows.Forms.Label animalElegido;
        private System.Windows.Forms.Label holaUsuario;
        private System.Windows.Forms.ComboBox desplegableAnimales;
    }
}