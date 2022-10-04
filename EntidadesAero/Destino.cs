using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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

        public ETipoDestino TipoDestino { get => tipoDestino; set => tipoDestino = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public decimal Facturacion { get => facturacion; set => facturacion = value; }
        public int CantidadDeVecesElegido { get => cantidadDeVecesElegido; set => cantidadDeVecesElegido = value; }
    }
}