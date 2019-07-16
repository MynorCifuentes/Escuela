using System;

namespace CoreEscuela.entidades
{
    public class Curso
    {
        public string  UniqueId { get; private set; }
        public string Nombre { get; set; }
        public TiposJornada Jornada { get; set; }
       public Curso()=> UniqueId = Guid.NewGuid().ToString();

       //public override string ToString(){
           //return $"UniqueId: {UniqueId}, Nombre: {Nombre}";
      // }
        
    }
}