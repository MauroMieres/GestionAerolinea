using System;
using System.Text.RegularExpressions;
using System.Linq;

namespace Biblioteca
{
    public static class Funciones
    {
        public static DateTime GetFechaRandom(Random generator, DateTime rangeStart, DateTime rangeEnd)
        {
            TimeSpan span = rangeEnd - rangeStart;

            int randomMinutes = generator.Next(0, (int)span.TotalMinutes);
            return rangeStart + TimeSpan.FromMinutes(randomMinutes);
        }

        public static bool ValidarNombresApellidos(string cadena) 
        {
            if (!string.IsNullOrEmpty(cadena)) 
            {
                Regex regex = new Regex(@"^[a-zA-Z]+$");
                return regex.IsMatch(cadena);
            }
            return false;
        }

        public static bool ValidarDni(int dni)
        {
            if(dni >= 1000000 && dni <= 50000000)
                return true;
            return false;
        }

        public static string FormatearNombreApellido(string cadena)
        {
            if (!string.IsNullOrEmpty(cadena)) 
            {
                string nuevaCadena = cadena.First().ToString().ToUpper() + cadena.Substring(1).ToLower();
                return nuevaCadena;
            }
            return "";
        }

        public static bool SonIgualesEstosEnteros(int entero1, int entero2)
        {
            if (entero1 == entero2)
                return true;
            return false;
        }
    }
}
