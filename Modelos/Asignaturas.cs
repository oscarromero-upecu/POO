using POO.NOTAS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO.DATOS
{
    public class Asignaturas 
    {
        public string NombreMateria { get; set; }

        public Asignaturas()
        {

        }
        public Asignaturas( string nombreMateria)
        {
            NombreMateria = nombreMateria;
        }

        


    }
}
