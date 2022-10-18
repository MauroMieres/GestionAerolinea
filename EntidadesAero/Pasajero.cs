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
        public Pasajero(string nombre, string apellido, int dni, int edad, Pasaje pasaje, ETipoPasajero tipoPasajero) : base(nombre, apellido, dni, edad)
        {
            this.pasaje = pasaje;
            this.tipoPasajero = tipoPasajero;
        }

        public Pasaje Pasaje { get => pasaje;  }
        [DisplayName("Tipo de Pasajero")]
        public ETipoPasajero TipoPasajero { get => tipoPasajero;  }

        public override string ToString()
        {
            StringBuilder info = new StringBuilder();
            info.AppendLine("Codigo vuelo: "+this.Pasaje.CodigoVuelo);
            info.AppendLine("Hora salida: " +this.Pasaje.Vuelo.HoraSalida.ToShortTimeString());
            info.AppendLine("Hora llegada: " + this.Pasaje.Vuelo.HoraLlegada.ToShortTimeString());
            info.AppendLine("Destino: " + this.Pasaje.Vuelo.DestinoS);
            info.AppendLine("Origen: " + this.Pasaje.Vuelo.OrigenS);
            info.AppendLine("Tipo de pasajero: "+this.TipoPasajero.ToString());
            info.AppendLine("Apellido: "+this.Apellido);
            info.AppendLine("Nombre: " + this.Nombre);
            info.AppendLine("Dni: " + this.Dni);
            info.AppendLine("Edad: " + this.Edad);
            return info.ToString();
        }

        public override bool Equals(object obj)
        {
            Pasajero pasajero = obj as Pasajero;
            return pasajero is not null && pasajero == this;
        }

        public override int GetHashCode()
        {
            return this.Dni.GetHashCode();
        }

        public static bool operator ==(Pasajero p1, Pasajero p2)
        {
            return p1.Dni == p2.Dni;
        }

        public static bool operator !=(Pasajero p1, Pasajero p2)
        {
            return !(p1 == p2);
        }
    }
}