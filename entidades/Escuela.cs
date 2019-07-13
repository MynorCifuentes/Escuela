namespace CoreEscuela.entidades
{
    class Escuela
    {
        string nombre;
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public int AñoDeCreación{get;set;}
        public string Pais { get; set; }
        public string Ciudad { get; set; }
        private int myVar;

        public Escuela(string nombre, int año){
            this.nombre=nombre;
            AñoDeCreación=año;

        }
      //  public Escuela(string nombre, int año) -> (Nombre,AñoDeCreación) = (nombre,año);
    }
}