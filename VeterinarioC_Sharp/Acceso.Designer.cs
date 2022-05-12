
namespace VeterinarioC_Sharp
{
    partial class Acceso
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Acceso));
            this.panel1 = new System.Windows.Forms.Panel();
            this.cerrar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.user = new System.Windows.Forms.TextBox();
            this.pass = new System.Windows.Forms.TextBox();
            this.muestra = new System.Windows.Forms.CheckBox();
            this.entrar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(168)))), ((int)(((byte)(207)))));
            this.panel1.Controls.Add(this.cerrar);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(478, 43);
            this.panel1.TabIndex = 0;
            // 
            // cerrar
            // 
            this.cerrar.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.cerrar.FlatAppearance.BorderSize = 0;
            this.cerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.cerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cerrar.Location = new System.Drawing.Point(431, 2);
            this.cerrar.Name = "cerrar";
            this.cerrar.Size = new System.Drawing.Size(45, 38);
            this.cerrar.TabIndex = 0;
            this.cerrar.Text = "❌";
            this.cerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cerrar.UseVisualStyleBackColor = true;
            this.cerrar.Click += new System.EventHandler(this.cerrar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(151, 57);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(170, 170);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // user
            // 
            this.user.Font = new System.Drawing.Font("Yu Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(168)))), ((int)(((byte)(207)))));
            this.user.Location = new System.Drawing.Point(90, 244);
            this.user.Name = "user";
            this.user.Size = new System.Drawing.Size(290, 35);
            this.user.TabIndex = 3;
            this.user.Text = "Ingrese su Usuario";
            this.user.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.user.MouseDown += new System.Windows.Forms.MouseEventHandler(this.user_BorraTexto);
            // 
            // pass
            // 
            this.pass.Font = new System.Drawing.Font("Yu Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(168)))), ((int)(((byte)(207)))));
            this.pass.Location = new System.Drawing.Point(90, 305);
            this.pass.Name = "pass";
            this.pass.Size = new System.Drawing.Size(290, 35);
            this.pass.TabIndex = 4;
            this.pass.Text = "Ingrese su Contraseña";
            this.pass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.pass.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pass_BorraTexto);
            // 
            // muestra
            // 
            this.muestra.AutoSize = true;
            this.muestra.Font = new System.Drawing.Font("Yu Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.muestra.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(168)))), ((int)(((byte)(207)))));
            this.muestra.Location = new System.Drawing.Point(325, 352);
            this.muestra.Name = "muestra";
            this.muestra.Size = new System.Drawing.Size(55, 26);
            this.muestra.TabIndex = 5;
            this.muestra.Text = "👁️‍🗨️";
            this.muestra.UseVisualStyleBackColor = true;
            this.muestra.CheckStateChanged += new System.EventHandler(this.mostrarOcultarPass);
            // 
            // entrar
            // 
            this.entrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(168)))), ((int)(((byte)(207)))));
            this.entrar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(168)))), ((int)(((byte)(207)))));
            this.entrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(168)))), ((int)(((byte)(207)))));
            this.entrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(168)))), ((int)(((byte)(207)))));
            this.entrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.entrar.Font = new System.Drawing.Font("Yu Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.entrar.ForeColor = System.Drawing.Color.White;
            this.entrar.Location = new System.Drawing.Point(161, 397);
            this.entrar.Name = "entrar";
            this.entrar.Size = new System.Drawing.Size(150, 38);
            this.entrar.TabIndex = 6;
            this.entrar.Text = "Entrar";
            this.entrar.UseVisualStyleBackColor = false;
            this.entrar.Click += new System.EventHandler(this.entrar_Click);
            // 
            // Acceso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(476, 632);
            this.Controls.Add(this.entrar);
            this.Controls.Add(this.muestra);
            this.Controls.Add(this.pass);
            this.Controls.Add(this.user);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Acceso";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.reiniciarText);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button cerrar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox user;
        private System.Windows.Forms.TextBox pass;
        private System.Windows.Forms.CheckBox muestra;
        private System.Windows.Forms.Button entrar;
    }
}

