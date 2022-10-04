using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace EntidadesAero
{
    public class Pasajero : Cliente
    {
        Pasaje pasaje;
        ETipoPasajero tipoPasajero;
        public Pasajero(string nombre, string apellido, int dni, int edad, Pasaje pasaje) : base(nombre, apellido, dni, edad)
        {
            this.pasaje = pasaje;
        }

        public Pasaje Pasaje { get => pasaje; set => pasaje = value; }
        [DisplayName("Tipo de Pasajero")]
        public ETipoPasajero TipoPasajero { get => tipoPasajero; set => tipoPasajero = value; }
    }
}