using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace EntidadesAero
{

    public enum ETipoPasajero
    {
        Turista,
        Premium
    }
    public class Vuelo
    {
        Destino destino;
        DateTime horaSalida;
        Destino origen;
        DateTime horaLlegada;
        Aeronave aeronave;
        List<Pasajero> listaPasajeros = new List<Pasajero>();
        int asientosPremiumDisponibles;
        int asientosTuristaDisponibles;
        bool tieneWifi;
        bool tieneComida;
        string codigoVuelo;
        string estadoVuelo;
        int cantidadDeBanios;
        float recaudacion;

        public Vuelo(Destino destino, DateTime horaSalida, Destino origen, Aeronave aeronave, List<Pasajero> listaPasajeros, bool tieneWifi, bool tieneComida) : this(destino, horaSalida, origen, aeronave, tieneWifi, tieneComida)
        {
            
            this.listaPasajeros = listaPasajeros;
            CargarPasajerosHardcodeados();
            this.aeronave.HorasDeVuelo = 0;
            this.destino.CantidadDeVecesElegido = 0;
            if (this.estadoVuelo == "Aterrizado")
            {
                this.aeronave.EstaDisponible = true;
                this.recaudacion = CalcularRecaudacionVuelo();
                this.AgregarHorasDeVueloAlAeronave();
                this.AgregarRecaudacionAlDestino();
                this.destino.CantidadDeVecesElegido++;
                foreach (Pasajero pasajero in this.listaPasajeros)
                {
                    foreach (Cliente cliente in Aerolinea.ListaClientes)
                    {
                        if (pasajero.Dni == cliente.Dni)
                        {
                            cliente.CantidadVuelosRealizados++;
                        }
                    }
                }

            }
        }


        public Vuelo(Destino destino, DateTime horaSalida, Destino origen, Aeronave aeronave, bool tieneWifi, bool tieneComida)
        {
            this.destino = destino;
            this.horaSalida = horaSalida;
            this.origen = origen;
            this.aeronave = aeronave;
            this.tieneWifi = tieneWifi;
            this.tieneComida = tieneComida;
            this.listaPasajeros = new List<Pasajero>();

           
           CalcularLlegadaSalida();

            this.asientosPremiumDisponibles = aeronave.AsientosPremium;
            this.asientosTuristaDisponibles = aeronave.AsientosTurista;

            this.codigoVuelo = GenerarCodigoAlfanumerico(8);
            this.estadoVuelo = DeterminarEstadoVuelo();
            this.aeronave.EstaDisponible = false;
            this.recaudacion = 0;
            this.cantidadDeBanios = aeronave.CantidadBanios;
        }

        public override bool Equals(object obj)
        {
            Vuelo vuelo = obj as Vuelo;
             return vuelo is not null && vuelo==this;
        }

        public override int GetHashCode()
        {
            return this.codigoVuelo.GetHashCode();
        }

        public static bool operator ==(Vuelo v1, Vuelo v2)
        {
            return v1.codigoVuelo == v2.codigoVuelo;
        }

        public static bool operator !=(Vuelo v1, Vuelo v2)
        {
            return !(v1 == v2);
        }

        //public List<Pasajero> ListaPasajeros { get => listaPasajeros; set => listaPasajeros = value; }
        public Destino Destino { get => destino; set => destino = value; }
        [DisplayName("Destino")]
        public string DestinoS { get => Destino.Nombre; }
        [DisplayName("Salida")]
        public DateTime HoraSalida { get => horaSalida; set => horaSalida = value; }
        public Destino Origen { get => origen; set => origen = value; }
        [DisplayName("Origen")]
        public string OrigenS { get => Origen.Nombre; }
        [DisplayName("Llegada")]
        public DateTime HoraLlegada { get => horaLlegada; set => horaLlegada = value; }
        public Aeronave Aeronave { get => aeronave; set => aeronave = value; }
        public List<Pasajero> ListaPasajeros { get => listaPasajeros; set => listaPasajeros = value; }
        [DisplayName("Wifi")]
        public bool TieneWifi { get => tieneWifi; set => tieneWifi = value; }
        [DisplayName("Comida")]
        public bool TieneComida { get => tieneComida; set => tieneComida = value; }
        [DisplayName("Codigo de Vuelo")]
        public string CodigoVuelo { get => codigoVuelo; set => codigoVuelo = value; }
        [DisplayName("Asientos Turista Disponibles")]
        public int AsientosTuristaDisponibles { get => asientosTuristaDisponibles; set => asientosTuristaDisponibles = value; }
        [DisplayName("Asientos Premium Disponibles")]
        public int AsientosPremiumDisponibles { get => asientosPremiumDisponibles; set => asientosPremiumDisponibles = value; }
        [DisplayName("Estado del Vuelo")]
        public string EstadoVuelo { get => estadoVuelo; set => estadoVuelo = value; }
        public float Recaudacion { get => recaudacion; set => recaudacion = value; }
        public string MatriculaAeronave { get => this.aeronave.Matricula; }
        [DisplayName("Baños")]
        public int CantidadDeBanios { get => cantidadDeBanios;}

        public void AgregarHorasDeVueloAlAeronave()
        {
                this.aeronave.HorasDeVuelo += (float)(this.horaLlegada - this.horaSalida).TotalHours;
        }

        public void AgregarRecaudacionAlDestino()
        {
            this.destino.Facturacion += (decimal)this.CalcularRecaudacionVuelo();
        }

        public void EstadoAeronave()
        {
            // < 0 − If date1 is earlier than date2
            //0 − If date1 is the same as date2
            //> 0 − If date1 is later than date2
            //    public static int Compare(DateTime d1, DateTime d2);
            if (DateTime.Compare(this.horaLlegada, DateTime.Now) < 0)
            {
                this.aeronave.EstaDisponible = true;
            }

            if (DateTime.Compare(this.HoraLlegada, DateTime.Now) > 0)
            {
                this.aeronave.EstaDisponible = false;
            }
        }

        public void AsignarAsientoPasajero(Pasajero pasajero)
        {

            switch (pasajero.TipoPasajero)
            {
                case ETipoPasajero.Turista:
                    this.asientosTuristaDisponibles--;
                    break;

                case ETipoPasajero.Premium:
                    this.asientosPremiumDisponibles--;
                    break;
            }           
        }

        public bool CalcularLlegadaSalida()
        {
            Random random = new Random();
            if (this.Destino.TipoDestino == ETipoDestino.Nacional)
            {
                int horas = random.Next(2, 4);
                this.horaLlegada = this.HoraSalida.AddHours(horas);
                this.horaSalida = this.horaSalida.AddHours(-(horas));
                return true;
            }
            else
            {
                int horas = random.Next(8, 12);
                this.horaLlegada = this.HoraSalida.AddHours(horas);
                this.horaSalida = this.horaSalida.AddHours(-(horas));
                return true;
            }
        }

        public void CargarPasajerosHardcodeados()
        {
            foreach (Pasajero pasajero in this.listaPasajeros)
            {
                if (pasajero.TipoPasajero == ETipoPasajero.Turista)
                    this.asientosTuristaDisponibles--;
                else
                    this.asientosPremiumDisponibles--;
            }
        }

        public string DeterminarEstadoVuelo()
        {
            if (DateTime.Compare(this.horaLlegada, DateTime.Now) < 0)
            {
                this.aeronave.EstaDisponible = true;
                this.AgregarHorasDeVueloAlAeronave();
                this.recaudacion = CalcularRecaudacionVuelo();
                this.destino.Facturacion += (decimal)(CalcularRecaudacionVuelo());
                return "Aterrizado";
            }

            if (DateTime.Compare(this.horaSalida, DateTime.Now.AddMinutes(-5)) < 0)
            {
                this.aeronave.EstaDisponible = false;
                return "Volando";
            }

            else
            {
                this.aeronave.EstaDisponible = false;
                return "En tierra";
            }
        }

        public float CalcularRecaudacionVuelo()
        {
            float recaudacion = 0;

            float hours = (float)(this.horaLlegada - this.horaSalida).TotalHours;
            foreach (Pasajero pasajero in this.listaPasajeros)
            {
                if (this.destino.TipoDestino == ETipoDestino.Nacional)
                {
                    if (pasajero.TipoPasajero == ETipoPasajero.Turista)
                        recaudacion += (float)(hours * 50 * 1.5);
                    else
                        recaudacion += (float)(hours * 75 * 1.5);
                }

                if (this.destino.TipoDestino == ETipoDestino.Internacional)
                {
                    if (pasajero.TipoPasajero == ETipoPasajero.Turista)
                        recaudacion += (float)(hours * 100 * 1.5);
                    else
                        recaudacion += (float)(hours * 150 * 1.5);
                }
            }
            return recaudacion;
        }

        public static string GenerarCodigoAlfanumerico(int cantidadCaracteres)
        {
            var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            var caracteres = new char[cantidadCaracteres];
            Random random = new Random();

            for (int i = 0; i < caracteres.Length; i++)
            {
                caracteres[i] = chars[random.Next(chars.Length)];
            }

            var finalString = new String(caracteres);
            return finalString;
        }
    }
}