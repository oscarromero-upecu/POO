using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO.Interface
{
    public interface IrepositorioEstudiante
    {
        string RegistrarEstudiante(int id, string Nombre, string Apellido);
    }
}
