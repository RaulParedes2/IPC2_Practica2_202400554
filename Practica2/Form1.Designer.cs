using System.Windows.Forms;
namespace IPC2_Practica2
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.cmbEspecialidad = new System.Windows.Forms.ComboBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnAtender = new System.Windows.Forms.Button();
            this.listCola = new System.Windows.Forms.ListBox();
            this.lblTiempoTotal = new System.Windows.Forms.Label();
            this.btnVerCola = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            
            // Labels
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblEdad = new System.Windows.Forms.Label();
            this.lblEspecialidad = new System.Windows.Forms.Label();
            
            this.SuspendLayout();

            // lblNombre
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblNombre.Location = new System.Drawing.Point(30, 25);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(59, 19);
            this.lblNombre.Text = "Nombre:";

            // txtNombre
            this.txtNombre.Location = new System.Drawing.Point(150, 22);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(250, 23);
            this.txtNombre.TabIndex = 0;

            // lblEdad
            this.lblEdad.AutoSize = true;
            this.lblEdad.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblEdad.Location = new System.Drawing.Point(30, 60);
            this.lblEdad.Name = "lblEdad";
            this.lblEdad.Size = new System.Drawing.Size(43, 19);
            this.lblEdad.Text = "Edad:";

            // txtEdad
            this.txtEdad.Location = new System.Drawing.Point(150, 57);
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(250, 23);
            this.txtEdad.TabIndex = 1;

            // lblEspecialidad
            this.lblEspecialidad.AutoSize = true;
            this.lblEspecialidad.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblEspecialidad.Location = new System.Drawing.Point(30, 95);
            this.lblEspecialidad.Name = "lblEspecialidad";
            this.lblEspecialidad.Size = new System.Drawing.Size(82, 19);
            this.lblEspecialidad.Text = "Especialidad:";

            // cmbEspecialidad
            this.cmbEspecialidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEspecialidad.Location = new System.Drawing.Point(150, 92);
            this.cmbEspecialidad.Name = "cmbEspecialidad";
            this.cmbEspecialidad.Size = new System.Drawing.Size(250, 23);
            this.cmbEspecialidad.TabIndex = 2;

            // btnAgregar
            this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(52, 152, 219);
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnAgregar.ForeColor = System.Drawing.Color.White;
            this.btnAgregar.Location = new System.Drawing.Point(150, 140);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(120, 35);
            this.btnAgregar.TabIndex = 3;
            this.btnAgregar.Text = "Agregar Paciente";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);

            // btnAtender
            this.btnAtender.BackColor = System.Drawing.Color.FromArgb(46, 204, 113);
            this.btnAtender.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtender.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnAtender.ForeColor = System.Drawing.Color.White;
            this.btnAtender.Location = new System.Drawing.Point(280, 140);
            this.btnAtender.Name = "btnAtender";
            this.btnAtender.Size = new System.Drawing.Size(120, 35);
            this.btnAtender.TabIndex = 4;
            this.btnAtender.Text = "Atender Paciente";
            this.btnAtender.UseVisualStyleBackColor = false;
            this.btnAtender.Click += new System.EventHandler(this.btnAtender_Click);

            // btnVerCola
            this.btnVerCola.BackColor = System.Drawing.Color.FromArgb(155, 89, 182);
            this.btnVerCola.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerCola.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnVerCola.ForeColor = System.Drawing.Color.White;
            this.btnVerCola.Location = new System.Drawing.Point(150, 190);
            this.btnVerCola.Name = "btnVerCola";
            this.btnVerCola.Size = new System.Drawing.Size(120, 35);
            this.btnVerCola.TabIndex = 5;
            this.btnVerCola.Text = "Ver Cola Graphviz";
            this.btnVerCola.UseVisualStyleBackColor = false;
            this.btnVerCola.Click += new System.EventHandler(this.btnVerCola_Click);

            // btnSalir
            this.btnSalir.BackColor = System.Drawing.Color.FromArgb(231, 76, 60);
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnSalir.ForeColor = System.Drawing.Color.White;
            this.btnSalir.Location = new System.Drawing.Point(280, 190);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(120, 35);
            this.btnSalir.TabIndex = 6;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);

            // listCola
            this.listCola.Font = new System.Drawing.Font("Consolas", 10F);
            this.listCola.FormattingEnabled = true;
            this.listCola.ItemHeight = 15;
            this.listCola.Location = new System.Drawing.Point(30, 250);
            this.listCola.Name = "listCola";
            this.listCola.Size = new System.Drawing.Size(540, 154);
            this.listCola.TabIndex = 7;

            // lblTiempoTotal
            this.lblTiempoTotal.AutoSize = true;
            this.lblTiempoTotal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTiempoTotal.ForeColor = System.Drawing.Color.FromArgb(41, 128, 185);
            this.lblTiempoTotal.Location = new System.Drawing.Point(30, 420);
            this.lblTiempoTotal.Name = "lblTiempoTotal";
            this.lblTiempoTotal.Size = new System.Drawing.Size(150, 21);
            this.lblTiempoTotal.Text = "Tiempo total: 0 min";

            // Form1
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(600, 480);
            this.Controls.Add(this.lblTiempoTotal);
            this.Controls.Add(this.listCola);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnVerCola);
            this.Controls.Add(this.btnAtender);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.cmbEspecialidad);
            this.Controls.Add(this.lblEspecialidad);
            this.Controls.Add(this.txtEdad);
            this.Controls.Add(this.lblEdad);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblNombre);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema de Turnos Médicos";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        // Declaración de controles
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtEdad;
        private System.Windows.Forms.ComboBox cmbEspecialidad;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnAtender;
        private System.Windows.Forms.Button btnVerCola;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.ListBox listCola;
        private System.Windows.Forms.Label lblTiempoTotal;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblEdad;
        private System.Windows.Forms.Label lblEspecialidad;
    }
}