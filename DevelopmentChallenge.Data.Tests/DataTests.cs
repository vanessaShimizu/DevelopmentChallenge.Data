using DevelopmentChallenge.Data.Classes;
using DevelopmentChallenge.Data.Classes.Enums;
using DevelopmentChallenge.Data.Classes.Formas;

namespace DevelopmentChallenge.Data.Tests
{
    public class DataTests
    {
        [Fact]
        public void TestResumenListaVacia()
        {
            Assert.Equal("<h1>Lista vacía de formas!</h1>",
                GeradorRelatorio.Imprimir(new List<FormaGeometrica>(), IdiomaEnum.Castellano));
        }

        [Fact]
        public void TestResumenListaVaciaFormasEnIngles()
        {
            Assert.Equal("<h1>Empty list of shapes!</h1>",
                GeradorRelatorio.Imprimir(new List<FormaGeometrica>(), IdiomaEnum.Ingles));
        }

        [Fact]
        public void TestResumenListaConUnCuadrado()
        {
            var cuadrados = new List<FormaGeometrica> { new Cuadrado(5) };

            var resumen = GeradorRelatorio.Imprimir(cuadrados, IdiomaEnum.Castellano);

            Assert.Equal("<h1>Reporte de Formas</h1>1 Cuadrado | Area 25 | Perimetro 20 <br/>TOTAL:<br/>1 forma Perimetro 20 Area 25", resumen);
        }

        [Fact]
        public void TestResumenListaConMasCuadrados()
        {
            var cuadrados = new List<FormaGeometrica>
            {
                new Cuadrado(5),
                new Cuadrado(1),
                new Cuadrado(3)
            };

            var resumen = GeradorRelatorio.Imprimir(cuadrados, IdiomaEnum.Ingles);

            Assert.Equal("<h1>Shapes report</h1>3 Squares | Area 35 | Perimeter 36 <br/>TOTAL:<br/>3 shapes Perimeter 36 Area 35", resumen);
        }

        [Fact]
        public void TestResumenListaConMasTipos()
        {
            var formas = new List<FormaGeometrica>
            {
                new Cuadrado(5),
                new Circulo(3),
                new TrianguloEquilatero(4),
                new Cuadrado(2),
                new TrianguloEquilatero(9),
                new Circulo(2.75m),
                new TrianguloEquilatero(4.2m)
            };

            var resumen = GeradorRelatorio.Imprimir(formas, IdiomaEnum.Ingles);

            Assert.Equal(
                "<h1>Shapes report</h1>2 Squares | Area 29 | Perimeter 28 <br/>2 Circles | Area 13,01 | Perimeter 18,06 <br/>3 Triangles | Area 49,64 | Perimeter 51,6 <br/>TOTAL:<br/>7 shapes Perimeter 97,66 Area 91,65",
                resumen);
        }

        [Fact]
        public void TestResumenListaConMasTiposEnCastellano()
        {
            var formas = new List<FormaGeometrica>
            {
                new Cuadrado(5),
                new Circulo(3),
                new TrianguloEquilatero(4),
                new Cuadrado(2),
                new TrianguloEquilatero(9),
                new Circulo(2.75m),
                new TrianguloEquilatero(4.2m)
            };

            var resumen = GeradorRelatorio.Imprimir(formas, IdiomaEnum.Castellano);

            Assert.Equal(
                "<h1>Reporte de Formas</h1>2 Cuadrados | Area 29 | Perimetro 28 <br/>2 Círculos | Area 13,01 | Perimetro 18,06 <br/>3 Triángulos | Area 49,64 | Perimetro 51,6 <br/>TOTAL:<br/>7 formas Perimetro 97,66 Area 91,65",
                resumen);
        }

        [Fact]
        public void TestResumenListaConMasTiposEnItaliano()
        {
            var formas = new List<FormaGeometrica>
            {
                new Cuadrado(5),
                new Circulo(3),
                new TrianguloEquilatero(4),
                new Cuadrado(2),
                new TrianguloEquilatero(9),
                new Circulo(2.75m),
                new TrianguloEquilatero(4.2m)
            };

            var resumen = GeradorRelatorio.Imprimir(formas, IdiomaEnum.Italiano);

            Assert.Equal(
                "<h1>Rapporto sulle forme</h1>2 Quadri | Area 29 | Perimetro 28 <br/>2 Cerchi | Area 13,01 | Perimetro 18,06 <br/>3 Triangoli | Area 49,64 | Perimetro 51,6 <br/>TOTAL:<br/>7 forme Perimetro 97,66 Area 91,65",
                resumen);
        }

        [Fact]
        public void TestResumenListaConTrapecio()
        {
            var formas = new List<FormaGeometrica>
            {
                new Cuadrado(5),
                new Trapecio(10m, 5m, 4m, 4m, 3m),
                new TrianguloEquilatero(4)
            };

            var resumen = GeradorRelatorio.Imprimir(formas, IdiomaEnum.Castellano);

            Assert.Equal(
                "<h1>Reporte de Formas</h1>1 Cuadrado | Area 25 | Perimetro 20 <br/>1 Trapecio | Area 22,5 | Perimetro 23 <br/>1 Triángulo | Area 6,93 | Perimetro 12 <br/>TOTAL:<br/>3 formas Perimetro 55 Area 54,43",
                resumen);
        }
    }
}