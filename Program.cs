using System;
using CoreEscuela.entidades;

namespace Etapa1
{
    class Program
    {
        static void Main(string[] args)
        {
            var escuela = new Escuela("Platzi Academy", 2012, TiposEscuela.Primaria, ciudad: "Bogota");

            var arregloCursos = new Curso[3];
            arregloCursos[0] = new Curso() { Nombre = "101" };
            // arregloCursos[1] = new Curso(){Nombre = "102"};
            arregloCursos[2] = new Curso() { Nombre = "301" };

            var curso1 = new Curso()
            {
                Nombre = "101"
            };
            var curso2 = new Curso()
            {
                Nombre = "201"
            };
            arregloCursos[1] = curso2;//otra forma de asignar el curso dos al arreglo
            var curso3 = new Curso()
            {
                Nombre = "301"
            };
            Console.WriteLine(escuela);
            System.Console.WriteLine("===============");

            ImprimirCursos(arregloCursos);

        }

        private static void ImprimirCursos(Curso[] arregloCursos)
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
