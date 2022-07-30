using POO.Enum;
using POO.Repositorio;
using System;

namespace POO.Metodos
{
    public class Curso: Estudiante
    {
        //CAMPOS
        #region CAMPOS
        private int nivelcurso;
        private Paralelos paralelos;
        #endregion

        //PROPIEDADES
        #region PROPIEDADES
        public int Nivelcurso
        {
            get
            {
                return nivelcurso;
            }
            set
            {
                //ASIGNA SI CUMPLE LA CONDICION
                if (nivelcurso <= 2)
                    this.nivelcurso = value;
                else
                    //CASO CONTRARIO QUE ME DE UN MENSAJE DE ERROR EXCEPTION
                    throw new ArgumentOutOfRangeException("Solo existen 2 niveles del curso");
            }
        }
        public Paralelos Paralelos
        {
            get
            {
                return paralelos;
            }
            set
            {
                this.paralelos = value;
            }
        }
        #endregion

        //CONSTRUCTORES
        #region CONSTRUCTORES
        public Curso()
        { }

        public Curso(Paralelos paralelos, int nivelCurso)
            //BASE PERMITE ACCEDER AL CONSTRUCTOR PUBLICO DE ESTUDIANTE
            : base("Oscar Romero", 18,DateTime.Now,Generos.Default,Asignaturas.Default,7,EstadoAsignatura.Aprobado)
        {
            this.paralelos = paralelos;
            Nivelcurso=nivelCurso;

        }

        #endregion

        //METODOS
        #region METODOS
        // TRAE EL METODO DE LA INTERFAZ
        public string ImprimirCurso()
        {
            return ($"Te da la bienvenida \n" +
                $" Paralelo: {Paralelos.C}" +
               $" Nivel: {Nivelcurso}");
        }
        //OVERRRIDE PERMITE ACCEDER AL METODO QUE SE HEREDA Y PUEDE SUBCRIBISE
        public override void Saludos()
        {
           Console.WriteLine($"Hola te saluda el curso:\n {Paralelos.C}/  Nivel: {Nivelcurso}");
        }
        #endregion
    }
}
