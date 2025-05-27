using DevelopmentChallenge.Data.Classes.Enums;
using DevelopmentChallenge.Data.Classes.Formas;


namespace DevelopmentChallenge.Data.Tests.Formas
{
    public class TrapecioTests
    {
        [Fact]
        public void CalculaAreaCorrectamente()
        {
            var trapecio = new Trapecio(10m, 6m, 4m, 5m, 4m);
            Assert.Equal(32m, trapecio.CalcularArea());
        }

        [Fact]
        public void CalculaPerimetroCorrectamente()
        {
            var trapecio = new Trapecio(10m, 6m, 4m, 5m, 4m);
            Assert.Equal(25m, trapecio.CalcularPerimetro());
        }

        [Theory]
        [InlineData(1, IdiomaEnum.Castellano, "Trapecio")]
        [InlineData(2, IdiomaEnum.Castellano, "Trapecios")]
        [InlineData(1, IdiomaEnum.Ingles, "Trapezoid")]
        [InlineData(2, IdiomaEnum.Ingles, "Trapezoids")]
        [InlineData(1, IdiomaEnum.Italiano, "Trapezio")]
        [InlineData(2, IdiomaEnum.Italiano, "Trapezi")]
        public void TraduceCorrectamente(int cantidad, IdiomaEnum idioma, string esperado)
        {
            var trapecio = new Trapecio(10m, 6m, 4m, 5m, 4m);
            Assert.Equal(esperado, trapecio.Traducir(cantidad, idioma));
        }

        [Fact]
        public void LanzaExcepcionConParametrosInvalidos()
        {
            Assert.Throws<ArgumentException>(() => new Trapecio(0m, 6m, 4m, 5m, 4m));
            Assert.Throws<ArgumentException>(() => new Trapecio(10m, -1m, 4m, 5m, 4m));
            Assert.Throws<ArgumentException>(() => new Trapecio(10m, 6m, 0m, 5m, 4m));
        }
    }
}