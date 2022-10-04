using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EntidadesAero
{
    public abstract class Persona
    {
        string nombre;
        string apellido;
        int dni;
        int edad;

        public Persona(string nombre, string apellido, int dni, int edad)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.dni = dni;
            this.edad = edad;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public int Dni { get => dni; set => dni = value; }
        public int Edad { get => edad; set => edad = value; }

        public virtual string MostrarInfo()
        {
            StringBuilder info = new StringBuilder();
            info.AppendLine(this.nombre);
            info.AppendLine(this.apellido);
            info.AppendLine(this.dni.ToString());
            info.AppendLine(this.edad.ToString());
            return info.ToString();
        }
    }
}