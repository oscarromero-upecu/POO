using POO.DATOS;
using POO.Interface;
using POO.NOTAS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO.Repositorio
{
    public class RepositorioAsignatura : IrepositorioAsignatura
    {
        private string nombremateria;
        private string estadomateria;

        public string NombreMateria
        {
            get
            {
                return nombremateria;
            }
            set
            {
                this.nombremateria = value;
            }
        }
        public string EstadoMateria
        {
            get
            {
                return estadomateria;
            }
            set
            {
                this.estadomateria = value;
            }
        }

        public string IngresarAsignatura(string Asignatura)
        {
            return NombreMateria = Asignatura;
        }
        
        public string EstadoAsignatura(int nota)
        {
            if (nota >= 7)
            {
                EstadoMateria = "APROBADO";
            }
             else EstadoMateria= "REPROBADO";
            return EstadoMateria;
         }
    }
}
