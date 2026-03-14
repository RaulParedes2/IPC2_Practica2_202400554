namespace IPC2_Practica2
{
    //[Nombre | Edad | Especialidad | Tiempo]
    public class NodoPaciente
    {
        private string nombre;
        private int edad;
        private string especialidad;
        private int tiempoAtencion;
        private NodoPaciente? siguiente;


        public string Nombre
        {
            set
            {
                nombre = value;
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
                edad = value;
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
                especialidad = value;
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
                tiempoAtencion = value;
            }
            get
            {
                return tiempoAtencion;
            }
        }

        public NodoPaciente? Siguiente
        {
            set
            {
                siguiente = value;
            }
            get
            {
                return siguiente;
            }
        }

        

        public NodoPaciente(string nombre, int edad, string especialidad, int tiempoAtencion)  
        {
            this.nombre = nombre;
            this.edad = edad;
            this.especialidad = especialidad;
            this.tiempoAtencion = tiempoAtencion;
            this.siguiente = null;
        }
    }
}