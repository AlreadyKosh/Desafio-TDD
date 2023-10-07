using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Calculadora.Services
{
    public class CalculadoraImplemetacao
    {
        private List<string> listaHistorico;

        public CalculadoraImplemetacao()
        {
            listaHistorico = new List<string>();
        }

        public int Somar(int num1, int num2)
        {
            int resultado = num1 + num2;
            listaHistorico.Insert(0, $"Resultado: {resultado}");
            return resultado;
        }

        public int Subtrair(int num1, int num2)
        {
            int resultado = num1 - num2;
            listaHistorico.Insert(0, $"Resultado: {resultado}");
            return resultado;
        }

        public int Dividir(int num1, int num2)
        {
            int resultado = num1 / num2;
            listaHistorico.Insert(0, $"Resultado: {resultado}");
            return resultado;
        }

        public int Multiplicar(int num1, int num2)
        {
            int resultado = num1 * num2;
            listaHistorico.Insert(0, $"Resultado: {resultado}");
            return resultado;
        }

        public List<String> Historico()
        {
            listaHistorico.RemoveRange(3, listaHistorico.Count - 3);
            return listaHistorico;
        }

        public bool EhPar(int num1)
        {
            bool resultado = num1 % 2 == 0;
            listaHistorico.Insert(0, $"Resultado: {resultado}");
            return resultado;
        }

        public bool EhImpar(int num1)
        {
            bool resultado = num1 % 2 == 0;
            listaHistorico.Insert(0, $"Resultado: {resultado}");

            return !resultado;
        }
    }
}