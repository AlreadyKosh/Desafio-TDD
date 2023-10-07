using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Calculadora.Services;

namespace CalculadoraTestes
{
    public class ValidacoesStringTests
    {
        private ValidaString _validacoes;

        public ValidacoesStringTests()
        {
            _validacoes = new ValidaString();
        }

        [Fact]
        public void DeveContarTrêsCaracteresEmOlaERetorna3()
        {
            //Arrange
            string texto = "Ola";
            //Act
            int resultado = _validacoes.ContarCaracteres(texto);
            //Assert
            Assert.Equal(3, resultado);
        }

        [Fact]
        public void DevePegarAPrimeiraLetraDaString()
        {
            //Arrange
            string texto = "Koshinho";
            //Act
            string resultado = _validacoes.PegarPrimeiraLetra(texto);
            //Assert
            Assert.Equal("K", resultado);
        }

        [Theory]
        [InlineData("Tudo Bem", "TUDO BEM")]
        [InlineData("Douglas", "DOUGLAS")]

        public void DeveDeixarAStringEmCaixaAlta(string texto, string resultado)
        {
            //Arrange
            //Act
            string resultadoFuncao = _validacoes.DeixarMaiusculo(texto);
            //Assert
            Assert.Equal(resultado, resultadoFuncao);
        }

        [Theory]
        [InlineData("Tudo Bem", "tudo bem")]
        [InlineData("DOUGLAS", "douglas")]

        public void DeveDeixarAStringEmCaixaBaixar(string texto, string resultado)
        {
            //Arrange
            //Act
            string resultadoFuncao = _validacoes.DeixarMinusculo(texto);
            //Assert
            Assert.Equal(resultado, resultadoFuncao);
        }
    }
}