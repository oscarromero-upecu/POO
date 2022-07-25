using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO.NOTAS
{
    public class Notas: Inotas
    {
        private int nota;
        public int Nota
        {
            get
            {
                return nota;
            }
            set
            {
                this.nota = value;
            }
        }

        public Notas() { }//constructor vacio
        public Notas(int nota)
        {
            Nota=nota;
        }

        public bool EstadoEstudiante(int nota)
        {
            if (nota>= 7)
            {
                return true;
            }
            return false;
        }

    }
}
