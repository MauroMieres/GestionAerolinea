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


        public string GetPrecioImpuestosExplicado(Pasaje pasaje, ETipoPasajero tipoPasajero)
        {
            StringBuilder precio = new StringBuilder();
            ETipoDestino tipoDestino = pasaje.vuelo.Destino.TipoDestino;

            var hours = (pasaje.vuelo.HoraLlegada - pasaje.vuelo.HoraSalida).TotalHours;
            decimal precioBruto = 0;
            switch (tipoPasajero)
            {
                case ETipoPasajero.Turista:
                    switch (tipoDestino)
                    {
                        case ETipoDestino.Nacional:
                            precioBruto = (decimal)(hours * 50);
                            precio.AppendLine($"clase turista, destino nacional: {precioBruto}");
                             break;

                        case ETipoDestino.Internacional:
                            precioBruto = (decimal)(hours * 100);
                            precio.AppendLine($"clase turista, destino internacional: {precioBruto}");
                            break;
                    }
                    break;

                case ETipoPasajero.Premium:
                    switch (tipoDestino)
                    {
                        case ETipoDestino.Nacional:
                            precioBruto = (decimal)(hours * 57.5);
                            precio.AppendLine($"clase premium, destino nacional: {precioBruto}");
                            break;

                        case ETipoDestino.Internacional:
                            precioBruto = (decimal)(hours * 115);
                            precio.AppendLine($"clase premium, destino internacional: {precioBruto}");
                            break;
                    }
                    break;
            }

            decimal percepcionRG4815 = precioBruto * (decimal)0.35;
            precio.AppendLine($"Percepción RG4815 (%35): {percepcionRG4815}");

            decimal impuestoPais = precioBruto * (decimal)0.55;
            precio.AppendLine($"Impuesto Pais  (%45): {impuestoPais}");

            decimal tasas = precioBruto * (decimal)0.58;
            precio.AppendLine($"Tasas (%42): {tasas}");

            decimal totalNeto = CalcularPrecioPasaje(vuelo,tipoPasajero);

            precio.AppendLine($"Total neto: {totalNeto}");

            return precio.ToString();
        }
            

        public decimal CalcularPrecioPasaje(Vuelo vuelo, ETipoPasajero tipoPasajero)
        {
            float horasVuelo = (float)(vuelo.HoraLlegada - vuelo.HoraSalida).TotalHours;
            decimal precioPasaje = 0;
            decimal impuestoPais;
            decimal impuestoPercepcion;
            decimal impuestosCargos;

            switch (vuelo.Destino.TipoDestino)
            {
                case ETipoDestino.Nacional:
                    switch (tipoPasajero)
                    {
                        case ETipoPasajero.Turista:
                            precioPasaje = (decimal)(horasVuelo * 50);
                            impuestoPais = precioPasaje * (decimal)0.55;
                            impuestoPercepcion=    precioPasaje * (decimal)0.35;
                            impuestosCargos =       precioPasaje * (decimal)0.58;
                            precioPasaje = precioPasaje + impuestoPais + impuestoPercepcion + impuestosCargos;
                            break;
                        case ETipoPasajero.Premium:
                            precioPasaje = (decimal)(horasVuelo * 57.5);
                            impuestoPais = precioPasaje * (decimal)0.55;
                            impuestoPercepcion = precioPasaje * (decimal)0.35;
                            impuestosCargos = precioPasaje * (decimal)0.58;
                            precioPasaje = precioPasaje + impuestoPais + impuestoPercepcion + impuestosCargos;
                            break;
                    }
                    break;

                case ETipoDestino.Internacional:
                    switch (tipoPasajero)
                    {
                        case ETipoPasajero.Turista:
                            precioPasaje = (decimal)(horasVuelo * 100);
                            impuestoPais = precioPasaje * (decimal)0.55;
                            impuestoPercepcion = precioPasaje * (decimal)0.35;
                            impuestosCargos = precioPasaje * (decimal)0.58;
                            precioPasaje = precioPasaje + impuestoPais + impuestoPercepcion + impuestosCargos;
                            break;
                        case ETipoPasajero.Premium:
                            precioPasaje = (decimal)(horasVuelo * 115);
                            impuestoPais = precioPasaje * (decimal)0.55;
                            impuestoPercepcion = precioPasaje * (decimal)0.35;
                            impuestosCargos = precioPasaje * (decimal)0.58;
                            precioPasaje = precioPasaje + impuestoPais + impuestoPercepcion + impuestosCargos;
                            break;
                    }
                    break;
            }
            return precioPasaje;
        }

        public override string ToString()
        {
            StringBuilder info = new StringBuilder();
            info.AppendLine("Codigo vuelo: " + this.CodigoVuelo);
            info.AppendLine("Precio: " + this.Precio);
            return info.ToString();
        }

        public override bool Equals(object obj)
        {
            Pasaje pasaje = obj as Pasaje;
            return pasaje is not null && pasaje == this;
        }

        public override int GetHashCode()
        {
            return this.Precio.GetHashCode();
        }

        public static bool operator ==(Pasaje p1, Pasaje p2)
        {
            return p1.Precio == p2.Precio && p1.vuelo == p2.vuelo;
        }

        public static bool operator !=(Pasaje p1, Pasaje p2)
        {
            return !(p1 == p2);
        }
    }
}