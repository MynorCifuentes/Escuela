namespace CoreEscuela.entidades
{
    class Escuela
    {
        string nombre;
        public string Nombre
        {
            get { return "Copia " + nombre; }
            set { nombre = value; }
        }

        public int AñoDeCreación { get; set; }
        public string Pais { get; set; }
        public string Ciudad { get; set; }
        public TiposEscuela TipoEscuela { get; set; }


        public Escuela(string nombre, int año) => (Nombre, AñoDeCreación) = (nombre, año);
        public override string ToString(){
           return $"Nombre{Nombre}, Tipo{TipoEscuela} \n Pais{Pais}, Ciudad{Ciudad}";

        }
    }
}