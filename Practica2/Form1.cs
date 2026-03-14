using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace IPC2_Practica2
{
    public partial class Form1 : Form
    {
        private ColaPaciente cola = new ColaPaciente();

        public Form1()
        {
            InitializeComponent();
            
            // SOLO agregar items al ComboBox aquí
            cmbEspecialidad.Items.Add("Medicina General");
            cmbEspecialidad.Items.Add("Pediatría");
            cmbEspecialidad.Items.Add("Ginecología");
            cmbEspecialidad.Items.Add("Dermatología");
            
            if (cmbEspecialidad.Items.Count > 0)
                cmbEspecialidad.SelectedIndex = 0;
        }

        private void MostrarCola()
        {
            listCola.Items.Clear();
            
            NodoPaciente? aux = cola.ObtenerFrente();
            int posicion = 1;
            int tiempoAcumulado = 0;

            while (aux != null)
            {
                tiempoAcumulado += aux.TiempoAtencion;
                listCola.Items.Add($"{posicion}. {aux.Nombre} - {aux.Especialidad} ({aux.TiempoAtencion} min) - Espera: {tiempoAcumulado - aux.TiempoAtencion} min");
                aux = aux.Siguiente;
                posicion++;
            }

            // Actualizar tiempo total UNA SOLA VEZ
            lblTiempoTotal.Text = $"Tiempo total: {cola.CalcularTiempoTotal()} minutos";
        }

        private int ObtenerTiempo(string especialidad)
        {
            return especialidad switch
            {
                "Medicina General" => 10,
                "Pediatría" => 15,
                "Ginecología" => 20,
                "Dermatología" => 25,
                _ => 0
            };
        }

        private void btnAgregar_Click(object? sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("Ingrese un nombre", "Validación", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(txtEdad.Text, out int edad) || edad <= 0 || edad > 120)
            {
                MessageBox.Show("Ingrese una edad válida (1-120)", "Validación", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cmbEspecialidad.SelectedItem == null)
            {
                MessageBox.Show("Seleccione una especialidad", "Validación", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string nombre = txtNombre.Text;
            string especialidad = cmbEspecialidad.SelectedItem.ToString()!;
            int tiempo = ObtenerTiempo(especialidad);

            cola.Encolar(nombre, edad, especialidad, tiempo);
            MostrarCola();
            GenerarImagenCola();

            // Limpiar campos
            txtNombre.Clear();
            txtEdad.Clear();
            cmbEspecialidad.SelectedIndex = 0;
            txtNombre.Focus();
        }

        private void btnAtender_Click(object? sender, EventArgs e)
        {
            NodoPaciente? atendido = cola.Desencolar();

            if (atendido == null)
            {
                MessageBox.Show("No hay pacientes en espera", "Cola vacía", 
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Calcular tiempo de espera (simulación)
            int tiempoEspera = 0;
            NodoPaciente? aux = cola.ObtenerFrente();
            while (aux != null)
            {
                tiempoEspera += aux.TiempoAtencion;
                aux = aux.Siguiente;
            }

            MessageBox.Show(
                $"PACIENTE ATENDIDO\n\n" +
                $"Nombre: {atendido.Nombre}\n" +
                $"Edad: {atendido.Edad}\n" +
                $"Especialidad: {atendido.Especialidad}\n" +
                $"Tiempo de atención: {atendido.TiempoAtencion} minutos\n" +
                $"Tiempo de espera: {tiempoEspera} minutos\n\n" +
                $"Total en clínica: {tiempoEspera + atendido.TiempoAtencion} minutos",
                "Atención completada",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );

            MostrarCola();
            GenerarImagenCola();
        }

        private void btnVerCola_Click(object? sender, EventArgs e)
        {
            string rutaPng = Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), 
                "GraphvizCola", 
                "cola.png"
            );
            
            if (File.Exists(rutaPng))
            {
                Process.Start(new ProcessStartInfo
                {
                    FileName = rutaPng,
                    UseShellExecute = true
                });
            }
            else
            {
                MessageBox.Show("Primero debe generar la imagen agregando pacientes.\n" +
                    "Verifique que Graphviz esté instalado en C:\\Program Files\\Graphviz", 
                    "Imagen no encontrada",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }

        private void btnSalir_Click(object? sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show(
                "¿Está seguro que desea salir del sistema?",
                "Confirmar salida",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );
            
            if (resultado == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void GenerarImagenCola()
        {
            try
            {
                string carpeta = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "GraphvizCola");
                
                if (!Directory.Exists(carpeta))
                    Directory.CreateDirectory(carpeta);

                string rutaPng = Path.Combine(carpeta, "cola.png");

                // Construir el código DOT con mejor formato
                string dot = "digraph G {\n";
                dot += "  rankdir=LR;\n";
                dot += "  node [shape=box, style=filled, fillcolor=lightblue, fontname=\"Arial\"];\n";
                dot += "  edge [color=gray];\n";

                NodoPaciente? aux = cola.ObtenerFrente();
                int i = 0;

                if (aux == null)
                {
                    dot += "  vacio [label=\"Cola vacía\", shape=box, fillcolor=lightgray, fontname=\"Arial\"];\n";
                }
                else
                {
                    while (aux != null)
                    {
                        dot += $"  n{i} [label=\"{{ {aux.Nombre} | {aux.Edad} años | {aux.Especialidad} | {aux.TiempoAtencion} min }}\", shape=record];\n";

                        if (aux.Siguiente != null)
                        {
                            dot += $"  n{i} -> n{i + 1};\n";
                        }

                        aux = aux.Siguiente;
                        i++;
                    }
                }

                dot += "}";

                string dotPath = @"C:\Program Files\Graphviz\bin\dot.exe";
                
                if (File.Exists(dotPath))
                {
                    ProcessStartInfo startInfo = new ProcessStartInfo
                    {
                        FileName = dotPath,
                        Arguments = $" -Tpng -o \"{rutaPng}\"",
                        UseShellExecute = false,
                        CreateNoWindow = true,
                        RedirectStandardInput = true
                    };

                    using (Process process = new Process())
                    {
                        process.StartInfo = startInfo;
                        process.Start();
                        process.StandardInput.Write(dot);
                        process.StandardInput.Close();
                        process.WaitForExit(2000);
                    }
                }
            }
            catch (Exception ex)
            {
                // Solo log, no mostrar al usuario para no interrumpir
                System.Diagnostics.Debug.WriteLine($"Error generando imagen: {ex.Message}");
            }
        }
    }
}