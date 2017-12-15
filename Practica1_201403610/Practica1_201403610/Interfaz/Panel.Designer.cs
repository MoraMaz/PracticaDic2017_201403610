namespace Practica1_201403610.Interfaz
{
    partial class Panel
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
            this.graficarCola = new System.Windows.Forms.Button();
            this.graficarPila = new System.Windows.Forms.Button();
            this.peekCola = new System.Windows.Forms.Button();
            this.peekPila = new System.Windows.Forms.Button();
            this.lblbienvenido = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cargarArchivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.multiplicarMatricesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "cola";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(309, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "pila";
            // 
            // graficarCola
            // 
            this.graficarCola.Location = new System.Drawing.Point(54, 170);
            this.graficarCola.Name = "graficarCola";
            this.graficarCola.Size = new System.Drawing.Size(75, 26);
            this.graficarCola.TabIndex = 3;
            this.graficarCola.Text = "graficar";
            this.graficarCola.UseVisualStyleBackColor = true;
            this.graficarCola.Click += new System.EventHandler(this.graficarCola_Click);
            // 
            // graficarPila
            // 
            this.graficarPila.Location = new System.Drawing.Point(295, 170);
            this.graficarPila.Name = "graficarPila";
            this.graficarPila.Size = new System.Drawing.Size(75, 26);
            this.graficarPila.TabIndex = 4;
            this.graficarPila.Text = "graficar";
            this.graficarPila.UseVisualStyleBackColor = true;
            this.graficarPila.Click += new System.EventHandler(this.graficarPila_Click);
            // 
            // peekCola
            // 
            this.peekCola.Location = new System.Drawing.Point(54, 226);
            this.peekCola.Name = "peekCola";
            this.peekCola.Size = new System.Drawing.Size(75, 26);
            this.peekCola.TabIndex = 5;
            this.peekCola.Text = "peek";
            this.peekCola.UseVisualStyleBackColor = true;
            this.peekCola.Click += new System.EventHandler(this.peekCola_Click);
            // 
            // peekPila
            // 
            this.peekPila.Location = new System.Drawing.Point(295, 226);
            this.peekPila.Name = "peekPila";
            this.peekPila.Size = new System.Drawing.Size(75, 26);
            this.peekPila.TabIndex = 6;
            this.peekPila.Text = "peek";
            this.peekPila.UseVisualStyleBackColor = true;
            this.peekPila.Click += new System.EventHandler(this.peekPila_Click);
            // 
            // lblbienvenido
            // 
            this.lblbienvenido.AutoSize = true;
            this.lblbienvenido.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbienvenido.Location = new System.Drawing.Point(134, 73);
            this.lblbienvenido.Name = "lblbienvenido";
            this.lblbienvenido.Size = new System.Drawing.Size(53, 20);
            this.lblbienvenido.TabIndex = 7;
            this.lblbienvenido.Text = "label3";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(408, 28);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cargarArchivoToolStripMenuItem,
            this.multiplicarMatricesToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(71, 24);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // cargarArchivoToolStripMenuItem
            // 
            this.cargarArchivoToolStripMenuItem.Name = "cargarArchivoToolStripMenuItem";
            this.cargarArchivoToolStripMenuItem.Size = new System.Drawing.Size(215, 26);
            this.cargarArchivoToolStripMenuItem.Text = "Cargar Archivo";
            this.cargarArchivoToolStripMenuItem.Click += new System.EventHandler(this.cargarArchivoToolStripMenuItem_Click);
            // 
            // multiplicarMatricesToolStripMenuItem
            // 
            this.multiplicarMatricesToolStripMenuItem.Name = "multiplicarMatricesToolStripMenuItem";
            this.multiplicarMatricesToolStripMenuItem.Size = new System.Drawing.Size(215, 26);
            this.multiplicarMatricesToolStripMenuItem.Text = "Multiplicar matrices";
            this.multiplicarMatricesToolStripMenuItem.Click += new System.EventHandler(this.multiplicarMatricesToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(215, 26);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Panel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 297);
            this.Controls.Add(this.lblbienvenido);
            this.Controls.Add(this.peekPila);
            this.Controls.Add(this.peekCola);
            this.Controls.Add(this.graficarPila);
            this.Controls.Add(this.graficarCola);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Panel";
            this.Text = "Bienvenido";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button graficarCola;
        private System.Windows.Forms.Button graficarPila;
        private System.Windows.Forms.Button peekCola;
        private System.Windows.Forms.Button peekPila;
        private System.Windows.Forms.Label lblbienvenido;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cargarArchivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem multiplicarMatricesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}