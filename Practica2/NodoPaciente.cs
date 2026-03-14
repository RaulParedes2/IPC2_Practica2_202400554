namespace IPC2_Practica2
{
    //[Nombre | Edad | Especialidad | Tiempo]
    public class NodoPaciente
    {
        private string nombre;
        private int edad;
        private string especialidad;
        private int tiempoAtencion;

        public string Nombre
        {
            set
            {
                value = nombre;
            }
            get
            {
                return nombre;
            }
        }

        public int Edad
        {
            set
            {
                value = edad;
            }
            get
            {
                return edad;
            }
        }
        public string Especialidad
        {
            set
            {
                value = especialidad;
            }
            get
            {
                return especialidad;
            }
        }

        public int TiempoAtencion
        {
            set
            {
                value = tiempoAtencion;
            }
            get
            {
                return tiempoAtencion;
            }
        }

        public NodoPaciente(string nombre, int edad, string especialidad, int tiempoAtenion)
        {
            Nombre = nombre;
            Edad = edad;
            Especialidad = especialidad;
            TiempoAtencion = tiempoAtencion;
        }
    }
}