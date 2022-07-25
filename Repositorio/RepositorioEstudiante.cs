using POO.DATOS;
using POO.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO.Repositorio
{
    public class RepositorioEstudiante : IrepositorioEstudiante
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public DateTime FechaDeIngreso { get; set; }

        public string RegistrarEstudiante(int id, string Nombre, string Apellido, DateTime FechaIngreso)
        {
            _estudiante.Id = id;
            _estudiante.Nombre = Nombre;
            _estudiante.Apellido = Apellido;
            _estudiante.FechaDeIngreso = DateTime.Now;
            return   "Estudiante Registrado";
            
        }
    }
}
