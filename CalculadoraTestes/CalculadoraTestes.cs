using Calculadora.Services;

namespace CalculadoraTestes;

public class CalculadoraTestes
{
    [Fact]
    public void Test1()
    {
        CalculadoraImplementacao calc = new CalculadoraImplementacao();

        int Resultado = calc.Somar(1, 2);

        Assert.Equal(3, Resultado);

        //como estamos esperando retornar 0, o teste falhará. Essa é a premissa do TDD.

        //há outra forma de teste usando o theory, que permite escalar os testes

    }

    [Theory]
    [InlineData (2, 4, 6)]
    public void Test2(int Valor1, int Valor2, int Resultado)
    {
        CalculadoraImplementacao calc = new CalculadoraImplementacao();
        int ResultadoDoCalculo = calc.Somar(Valor1, Valor2);
        Assert.Equal(Resultado, ResultadoDoCalculo);
        //isso me permite adicionar outros valores ao inlinedata
    }
}