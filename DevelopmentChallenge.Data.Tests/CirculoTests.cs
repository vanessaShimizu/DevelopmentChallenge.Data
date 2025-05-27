using DevelopmentChallenge.Data.Classes.Enums;
using DevelopmentChallenge.Data.Classes.Formas;

namespace DevelopmentChallenge.Data.Tests.Formas
{
    public class CirculoTests
    {
        [Fact]
        public void CalculaAreaCorrectamente()
        {
            var circulo = new Circulo(5m);
            var areaEsperada = 19.634954m;
            Assert.Equal(areaEsperada, circulo.CalcularArea(), 5);
        }

        [Fact]
        public void CalculaPerimetroCorrectamente()
        {
            var circulo = new Circulo(5m);
            var perimetroEsperado = 15.707963m;
            Assert.Equal(perimetroEsperado, circulo.CalcularPerimetro(), 5);
        }

        [Theory]
        [InlineData(1, IdiomaEnum.Castellano, "Círculo")]
        [InlineData(2, IdiomaEnum.Castellano, "Círculos")]
        [InlineData(1, IdiomaEnum.Ingles, "Circle")]
        [InlineData(2, IdiomaEnum.Ingles, "Circles")]
        [InlineData(1, IdiomaEnum.Italiano, "Cerchio")]
        [InlineData(2, IdiomaEnum.Italiano, "Cerchi")]
        public void TraduceCorrectamente(int cantidad, IdiomaEnum idioma, string esperado)
        {
            var circulo = new Circulo(5m);
            Assert.Equal(esperado, circulo.Traducir(cantidad, idioma));
        }
    }
}