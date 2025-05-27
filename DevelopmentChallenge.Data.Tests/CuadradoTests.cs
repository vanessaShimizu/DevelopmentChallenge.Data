using DevelopmentChallenge.Data.Classes.Enums;
using DevelopmentChallenge.Data.Classes.Formas;

namespace DevelopmentChallenge.Data.Tests.Formas
{
    public class CuadradoTests
    {
        [Fact]
        public void CalculaAreaCorrectamente()
        {
            var cuadrado = new Cuadrado(5m);
            Assert.Equal(25m, cuadrado.CalcularArea());
        }

        [Fact]
        public void CalculaPerimetroCorrectamente()
        {
            var cuadrado = new Cuadrado(5m);
            Assert.Equal(20m, cuadrado.CalcularPerimetro());
        }

        [Theory]
        [InlineData(1, IdiomaEnum.Castellano, "Cuadrado")]
        [InlineData(2, IdiomaEnum.Castellano, "Cuadrados")]
        [InlineData(1, IdiomaEnum.Ingles, "Square")]
        [InlineData(2, IdiomaEnum.Ingles, "Squares")]
        [InlineData(1, IdiomaEnum.Italiano, "Quadrato")]
        [InlineData(2, IdiomaEnum.Italiano, "Quadri")]
        public void TraduceCorrectamente(int cantidad, IdiomaEnum idioma, string esperado)
        {
            var cuadrado = new Cuadrado(5m);
            Assert.Equal(esperado, cuadrado.Traducir(cantidad, idioma));
        }
    }
}