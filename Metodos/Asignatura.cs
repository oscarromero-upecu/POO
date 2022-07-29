using POO.Interface;

namespace POO.Repositorio
{
    public class Asignatura : IAsignatura
    {
        private string nombremateria;
        private string estadomateria;

        public string NombreMateria
        {
            get
            {
                return nombremateria;
            }
            set
            {
                this.nombremateria = value;
            }
        }
        public string EstadoMateria
        {
            get
            {
                return estadomateria;
            }
            set
            {
                this.estadomateria = value;
            }
        }

        public Asignatura()
        {
            NombreMateria = "Ingles";
        }

        public string IngresarAsignatura(string Asignatura)
        {
            return NombreMateria = Asignatura;
        }
        
        public string EstadoAsignatura(int nota)
        {
            if (nota >= 7)
            {
                EstadoMateria = "APROBADO";
            }
             else EstadoMateria= "REPROBADO";
            return EstadoMateria;
         }
    }
}
