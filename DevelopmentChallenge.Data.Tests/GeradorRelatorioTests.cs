using DevelopmentChallenge.Data.Classes;
using DevelopmentChallenge.Data.Classes.Enums;
using DevelopmentChallenge.Data.Classes.Formas;


namespace DevelopmentChallenge.Data.Tests.Relatorio
{
    public class GeradorRelatorioTests
    {
        [Fact]
        public void ListaVaciaDevuelveHeaderCorrectoEnCastellano()
        {
            var resultado = GeradorRelatorio.Imprimir(new List<FormaGeometrica>(), IdiomaEnum.Castellano);
            Assert.Equal("<h1>Lista vacía de formas!</h1>", resultado);
        }

        [Fact]
        public void ListaVaciaDevuelveHeaderCorrectoEnIngles()
        {
            var resultado = GeradorRelatorio.Imprimir(new List<FormaGeometrica>(), IdiomaEnum.Ingles);
            Assert.Equal("<h1>Empty list of shapes!</h1>", resultado);
        }

        [Fact]
        public void ListaVaciaDevuelveHeaderCorrectoEnItaliano()
        {
            var resultado = GeradorRelatorio.Imprimir(new List<FormaGeometrica>(), IdiomaEnum.Italiano);
            Assert.Equal("<h1>Elenco vuoto di forme!</h1>", resultado);
        }

        [Fact]
        public void UnCuadradoDevuelveReporteCorrectoEnCastellano()
        {
            var formas = new List<FormaGeometrica> { new Cuadrado(5m) };
            var resultado = GeradorRelatorio.Imprimir(formas, IdiomaEnum.Castellano);

            Assert.Contains("<h1>Reporte de Formas</h1>", resultado);
            Assert.Contains("1 Cuadrado | Area 25 | Perimetro 20 <br/>", resultado);
            Assert.Contains("TOTAL:<br/>1 forma Perimetro 20 Area 25", resultado);
        }

        [Fact]
        public void MultiplesFormasDevuelveReporteCorrectoEnIngles()
        {
            var formas = new List<FormaGeometrica>
            {
                new Cuadrado(5m),
                new Circulo(3m),
                new TrianguloEquilatero(4m),
                new Trapecio(10m, 6m, 4m, 5m, 4m)
            };

            var resultado = GeradorRelatorio.Imprimir(formas, IdiomaEnum.Ingles);

            Assert.Contains("<h1>Shapes report</h1>", resultado);
            Assert.Contains("1 Square | Area 25 | Perimeter 20 <br/>", resultado);
            Assert.Contains("1 Circle | Area 7,07 | Perimeter 9,42 <br/>", resultado);
            Assert.Contains("1 Triangle | Area 6,93 | Perimeter 12 <br/>", resultado);
            Assert.Contains("1 Trapezoid | Area 32 | Perimeter 25 <br/>", resultado);
            Assert.Contains("TOTAL:<br/>4 shapes Perimeter 66,42 Area 71", resultado);
        }

        [Fact]
        public void MultiplesFormasDevuelveReporteCorrectoEnItaliano()
        {
            var formas = new List<FormaGeometrica>
            {
                new Cuadrado(5m),
                new Circulo(3m),
                new TrianguloEquilatero(4m)
            };

            var resultado = GeradorRelatorio.Imprimir(formas, IdiomaEnum.Italiano);

            Assert.Contains("<h1>Rapporto sulle forme</h1>", resultado);
            Assert.Contains("1 Quadrato | Area 25 | Perimetro 20 <br/>", resultado);
            Assert.Contains("1 Cerchio | Area 7,07 | Perimetro 9,42 <br/>", resultado);
            Assert.Contains("1 Triangolo | Area 6,93 | Perimetro 12 <br/>", resultado);
            Assert.Contains("TOTAL:<br/>3 forme Perimetro 41,42 Area 39", resultado);
        }
    }
}