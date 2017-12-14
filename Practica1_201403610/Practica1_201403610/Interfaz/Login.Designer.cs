namespace Practica1_201403610.Interfaz
{
    partial class Login
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.contrasena = new System.Windows.Forms.TextBox();
            this.nombre = new System.Windows.Forms.TextBox();
            this.ingresar = new System.Windows.Forms.Button();
            this.graficarUsuarios = new System.Windows.Forms.Label();
            this.crearUsuario = new System.Windows.Forms.Button();
            this.eliminarUsuario = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(95, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "usuario:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(95, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "contraseña:";
            // 
            // contrasena
            // 
            this.contrasena.Location = new System.Drawing.Point(184, 142);
            this.contrasena.Name = "contrasena";
            this.contrasena.PasswordChar = '*';
            this.contrasena.Size = new System.Drawing.Size(151, 22);
            this.contrasena.TabIndex = 2;
            // 
            // nombre
            // 
            this.nombre.Location = new System.Drawing.Point(184, 87);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(151, 22);
            this.nombre.TabIndex = 3;
            // 
            // ingresar
            // 
            this.ingresar.BackColor = System.Drawing.SystemColors.Control;
            this.ingresar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.ingresar.Location = new System.Drawing.Point(260, 206);
            this.ingresar.Name = "ingresar";
            this.ingresar.Size = new System.Drawing.Size(75, 26);
            this.ingresar.TabIndex = 4;
            this.ingresar.Text = "ingresar";
            this.ingresar.UseVisualStyleBackColor = false;
            this.ingresar.Click += new System.EventHandler(this.ingresar_Click);
            // 
            // graficarUsuarios
            // 
            this.graficarUsuarios.AutoSize = true;
            this.graficarUsuarios.Location = new System.Drawing.Point(304, 9);
            this.graficarUsuarios.Name = "graficarUsuarios";
            this.graficarUsuarios.Size = new System.Drawing.Size(86, 17);
            this.graficarUsuarios.TabIndex = 5;
            this.graficarUsuarios.Text = "ver usuarios";
            this.graficarUsuarios.Click += new System.EventHandler(this.graficarUsuarios_Click);
            // 
            // crearUsuario
            // 
            this.crearUsuario.Location = new System.Drawing.Point(179, 206);
            this.crearUsuario.Name = "crearUsuario";
            this.crearUsuario.Size = new System.Drawing.Size(75, 26);
            this.crearUsuario.TabIndex = 6;
            this.crearUsuario.Text = "crear";
            this.crearUsuario.UseVisualStyleBackColor = true;
            this.crearUsuario.Click += new System.EventHandler(this.crearUsuario_Click);
            // 
            // eliminarUsuario
            // 
            this.eliminarUsuario.Location = new System.Drawing.Point(98, 206);
            this.eliminarUsuario.Name = "eliminarUsuario";
            this.eliminarUsuario.Size = new System.Drawing.Size(75, 26);
            this.eliminarUsuario.TabIndex = 7;
            this.eliminarUsuario.Text = "eliminar";
            this.eliminarUsuario.UseVisualStyleBackColor = true;
            this.eliminarUsuario.Click += new System.EventHandler(this.eliminarUsuario_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 288);
            this.Controls.Add(this.eliminarUsuario);
            this.Controls.Add(this.crearUsuario);
            this.Controls.Add(this.graficarUsuarios);
            this.Controls.Add(this.ingresar);
            this.Controls.Add(this.nombre);
            this.Controls.Add(this.contrasena);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox contrasena;
        private System.Windows.Forms.TextBox nombre;
        private System.Windows.Forms.Button ingresar;
        private System.Windows.Forms.Label graficarUsuarios;
        private System.Windows.Forms.Button crearUsuario;
        private System.Windows.Forms.Button eliminarUsuario;
    }
}

