using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EntidadesAero
{
    public class Aeronave
    {
        string matricula;
        int asientosTurista;
        int asientosPremium;
        short cantidadBanios;
        int capacidadBodega;
        bool estaDisponible;
        float horasDeVuelo = 0;

        public Aeronave(string matricula, short cantidadAsientos,
            short cantidadBanios, int capacidadBodega, bool estaDisp)
        {
            this.matricula = matricula;
            this.cantidadBanios = cantidadBanios;
            this.capacidadBodega = capacidadBodega;
            this.asientosTurista = (int)(cantidadAsientos * 0.8);
            this.asientosPremium = (int)(cantidadAsientos * 0.2);
            this.estaDisponible = estaDisp;
        }


        public string Matricula { get => matricula; set => matricula = value; }
        public int AsientosTurista { get => asientosTurista; set => asientosTurista = value; }
        public int AsientosPremium { get => asientosPremium; set => asientosPremium = value; }
        public short CantidadBanios { get => cantidadBanios; }
        public int CapacidadBodega { get => capacidadBodega; }
        public bool EstaDisponible { get => estaDisponible; set => estaDisponible = value; }
        public float HorasDeVuelo { get => horasDeVuelo; set => horasDeVuelo = value; }

        public override string ToString()
        {
            StringBuilder info = new StringBuilder();
            info.AppendLine("Matricula: " + this.matricula);
            info.AppendLine("AsientosTurista: " + this.AsientosTurista);
            info.AppendLine("AsientosPremium: " + this.AsientosPremium);
            info.AppendLine("CantidadBanios: " + this.CantidadBanios);
            info.AppendLine("CapacidadBodega: " + this.CapacidadBodega);
            info.AppendLine("EstaDisponible: " + this.EstaDisponible.ToString());
            info.AppendLine("HorasDeVuelo: " + this.HorasDeVuelo);
            return info.ToString();
        }

        public override bool Equals(object obj)
        {
            Aeronave aeronave = obj as Aeronave;
            return aeronave is not null && aeronave == this;
        }

        public override int GetHashCode()
        {
            return this.matricula.GetHashCode();
        }

        public static bool operator ==(Aeronave a1, Aeronave a2)
        {
            return a1.matricula == a2.matricula;
        }

        public static bool operator !=(Aeronave a1, Aeronave a2)
        {
            return !(a1 == a2);
        }
    }
}