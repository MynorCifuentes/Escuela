using System;
using CoreEscuela.entidades;

namespace Etapa1
{
    class Program
    {
        static void Main(string[] args)
        {
            var escuela = new Escuela("Platzi Academy",2012,TiposEscuela.Primaria,ciudad:"Bogota");

            var arregloCursos = new Curso[3];
            arregloCursos[0] = new Curso(){Nombre = "101"};
           // arregloCursos[1] = new Curso(){Nombre = "102"};
            arregloCursos[2] = new Curso(){Nombre = "301"};
        
           var curso1 = new Curso(){
               Nombre ="101"
           };
           var curso2 = new Curso(){
               Nombre ="201"
           };
           arregloCursos[1]= curso2;//otra forma de asignar el curso dos al arreglo
           var curso3 = new Curso(){
               Nombre ="301"
           };
            Console.WriteLine(escuela);
            System.Console.WriteLine("===============");
            Console.WriteLine(arregloCursos[0].Nombre);
            Console.WriteLine("Presione ENTER para continuar");
            Console.ReadLine();
            System.Console.WriteLine(arregloCursos[1].Nombre);
            Console.WriteLine("Presione ENTER para continuar");
            Console.ReadLine();
            System.Console.WriteLine(arregloCursos[2].Nombre);
           
        }
    }
}
