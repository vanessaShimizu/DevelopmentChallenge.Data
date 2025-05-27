using DevelopmentChallenge.Data.Classes.Enums;
using DevelopmentChallenge.Data.Classes.Idioma;

using Xunit;

namespace DevelopmentChallenge.Data.Tests.Idioma
{
    public class IdiomaProviderTests
    {
        [Theory]
        [InlineData(IdiomaEnum.Castellano, "<h1>Reporte de Formas</h1>")]
        [InlineData(IdiomaEnum.Ingles, "<h1>Shapes report</h1>")]
        [InlineData(IdiomaEnum.Italiano, "<h1>Rapporto sulle forme</h1>")]
        public void ObtenerLineaHeaderDevuelveTextoCorrecto(IdiomaEnum idioma, string esperado)
        {
            Assert.Equal(esperado, IdiomaProvider.ObtenerLineaHeader(idioma));
        }

        [Theory]
        [InlineData(IdiomaEnum.Castellano, "<h1>Lista vacía de formas!</h1>")]
        [InlineData(IdiomaEnum.Ingles, "<h1>Empty list of shapes!</h1>")]
        [InlineData(IdiomaEnum.Italiano, "<h1>Elenco vuoto di forme!</h1>")]
        public void ObtenerLineaVaciaDevuelveTextoCorrecto(IdiomaEnum idioma, string esperado)
        {
            Assert.Equal(esperado, IdiomaProvider.ObtenerLineaVacia(idioma));
        }

        [Theory]
        [InlineData(1, IdiomaEnum.Castellano, "forma")]
        [InlineData(2, IdiomaEnum.Castellano, "formas")]
        [InlineData(1, IdiomaEnum.Ingles, "shape")]
        [InlineData(2, IdiomaEnum.Ingles, "shapes")]
        [InlineData(1, IdiomaEnum.Italiano, "forma")]
        [InlineData(2, IdiomaEnum.Italiano, "forme")]
        public void ObtenerTotalFormasDevuelveTextoCorrecto(int cantidad, IdiomaEnum idioma, string esperado)
        {
            Assert.Equal(esperado, IdiomaProvider.ObtenerTotalFormas(cantidad, idioma));
        }

        [Theory]
        [InlineData(IdiomaEnum.Castellano, "Perimetro")]
        [InlineData(IdiomaEnum.Ingles, "Perimeter")]
        [InlineData(IdiomaEnum.Italiano, "Perimetro")]
        public void ObtenerTotalPerimetroDevuelveTextoCorrecto(IdiomaEnum idioma, string esperado)
        {
            Assert.Equal(esperado, IdiomaProvider.ObtenerTotalPerimetro(idioma));
        }

        [Theory]
        [InlineData(IdiomaEnum.Castellano, "Area")]
        [InlineData(IdiomaEnum.Ingles, "Area")]
        [InlineData(IdiomaEnum.Italiano, "Area")]
        public void ObtenerTotalAreaDevuelveTextoCorrecto(IdiomaEnum idioma, string esperado)
        {
            Assert.Equal(esperado, IdiomaProvider.ObtenerTotalArea(idioma));
        }
    }
}