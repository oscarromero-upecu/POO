using POO.Enum;
using POO.Interface;
using POO.Metodos;
using System;

namespace POO.Repositorio
{
    public class Estudiante : Asignatura //HEREDA LA CLASE ASIGNATURA
    {
        //CAMPOS
        #region CAMPOS PRIVATE/STATIC/CONST
        //MIEMBRO STATIC PERMITE SER ACCEDIDO EN CUANQUIER MOMENTO DEL PROYECTO SIN 
        //SIN LA NECESIDAD DE UNA INSTANCIA
        public static int IdContador;

        //CONST SE DEBE ESCRIBIR EN MAYUSCULAS Y ASIGNAR UN VALOR
        private const string DEFAULT_NOMBRE = "FRANCISCO PEREZ";
        private const int DEFAULT_EDAD = 19;

        //PRIVATE SON CAMPOS QUE ES SOLO PARA LA CLASE
        private int Id;
        private string nombreEstudiante;
        private int edad;
        private DateTime fechaingreso;
        private Generos generos;
        #endregion

        //PROPIEDADES
        #region PROPIEDADES
        public string NombreEstudiante
        {
            get
            {
                //RETORNA EL CAMPO
                return nombreEstudiante;
            }
            set
            {
                //ASIGNA EL VALOR DEL CAMPO
                this.nombreEstudiante = value;
            }
        }

        public Generos Genero
        {
            get
            {
                //RETORNA 
                return generos;
            }
            set
            {
                //ASIGNA EL VALOR DEL CAMPO
                this.generos = value;
            }
        }
        public int Edad
        {
            get
            {
                return edad;
            }
            set
            {
                //ASIGNA LA EDAD SI CUMPLE LA CONDICION
                if (edad >= 18)
                    this.edad = value;
                else
                    //CASO CONTRARIO QUE ME DE UN MENSAJE DE ERROR EXCEPTION
                    throw new ArgumentOutOfRangeException("El estudiante debe ser mayor de edad");
            }
        }
            public int ID
        {
            get
            {
                return Id;
            }
            //SET PRIVADO QUE SOLO AL MOMENTO DE CREAR ASIGNE VALOR Y
            //QUE EN EL MAIN NO PERMITA MODIFICAR EL VALOR
            private set
            {
                //ASIGNA EL VALOR SI CUMPLE LA CONDICION
                if (Id >= 0)
                    this.Id = value;
                else
                    //CASO CONTRARIO QUE ME DE UN MENSAJE DE ERROR EXCEPTION
                    throw new ArgumentOutOfRangeException("ID incorrecto");
            }
        }
        public DateTime FechaDeIngreso
        {
            get
            {
                return fechaingreso;
            }
            set
            {
                this.fechaingreso = value;
            }
        }
        #endregion

        //CONSTRUCTORES
        #region CONSTRUCTORES

        public Estudiante()
            : this(DEFAULT_NOMBRE, DEFAULT_EDAD)
        { }
        
        public Estudiante(string nombreapellido, int edad)
            :this (nombreapellido,edad,DateTime.Now, Generos.Default, Asignaturas.Default, 9, EstadoAsignatura.Default)
        {
        }

        public Estudiante(string nombreapellido, int edad, DateTime fechaingreso, Generos genero,Asignaturas nombreMateria, int nota, EstadoAsignatura estado)
            //BASE PERMITE ACCEDER AL CONSTRUCTOR PUBLICO DE ASIGNATURA
          : base(Asignaturas.Default, 9, EstadoAsignatura.Default)
        {
            NombreEstudiante = nombreapellido;
            this.edad = edad;
            FechaDeIngreso = fechaingreso;
            IdContador++;
            Genero = genero;
            Asignaturas = nombreMateria;
            Nota = nota;
            EstadoAsignatura = estado;
            ID = IdContador;
        }
        #endregion

        //METODOS
        #region METODOS
        //VIRTUAL ES EL METODO QUE PUEDE SER LLAMADO Y SE PUEDE SOBRESCIBIR
        public virtual void Saludos ()
        {
            Console.WriteLine($"Bienvenido estudiante: {NombreEstudiante}/  edad: {Edad}");
        }
        //METODO STATICO PERMITE SER LLAMADO SIN NECESIDAD DE UNA INSTANCIA; PERO
        //SOLO ACEPTA CAMPOS O PROPIEDADES QUE NO DEPENDAN DE UNA INSTANCIA COMO UNA CONST O STATIC
        // O TAMBIEN TODOS LOS PARAMETOS O ARGUMENTOS QUE SE INCLUYA EN EL METODO
        public static void ImprimirValoresConstantes()
        {
            Console.WriteLine($"Constante de Nombre: {DEFAULT_NOMBRE}"
                + $"Constante de edad: {DEFAULT_EDAD}");
        }
        #endregion

    }
}
