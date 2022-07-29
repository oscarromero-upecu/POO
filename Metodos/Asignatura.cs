using POO.Enum;
using POO.Interface;
using POO.Metodos;
using System;

namespace POO.Repositorio
{
    public class Asignatura:ISaludo
    {
        private Asignaturas asignaturas;
        private EstadoAsignatura estadoAsignatura;
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
                if (nota <= 11)
                    this.nota = value;
                else
                    //CASO CONTRARIO QUE ME DE UN MENSAJE DE ERROR EXCEPTION
                    throw new ArgumentOutOfRangeException("La nota es sobre 10");
            }
        }

        public EstadoAsignatura EstadoAsignatura
        {
            get
            {
                return estadoAsignatura;
            }
            set
            {
                this.estadoAsignatura = value;
            }
        }
        public Asignaturas Asignaturas
        {
            get
            {
                return asignaturas;
            }
            set
            {
                this.asignaturas = value;
            }
        }

        //CONSTRUCTORES
        #region CONSTRUCTORES
        public Asignatura()
        { }

        public Asignatura(string nombreapellido, int edad)
            : this(Asignaturas.Default, 9, EstadoAsignatura.Default)
        {
        }
        public Asignatura(Asignaturas nombreMateria, int nota, EstadoAsignatura estado)
        {
            Asignaturas = nombreMateria;
            this.Nota = nota;
            EstadoAsignatura = estado;
        }

        #endregion

        public string TraerAsignaturas()
        {
            return ($"Hola manteria 1: {Asignaturas.Ingles}" +
                $" manteria 2: {Asignaturas.Programacion}"+
                $" manteria 2: {Asignaturas.Matematicas}"+
                $" manteria 2: {Asignaturas.Literatura}");
        }

    }
}
