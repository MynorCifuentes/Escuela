using System;
using CoreEscuela.entidades;

namespace Etapa1
{
    class Program
    {
        static void Main(string[] args)
        {
            var escuela = new Escuela("USAC   Academy", 2012, TiposEscuela.Primaria, ciudad: "Bogota");

            var arregloCursos = new Curso[3]{
                new Curso() { Nombre = "101" },new Curso() { Nombre = "201" },new Curso() { Nombre = "301" }
            };


            Console.WriteLine(escuela);
            Console.WriteLine("===============");

            // ImprimirCursosWhile(arregloCursos);
            ImprimirCursosFor(arregloCursos);

        }

        private static void ImprimirCursosFor(Curso[] arregloCursos)
        {
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Curso: " + i + ":" + arregloCursos[i]);
            }
        }

        private static void ImprimirCursosWhile(Curso[] arregloCursos)
        {
            int contador = 0;
            while (contador < arregloCursos.Length)
            {
                Console.WriteLine($"Nombre{arregloCursos[contador].Nombre}, Id{arregloCursos[contador].UniqueId}");
                contador++;
            }
        }
    }
}
