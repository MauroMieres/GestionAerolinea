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
    }
}