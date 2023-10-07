using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Calculadora.Services
{
    public class ValidaString
    {
        public int ContarCaracteres(string texto)
        {
            int numero = texto.Length;
            return numero;
        }

        public string PegarPrimeiraLetra(string texto)
        {
            string letra = texto.Substring(0, 1);
            return letra;
        }

        public string DeixarMaiusculo(string texto)
        {
            string textoMaiusculo = texto.ToUpper();
            return textoMaiusculo;
        }

        public string DeixarMinusculo(string texto)
        {
            string textoMinusculo = texto.ToLower();
            return textoMinusculo;
        }
    }
}