using System;
using CoreEscuela.entidades;

namespace Etapa1
{
    class Program
    {
        static void Main(string[] args)
        {
            var escuela = new Escuela("Platzi Academy",2012,TiposEscuela.Primaria,ciudad:"Bogota");
           escuela.Pais = "Colombia";
           escuela.Ciudad ="Bogota";
           
            Console.WriteLine(escuela);
        }
    }
}
