using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace EntidadesAero
{
    public class Cliente : Persona
    {
        List<Vuelo> vuelosRealizados;
        int cantidadVuelosRealizados;
        public Cliente(string nombre, string apellido, int dni, int edad) : base(nombre, apellido, dni, edad)
        {
            this.vuelosRealizados = new List<Vuelo>();
            this.cantidadVuelosRealizados = 0;
        }

        public List<Vuelo> VuelosRealizados { get => vuelosRealizados; set => vuelosRealizados = value; }
        [DisplayName("Vuelos realizados")]
        public int CantidadVuelosRealizados { get => cantidadVuelosRealizados; set => cantidadVuelosRealizados = value; }

        public override string ToString()
        {
            return $"Cantidad de vuelos realizados: {this.CantidadVuelosRealizados}";
        }

        public override bool Equals(object obj)
        {
            Cliente cliente = obj as Cliente;
            return cliente is not null && cliente == this;
        }

        public override int GetHashCode()
        {
            return this.Dni.GetHashCode();
        }

        public static bool operator ==(Cliente c1, Cliente c2)
        {
            return c1.Dni == c2.Dni;
        }

        public static bool operator !=(Cliente d1, Cliente d2)
        {
            return !(d1 == d2);
        }
    }
}