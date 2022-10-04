using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EntidadesAero
{
    public class Pasaje
    {
        Vuelo vuelo;
        decimal precio;
        string codigoVuelo;

        public Vuelo Vuelo { get => vuelo; set => vuelo = value; }
        public decimal Precio { get => precio; set => precio = value; }
        public string CodigoVuelo { get => codigoVuelo; set => codigoVuelo = value; }

        public Pasaje(Vuelo vuelo, decimal precio, string codigoVuelo)
        {
            this.precio = precio;
            this.vuelo = vuelo;
            this.codigoVuelo = codigoVuelo;
        }

        public Pasaje(Vuelo vuelo)
        {
            this.vuelo = vuelo;
        }

        public decimal CalcularPrecioPasaje(Vuelo vuelo, ETipoPasajero tipoPasajero)
        {
            float horasVuelo = (float)(vuelo.HoraLlegada - vuelo.HoraSalida).TotalHours;
            decimal precioPasaje = 0;
            switch (vuelo.Destino.TipoDestino)
            {
                case ETipoDestino.Nacional:
                    switch (tipoPasajero)
                    {
                        case ETipoPasajero.Turista:
                            precioPasaje = (decimal)(horasVuelo * 50 * 1.5);
                            break;
                        case ETipoPasajero.Premium:
                            precioPasaje = (decimal)(horasVuelo * 100 * 1.5);
                            break;
                    }
                    break;

                case ETipoDestino.Internacional:
                    switch (tipoPasajero)
                    {
                        case ETipoPasajero.Turista:
                            precioPasaje = (decimal)(horasVuelo * 100 * 1.5);
                            break;
                        case ETipoPasajero.Premium:
                            precioPasaje = (decimal)(horasVuelo * 150 * 1.5);
                            break;
                    }
                    break;
            }
            return precioPasaje;
        }
    }
}