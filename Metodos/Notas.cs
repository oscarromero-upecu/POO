using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO.Metodos
{
     internal class Notas
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
                //ASIGNA LA NOTA SI CUMPLE LA CONDICION
                if (nota <=11)
                    this.nota = value;
                else
                    //CASO CONTRARIO QUE ME DE UN MENSAJE DE ERROR EXCEPTION
                    throw new ArgumentOutOfRangeException("La nota es sobre 10");
            }
        }
        public Notas()
        {
            Nota = 9;
        }
    }
}
