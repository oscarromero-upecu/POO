using POO.DATOS;
using POO.Interface;
using POO.Repositorio;
using System;

namespace POO
{
    class Program
    {
        static void Main(string[] args)
        {
            RepositorioEstudiante Estudiante = new RepositorioEstudiante();
            RepositorioAsignatura Asignaturas = new RepositorioAsignatura();

            Console.WriteLine($"Asignatura: {Asignaturas.IngresarAsignatura("Ingles")}");
            Console.WriteLine($"Estado de Materia: { Asignaturas.EstadoAsignatura(10)}");
        }
    }
}
