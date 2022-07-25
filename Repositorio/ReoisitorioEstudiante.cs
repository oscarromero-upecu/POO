using POO.DATOS;
using POO.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO.Repositorio
{
    public class ReoisitorioEstudiante : IrepositorioEstudiante
    {
        public string RegistrarEstudiante(int id, string Nombre, string Apellido)
        {
                    //var estudiante = new Estudiante(
                    //Nombre = nombre,
                    //Apellido = apellido,
                    //FechaDeIngreso = DateTime.Now,
                    //asignaturas.EstadodeAsigantura(Asignatura, nota)
                    //);
            return "Estudiante Registrado";
            
        }
    }
}
