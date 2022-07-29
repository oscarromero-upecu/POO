using POO.Metodos;
using System;

namespace POO.Repositorio
{
    public class Estudiante
    {
        public static int Id;
        private string nombreapellido;
        private int edad;
        private DateTime fechaingreso;
        private Notas notas;
        private Asignatura asignatura;

        //PROPIEDADES
        #region PROPIEDADES
        public string Nombre
        {
            get
            {
                //RETORNA EL CAMPO
                return nombreapellido;
            }
            set
            {
                //ASIGNA EL VALORE DEL CAMPO
                this.nombreapellido = value;
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
        public Notas Notas
        {
            get
            {
                return notas;
            }
            set
            {
                this.notas = value;
            }
        }
            public Asignatura Asignatura
        {
            get
            {
                return asignatura;
            }
            set
            {
                this.asignatura = value;
            }
        }
        #endregion

        //CONSTRUCTORES
        #region CONSTRUCTORES
        public Estudiante()
            : this("Fernando Perez", 18)
        { }
        
        public Estudiante(string nombreapellido, int edad)
            :this (nombreapellido,edad,DateTime.Now)
        {
        }
        public Estudiante(string nombreapellido, int edad, DateTime fechaingreso)
        {
            Nombre = nombreapellido;
            this.edad = edad;
            FechaDeIngreso = fechaingreso;
            Notas = new Notas();
            Asignatura = new Asignatura();
        }
        #endregion
        //METODOS
        #region METODOS
        public void Saludos (string nombre)
        {
            Console.WriteLine($"Bienvenido estudiante{nombre} edad: {Edad}");
        }
        #endregion

    }
}
