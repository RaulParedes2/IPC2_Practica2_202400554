namespace IPC2_Prctica2
{
    /*
    [Paciente1] -> [Paciente2] -> [Paciente3] -> null
    Enqueue → agregar paciente, Dequeue → atender paciente, Peek → ver siguiente paciente, Mostrar cola, Calcular tiempo total
     */

    class ColaPaciente
    {
        NodoPaciente frente;
        NodoPAciente final;

        public ColaPaciente()
        {
            frente = null;
            final = null;
        }

        public void Enqueue(NodoPaciente nuevo)
        {
            if (frente == null)
            {
                frente = nuevo;
                final = nuevo;
            }
            else
            {
                final.Siguiente = nuevo;
                final = nuevo;
            }
        }

        public NodoPaciente Dequeue()
        {
            if (frente == null)
                return null;

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

        public NodoPaciente ObtenerFrente()
        {
            return frente;
        }
    }
}