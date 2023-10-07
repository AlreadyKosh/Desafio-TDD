using Calculadora.Services;

namespace CalculadoraTestes;

public class CalculadoraTests
{
    private CalculadoraImplemetacao _calc;

    public CalculadoraTests()
    {
        _calc = new CalculadoraImplemetacao();
    }

    [Theory]
    [InlineData(5, 10, 15)]
    [InlineData(10, 10, 20)]

    public void DeveSomarOsNumerosERetornarOValorEsperado(int num1, int num2, int resultado)
    {
        //Arrange
        //Act
        int resultadoFuncao = _calc.Somar(num1, num2);

        //Assert
        Assert.Equal(resultado, resultadoFuncao);
    }

    [Theory]
    [InlineData(20, 10, 10)]
    [InlineData(10, 10, 0)]

    public void DeveSubtrairOsNumerosERetornarOValorEsperado(int num1, int num2, int resultado)
    {
        //Arrange
        //Act
        int resultadoFuncao = _calc.Subtrair(num1, num2);

        //Assert
        Assert.Equal(resultado, resultadoFuncao);
    }

    [Theory]
    [InlineData(2, 2, 4)]
    [InlineData(20, 2, 40)]
    public void DeveMultiplicarOsNumerosERetornarOValorEsperado(int num1, int num2, int resultado)
    {
        //Arrange
        //Act
        int resultadoFuncao = _calc.Multiplicar(num1, num2);

        //Assert
        Assert.Equal(resultado, resultadoFuncao);
    }

    [Theory]
    [InlineData(10, 10, 1)]
    [InlineData(100, 2, 50)]
    public void DeveDividirOsNumerosERetornarOValorEsperado(int num1, int num2, int resultado)
    {
        //Arrange
        //Act
        int resultadoFuncao = _calc.Dividir(num1, num2);

        //Assert
        Assert.Equal(resultado, resultadoFuncao);
    }

    [Fact]
    public void DeveDividirPor0ERetornarUmaExcessao()
    {
        //Arrange

        //Act

        //Assert
        Assert.Throws<DivideByZeroException>(() => _calc.Dividir(3, 0));
    }

    [Fact]
    public void DeveVerificarSeOHistoricoNaoEstaVazio()
    {
        //Arrange
        int num1 = 2;
        int num2 = 2;
        //Act   
        _calc.Dividir(num1, num2);
        _calc.Dividir(num1, num2);
        _calc.Dividir(num1, num2);

        var lista = _calc.Historico();

        //Assert
        Assert.NotEmpty(_calc.Historico());
        Assert.Equal(3, lista.Count);
    }

    [Fact]
    public void DeveVerificarSe4EParERetornaVerdadeiro()
    {
        //Arrange
        int num = 4;

        //Act
        bool resultado = _calc.EhPar(num);
        //Assert
        Assert.True(resultado);
    }

    [Fact]
    public void DeveVerificarSe5EImparERetornaVerdadeiro()
    {
        //Arrange
        int num = 5;

        //Act
        bool resultado = _calc.EhImpar(num);
        //Assert
        Assert.True(resultado);
    }

    [Theory]
    [InlineData(new int[] { 2, 4 })]
    [InlineData(new int[] { 6, 8, 10 })]

    public void DeveVerificarSeOsNumerosSaoParesERetornarVerdadeiro(int[] numeros)
    {
        //Act
        //Assert
        Assert.All(numeros, num => Assert.True(_calc.EhPar(num)));
    }
}