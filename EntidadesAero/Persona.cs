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

        public string Nombre { get => nombre;  }
        public string Apellido { get => apellido; }
        public int Dni { get => dni; }
        public int Edad { get => edad;  }

        //public virtual string MostrarInfo()
        //{
        //    StringBuilder info = new StringBuilder();
        //    info.AppendLine(this.nombre);
        //    info.AppendLine(this.apellido);
        //    info.AppendLine(this.dni.ToString());
        //    info.AppendLine(this.edad.ToString());
        //    return info.ToString();
        //}

        public override string ToString()
        {
            StringBuilder info = new StringBuilder();
            info.AppendLine(this.nombre);
            info.AppendLine(this.apellido);
            info.AppendLine(this.dni.ToString());
            info.AppendLine(this.edad.ToString());
            return info.ToString();
        }

        public override bool Equals(object obj)
        {
            Persona persona = obj as Persona;
            return persona is not null && persona == this;
        }

        public override int GetHashCode()
        {
            return this.dni.GetHashCode();
        }

        public static bool operator ==(Persona p1, Persona p2)
        {
            return p1.dni == p2.dni;
        }

        public static bool operator !=(Persona p1, Persona p2)
        {
            return !(p1 == p2);
        }
    }
}