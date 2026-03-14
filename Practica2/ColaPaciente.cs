using System;

namespace IPC2_Practica2
{
    /*
    [Paciente1] -> [Paciente2] -> [Paciente3] -> null
    Enqueue → agregar paciente, Dequeue → atender paciente, Peek → ver siguiente paciente, Mostrar cola, Calcular tiempo total
     */

    class ColaPaciente
    {
        private NodoPaciente? frente;
        private NodoPaciente? final;

        //public NodoPaciente frente{get; set;}
        //public NodoPaciente final{get; set; }

        public ColaPaciente()
        {
            frente = null;
            final = null;
        }

        public void Encolar(string nombre, int edad, string especialidad, int tiempoAtencion)
        {
            NodoPaciente nuevo = new NodoPaciente(nombre, edad, especialidad, tiempoAtencion);
            if (frente == null)
            {
                frente = nuevo;
                final = nuevo;
            }
            else
            {
                final!.Siguiente = nuevo;
                final = nuevo;
            }
        }

        public NodoPaciente? Desencolar()
        {
            if (frente == null)
            {
                Console.WriteLine("No hay documentos para imprimir");
                return null;
            }

            NodoPaciente temp = frente;
            frente = frente.Siguiente;

            if (frente == null)
                final = null;

            return temp;
        }

        public bool EstaVacia()
        {
            return frente == null;
        }

        public NodoPaciente? ObtenerFrente()
        {
            return frente;
        }

        // Método adicional útil: Mostrar todos los pacientes
       /* public void MostrarCola()
        {
            if (frente == null)
            {
                Console.WriteLine("La cola está vacía");
                return;
            }

            NodoPaciente? actual = frente;
            int posicion = 1;

            Console.WriteLine("\n--- Cola de Pacientes ---");
            while (actual != null)
            {
                Console.WriteLine($"{posicion}. {actual.Nombre} - {actual.Especialidad} - {actual.TiempoAtencion} min");
                actual = actual.Siguiente;
                posicion++;
            }
            Console.WriteLine("------------------------\n");
        }*/

        // Método para calcular tiempo total de atención
        public int CalcularTiempoTotal()
        {
            int total = 0;
            NodoPaciente? actual = frente;

            while (actual != null)
            {
                total += actual.TiempoAtencion;
                actual = actual.Siguiente;
            }

            return total;
        }
    }
}