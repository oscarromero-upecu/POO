using POO.Enum;
using POO.Interface;
using POO.Metodos;
using System;

namespace POO.Repositorio
{
    public abstract class Asignatura : IAsignatura
    {
        //CAMPOS
        #region CAMPOS
        private Asignaturas asignaturas;
        private EstadoAsignatura estadoAsignatura;
        private int nota;
        #endregion

        //PROPIEDADES
        #region PROPIEDADES
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
                  if (Nota >=7)
            
                    this.estadoAsignatura = EstadoAsignatura.Aprobado;
                else
                this.estadoAsignatura = EstadoAsignatura.Reprobado;              
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
        #endregion

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

        //METODOS
        #region METODOS
        // TRAE EL METODO DE LA INTERFAZ
        public string TraerAsignaturas()
        {
            return ($"MATERIAS\n manteria 1: {Asignaturas.Ingles}\n" +
                $" manteria 2: {Asignaturas.Programacion}\n" +
                $" manteria 2: {Asignaturas.Matematicas}\n" +
                $" manteria 2: {Asignaturas.Literatura}\n");
        }
        public EstadoAsignatura EstadoAsignatur ()
        {
            return EstadoAsignatura;
           
        }
        #endregion

    }
}
