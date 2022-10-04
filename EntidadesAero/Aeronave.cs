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

        //public string VerInformacionAeronave()

        public string Matricula { get => matricula; set => matricula = value; }
        public int AsientosTurista { get => asientosTurista; set => asientosTurista = value; }
        public int AsientosPremium { get => asientosPremium; set => asientosPremium = value; }
        public short CantidadBanios { get => cantidadBanios; set => cantidadBanios = value; }
        public int CapacidadBodega { get => capacidadBodega; set => capacidadBodega = value; }
        public bool EstaDisponible { get => estaDisponible; set => estaDisponible = value; }
        public float HorasDeVuelo { get => horasDeVuelo; set => horasDeVuelo = value; }
    }
}