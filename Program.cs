using POO.Enum;
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
                //INSTANCIA LA CLASE ESTUDIENTE
                Estudiante EstudianteAprobado = new Estudiante("Oscar Romero",19,DateTime.Now,Generos.Femenino,Asignaturas.Literatura,9,EstadoAsignatura.Aprobado);
                Console.WriteLine(EstudianteAprobado.ToString());
                Console.WriteLine(EstudianteAprobado.ID);

                Estudiante EsturidanteReprobado = new Estudiante("Marcela Proaño", 20, DateTime.Now,Generos.Masculino, Asignaturas.Programacion,10,EstadoAsignatura.Reprobado);
                Console.WriteLine(EsturidanteReprobado.ToString());
                Console.WriteLine(EsturidanteReprobado.ID);

                Estudiante materias = new Estudiante();
                Console.WriteLine(materias.TraerAsignaturas());
               

                //ACCEDE AL METODO STATICO SIN INSTANCIAR LA CLASE
                Estudiante.ImprimirValoresConstantes();
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
