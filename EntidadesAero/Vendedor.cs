using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EntidadesAero
{
    public class Vendedor : Persona
    {
        string usuario;
        string contraseña;
        public Vendedor(string nombre, string apellido, int dni, int edad, string usuario, string contraseña) : base(nombre, apellido, dni, edad)
        {
            this.usuario = usuario;
            this.contraseña = contraseña;
        }
        public string Usuario { get => usuario; }
        public string Contraseña { get => contraseña; }

        public override string ToString()
        {
            return $"Usuario: {this.Usuario}, Contraseña: {this.Contraseña}";
        }

        public override bool Equals(object obj)
        {
            Vendedor vendedor = obj as Vendedor;
            return vendedor is not null && vendedor == this;
        }

        public override int GetHashCode()
        {
            return this.Usuario.GetHashCode();
        }

        public static bool operator ==(Vendedor v1, Vendedor v2)
        {
            return v1.Usuario == v2.Usuario;
        }

        public static bool operator !=(Vendedor v1, Vendedor v2)
        {
            return !(v1 == v2);
        }
    }
}