using POO.Repositorio;
using System;

namespace POO
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Estudiante EstudianteAprobado = new Estudiante("Oscar Romero",19,DateTime.Now);
                Console.WriteLine(EstudianteAprobado.Notas.Nota);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
