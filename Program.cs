using System;
using CoreEscuela.entidades;

namespace Etapa1
{
    class Program
    {
        static void Main(string[] args)
        {
            var escuela = new Escuela("Platzi Academy",2012);
           escuela.Pais = "Colombia";
           escuela.Ciudad ="Bogota";
           escuela.TipoEscuela = TiposEscuela.Primaria;
            Console.WriteLine(escuela);
        }
    }
}
