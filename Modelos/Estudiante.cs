using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO.DATOS
{
    public class Estudiante
    {
        Asignaturas asignaturas = new Asignaturas();
        private int Id;
        private string Nombre;
        private string Apellido;
        private DateTime FechaDeIngreso;
        public Estudiante()
        {

        }
        public Estudiante(string nombre, string apellido, DateTime fechaDeIngreso, Asignaturas asignaturas)
        {
            asignaturas = asignaturas;
            Nombre = nombre;
            Apellido = apellido;
            FechaDeIngreso = fechaDeIngreso;
        }

       
    }
}
