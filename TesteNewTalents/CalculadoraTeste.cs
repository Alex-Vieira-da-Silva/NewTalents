using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NewTalents;

namespace TesteNewTalents
{
    public class CalculadoraTeste
    {
        public Calculadora ConstruirCalculadora()
        {
            string data = DateTime.Now.ToString("dd/MM/yyyy");

            Calculadora calc = new Calculadora(data);

            return calc;
        }
        

        [Theory]
        [InlineData(1, 2, 3)]
        [InlineData(4, 5, 9)]
        public void TesteSomar(int val1, int val2, int resultado)
        {
            Calculadora calc = ConstruirCalculadora();

            int resultadoCalculadora = calc.Somar(val1, val2);

            Assert.Equal(resultado, resultadoCalculadora);
        }

        [Theory]
        [InlineData(6, 2, 4)]
        [InlineData(5, 5, 0)]
        public void TesteSubtrair(int val1, int val2, int resultado)
        {
            Calculadora calc = ConstruirCalculadora();

            int resultadoCalculadora = calc.Subtrair(val1, val2);

            Assert.Equal(resultado, resultadoCalculadora);
        }

        [Theory]
        [InlineData(1, 2, 2)]
        [InlineData(4, 5, 20)]
        public void TesteMultiplar(int val1, int val2, int resultado)
        {
            Calculadora calc = ConstruirCalculadora();

            int resultadoCalculadora = calc.Multiplicar(val1, val2);

            Assert.Equal(resultado, resultadoCalculadora);
        }

        [Theory]
        [InlineData(6, 2, 3)]
        [InlineData(5, 5, 1)]
        public void TesteDividir(int val1, int val2, int resultado)
        {
            Calculadora calc = ConstruirCalculadora();

            int resultadoCalculadora = calc.Dividir(val1, val2);

            Assert.Equal(resultado, resultadoCalculadora);
        }

        [Fact]
        public void TesteDivisaoPorZero()
        {
            Calculadora calc = ConstruirCalculadora();

            Assert.Throws<DivideByZeroException>(
                () => calc.Dividir(3, 0)
                );
        }

        [Fact]
        public void TesteHistorico()
        {
            Calculadora calc = ConstruirCalculadora();

            calc.Somar(2, 6);
            calc.Somar(5, 7);
            calc.Somar(1, 8);
            calc.Somar(7, 9);

            var lista = calc.Historico();
            Assert.NotEmpty(lista);
            Assert.Equal(3, lista.Count);
        }
    }
}
