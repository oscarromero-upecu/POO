﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO.Interface
{
    public interface IAsignatura
    {
        string IngresarAsignatura(string Asignatura);
        string EstadoAsignatura(int nota);

    }
}