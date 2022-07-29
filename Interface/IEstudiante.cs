using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO.Interface
{
    public interface IEstudiante
    {
        string RegistrarEstudiante(int id, string Nombre, string Apellido, DateTime fechaIngreso);
    }
}
