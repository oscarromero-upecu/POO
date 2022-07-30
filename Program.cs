using POO.Enum;
using POO.Metodos;
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
                //Estudiante EstudianteAprobado = new Estudiante("Oscar Romero",19,DateTime.Now,Generos.Masculino,Asignaturas.Literatura,9,EstadoAsignatura.Aprobado);
                //Console.WriteLine(EstudianteAprobado.EstadoAsignatura));
                //Console.WriteLine(EstudianteAprobado.ID);
                //EstudianteAprobado.Saludos();

                //Estudiante EsturidanteReprobado = new Estudiante("Marcela Proaño", 20, DateTime.Now,Generos.Femenino, Asignaturas.Programacion,10,EstadoAsignatura.Reprobado);
                //Console.WriteLine(EsturidanteReprobado.NombreEstudiante);
                //Console.WriteLine(EsturidanteReprobado.ID);
                //EstudianteAprobado.Saludos();

                Estudiante materias = new Estudiante();
                Console.WriteLine(materias.TraerAsignaturas());

                Curso curso = new Curso(Paralelos.A, 2);
                Console.WriteLine(curso.ImprimirCurso());
                curso.Saludos();


                //ACCEDE AL METODO STATICO SIN INSTANCIAR LA CLASE
                Estudiante.ImprimirValoresConstantes();
                
                Console.ReadKey();
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
