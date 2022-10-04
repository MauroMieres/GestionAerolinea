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
        public string Usuario { get => usuario; set => usuario = value; }
        public string Contraseña { get => contraseña; set => contraseña = value; }
    }
}