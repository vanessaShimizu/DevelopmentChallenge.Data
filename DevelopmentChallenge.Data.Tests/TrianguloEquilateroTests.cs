using DevelopmentChallenge.Data.Classes.Enums;
using DevelopmentChallenge.Data.Classes.Formas;

namespace DevelopmentChallenge.Data.Tests.Formas
{
    public class TrianguloEquilateroTests
    {
        [Fact]
        public void CalculaAreaCorrectamente()
        {
            var triangulo = new TrianguloEquilatero(5m);
            var areaEsperada = 10.825317m;
            Assert.Equal(areaEsperada, triangulo.CalcularArea(), 5);
        }

        [Fact]
        public void CalculaPerimetroCorrectamente()
        {
            var triangulo = new TrianguloEquilatero(5m);
            Assert.Equal(15m, triangulo.CalcularPerimetro());
        }

        [Theory]
        [InlineData(1, IdiomaEnum.Castellano, "Triángulo")]
        [InlineData(2, IdiomaEnum.Castellano, "Triángulos")]
        [InlineData(1, IdiomaEnum.Ingles, "Triangle")]
        [InlineData(2, IdiomaEnum.Ingles, "Triangles")]
        [InlineData(1, IdiomaEnum.Italiano, "Triangolo")]
        [InlineData(2, IdiomaEnum.Italiano, "Triangoli")]
        public void TraduceCorrectamente(int cantidad, IdiomaEnum idioma, string esperado)
        {
            var triangulo = new TrianguloEquilatero(5m);
            Assert.Equal(esperado, triangulo.Traducir(cantidad, idioma));
        }
    }
}