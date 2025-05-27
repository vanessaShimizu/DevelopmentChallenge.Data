using DevelopmentChallenge.Data.Classes;
using DevelopmentChallenge.Data.Classes.Enums;
using DevelopmentChallenge.Data.Classes.Formas;


namespace DevelopmentChallenge.Data.Tests.Integration
{
    public class ReporteIntegrationTests
    {
        [Fact]
        public void ReporteCompletoConTodasLasFormasEnCastellano()
        {
            var formas = new List<FormaGeometrica>
            {
                new Cuadrado(5m),
                new Circulo(3m),
                new TrianguloEquilatero(4m),
                new Cuadrado(2m),
                new TrianguloEquilatero(9m),
                new Circulo(2.75m),
                new TrianguloEquilatero(4.2m),
                new Trapecio(10m, 6m, 4m, 5m, 4m)
            };

            var resultado = GeradorRelatorio.Imprimir(formas, IdiomaEnum.Castellano);

            var esperado = "<h1>Reporte de Formas</h1>" +
                          "2 Cuadrados | Area 29 | Perimetro 28 <br/>" +
                          "2 Círculos | Area 13,01 | Perimetro 18,06 <br/>" +
                          "3 Triángulos | Area 49,64 | Perimetro 51,6 <br/>" +
                          "1 Trapecio | Area 32 | Perimetro 25 <br/>" +
                          "TOTAL:<br/>8 formas Perimetro 122,66 Area 123,65";

            Assert.Equal(esperado, resultado);
        }

        [Fact]
        public void ReporteCompletoConTodasLasFormasEnIngles()
        {
            var formas = new List<FormaGeometrica>
            {
                new Cuadrado(5m),
                new Circulo(3m),
                new TrianguloEquilatero(4m),
                new Trapecio(10m, 6m, 4m, 5m, 4m)
            };

            var resultado = GeradorRelatorio.Imprimir(formas, IdiomaEnum.Ingles);

            var esperado = "<h1>Shapes report</h1>" +
                          "1 Square | Area 25 | Perimeter 20 <br/>" +
                          "1 Circle | Area 7,07 | Perimeter 9,42 <br/>" +
                          "1 Triangle | Area 6,93 | Perimeter 12 <br/>" +
                          "1 Trapezoid | Area 32 | Perimeter 25 <br/>" +
                          "TOTAL:<br/>4 shapes Perimeter 66,42 Area 71";

            Assert.Equal(esperado, resultado);
        }

        [Fact]
        public void ReporteCompletoConTodasLasFormasEnItaliano()
        {
            var formas = new List<FormaGeometrica>
            {
                new Cuadrado(5m),
                new Circulo(3m),
                new TrianguloEquilatero(4m),
                new Trapecio(10m, 6m, 4m, 5m, 4m)
            };

            var resultado = GeradorRelatorio.Imprimir(formas, IdiomaEnum.Italiano);

            var esperado = "<h1>Rapporto sulle forme</h1>" +
                          "1 Quadrato | Area 25 | Perimetro 20 <br/>" +
                          "1 Cerchio | Area 7,07 | Perimetro 9,42 <br/>" +
                          "1 Triangolo | Area 6,93 | Perimetro 12 <br/>" +
                          "1 Trapezio | Area 32 | Perimetro 25 <br/>" +
                          "TOTAL:<br/>4 forme Perimetro 66,42 Area 71";

            Assert.Equal(esperado, resultado);
        }
    }
}