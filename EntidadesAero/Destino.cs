using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace EntidadesAero
{
    public enum ETipoDestino
    {
        Internacional,
        Nacional
    }
    
    public class Destino
    {
        ETipoDestino tipoDestino;
        string nombre;
        decimal facturacion;
        int cantidadDeVecesElegido;

        public Destino(ETipoDestino tipoDestino, string nombre)
        {
            this.tipoDestino = tipoDestino;
            this.nombre = nombre;
            this.cantidadDeVecesElegido = 0;
        }

        public ETipoDestino TipoDestino { get => tipoDestino;  }
        public string Nombre { get => nombre;  }
        public decimal Facturacion { get => facturacion; set => facturacion = value; }
        [DisplayName("Vuelos")]
        public int CantidadDeVecesElegido { get => cantidadDeVecesElegido; set => cantidadDeVecesElegido = value; }

        public override string ToString()
        {
            StringBuilder info = new StringBuilder();
            info.AppendLine("Tipo destino: " + this.TipoDestino.ToString());
            info.AppendLine("Destino: " + this.Nombre);
            info.AppendLine("Facturacion: " + this.Facturacion);
            info.AppendLine("cantidadDeVecesElegido: " + this.CantidadDeVecesElegido);
            return info.ToString();
        }

        public override bool Equals(object obj)
        {
            Destino destino = obj as Destino;
            return destino is not null && destino == this;
        }

        public override int GetHashCode()
        {
            return this.Nombre.GetHashCode();
        }

        public static bool operator ==(Destino d1, Destino d2)
        {
            return d1.Nombre == d2.Nombre;
        }

        public static bool operator !=(Destino d1, Destino d2)
        {
            return !(d1 == d2);
        }
    }
}