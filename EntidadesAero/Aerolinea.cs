using System;
using EntidadesAero;
using System.Collections.Generic;

namespace EntidadesAero
{
    public static class Aerolinea
    {
        static List<Aeronave> listaAeronaves;
        static List<Cliente> listaClientes;
        static List<Destino> listaDestinos;
        static List<Vuelo> listaVuelos;
      //  static List<Vendedor> listaVendedores;
        static Dictionary<int, Vendedor> listaVendedorD;
        

        public static List<Aeronave> ListaAeronaves { get => listaAeronaves; set => listaAeronaves = value; }
        public static List<Cliente> ListaClientes { get => listaClientes; set => listaClientes = value; }
        public static List<Destino> ListaDestinos { get => listaDestinos; set => listaDestinos = value; }
        public static List<Vuelo> ListaVuelos { get => listaVuelos; set => listaVuelos = value; }
       // public static List<Vendedor> ListaVendedores { get => listaVendedores; set => listaVendedores = value; }
        public static Dictionary<int, Vendedor> ListaVendedorD { get => listaVendedorD; set => listaVendedorD = value; }

        static Aerolinea()
        {
            listaAeronaves = Aerolinea.GenerarAeronaves();
            listaDestinos = Aerolinea.GenerarDestinos();
           // listaVendedores = Aerolinea.GenerarVendores();
            listaClientes = Aerolinea.GenerarClientes();
            listaVuelos = Aerolinea.GenerarVuelos();
            listaVendedorD = Aerolinea.GenerarVendoresD();
        }

        public static Vendedor UsuarioExistente(string txt_user, string txt_password)
        {
            foreach (KeyValuePair<int, Vendedor> vendedor in ListaVendedorD)
            {
                if (vendedor.Value.Usuario == txt_user && vendedor.Value.Contraseña == txt_password)
                {
                    return vendedor.Value;
                }
            }
            return null;
        }

        public static List<Vuelo> GenerarVuelos()
        {
            List<Vuelo> aux = new List<Vuelo>();

            List<Destino> auxD = Aerolinea.listaDestinos;
            List<Aeronave> auxA = Aerolinea.listaAeronaves;
            List<Cliente> auxC = Aerolinea.listaClientes;

            List<Pasajero> listaUniversal = new List<Pasajero>();

            DateTime horaSalidaAux = DateTime.Now.AddHours(20);

            DateTime horaSalida1 = DateTime.Now.AddHours(-20);
            DateTime horaSalida2 = DateTime.Now.AddHours(1);
            DateTime horaSalida3 = DateTime.Now.AddHours(-6);


            Vuelo auxVuelo1 = new Vuelo(auxD[0], horaSalidaAux, auxD[2], auxA[1], listaUniversal, true, true);

            Pasaje auxPasaje = new Pasaje(auxVuelo1, 200000, auxVuelo1.CodigoVuelo);

            listaUniversal.Add(new Pasajero("Mauro", "Mieres", 41209897, 24, auxPasaje));
            listaUniversal.Add(new Pasajero("Lucas", "Avalos", 41209777, 21, auxPasaje));

            List<Pasajero> listaVuelo3 = new List<Pasajero>();
            listaVuelo3.Add(new Pasajero("Ulises", "Mieres", 22222222, 50, auxPasaje));

            List<Pasajero> auxListaP1 = listaUniversal;
            List<Pasajero> auxListaP2 = listaUniversal;
            List<Pasajero> auxListaP3 = listaUniversal;

           

            Vuelo auxVuelo2 = new Vuelo(auxD[1], horaSalida1, auxD[3], auxA[0], auxListaP1, false, true);
            Vuelo auxVuelo3 = new Vuelo(auxD[2], horaSalida2, auxD[4], auxA[1], auxListaP2, false, true);
            Vuelo auxVuelo4 = new Vuelo(auxD[17], horaSalida3, auxD[0], auxA[2], listaVuelo3, true, false);

            aux.Add(auxVuelo2);
            aux.Add(auxVuelo3);
            aux.Add(auxVuelo4);

            return aux;
        }

        public static bool ClienteExistente(Cliente auxCliente)
        {
            foreach (Cliente cliente in Aerolinea.ListaClientes)
            {
                if (cliente.Dni == auxCliente.Dni)
                {
                    return true;
                }
            }
            return false;
        }

        public static void AñadirCliente(Cliente cliente)
        {
            Aerolinea.listaClientes.Add(cliente);
        }

        public static List<Aeronave> GenerarAeronaves()
        {
            List<Aeronave> aux = new List<Aeronave>();
            aux.Add(new Aeronave("LV-YQF", 100, 2, 50000, true));
            aux.Add(new Aeronave("LV-MNM", 70, 3, 50000, true));
            aux.Add(new Aeronave("LV-LFA", 50, 2, 50000, true));
            aux.Add(new Aeronave("LV-GAK", 80, 3, 50000, true));
            aux.Add(new Aeronave("LV-MAU", 90, 2, 50000, true));
            aux.Add(new Aeronave("LV-HKN", 120, 2, 50000, true));
            aux.Add(new Aeronave("LV-ACK", 150, 4, 50000, true));
            return aux;
        }

        public static List<Cliente> GenerarClientes()
        {
            List<Cliente> aux = new List<Cliente>();
            aux.Add(new Cliente("Mauro", "Mieres", 41209897, 24));
            aux.Add(new Cliente("Lucas", "Avalos", 41209777, 21));
            aux.Add(new Cliente("Gladys", "Knofler", 24093426, 48));
            aux.Add(new Cliente("Ulises", "Mieres", 24093777, 50));
            return aux;
        }

        public static List<Destino> GenerarDestinos()
        {
            List<Destino> aux = new List<Destino>();
            aux.Add(new Destino(ETipoDestino.Nacional, "Buenos Aires"));
            aux.Add(new Destino(ETipoDestino.Nacional, "Santa Rosa"));
            aux.Add(new Destino(ETipoDestino.Nacional, "Bariloche"));
            aux.Add(new Destino(ETipoDestino.Nacional, "Corrientes"));
            aux.Add(new Destino(ETipoDestino.Nacional, "Cordoba"));
            aux.Add(new Destino(ETipoDestino.Nacional, "Jujuy"));
            aux.Add(new Destino(ETipoDestino.Nacional, "Mendoza"));
            aux.Add(new Destino(ETipoDestino.Nacional, "Neuquen"));
            aux.Add(new Destino(ETipoDestino.Nacional, "Posadas"));
            aux.Add(new Destino(ETipoDestino.Nacional, "Iguazu"));
            aux.Add(new Destino(ETipoDestino.Nacional, "Salta"));
            aux.Add(new Destino(ETipoDestino.Nacional, "Santiago Del Estero"));
            aux.Add(new Destino(ETipoDestino.Nacional, "Tucuman"));
            aux.Add(new Destino(ETipoDestino.Nacional, "Puerto Madryn"));
            aux.Add(new Destino(ETipoDestino.Nacional, "Ushuaia"));
            aux.Add(new Destino(ETipoDestino.Internacional, "Recife"));
            aux.Add(new Destino(ETipoDestino.Internacional, "Roma"));
            aux.Add(new Destino(ETipoDestino.Internacional, "Acapulco"));
            aux.Add(new Destino(ETipoDestino.Internacional, "Miami"));
            return aux;
        }

        //public static List<Vendedor> GenerarVendores()
        //{
        //    List<Vendedor> aux = new List<Vendedor>();
        //    aux.Add(new Vendedor("Mauro", "Mieres", 24093426, 24, "mauro", "1234"));
        //    return aux;
        //}

        public static Dictionary<int, Vendedor> GenerarVendoresD()
        {
            Dictionary<int, Vendedor> auxD = new Dictionary<int, Vendedor>();
            auxD.Add(1, new Vendedor("Mauro", "Mieres", 24093426, 24, "mauro", "1234"));
            return auxD;
        }

        
    }
}
