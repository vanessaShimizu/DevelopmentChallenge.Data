using DevelopmentChallenge.Data.Classes.Enums;

namespace DevelopmentChallenge.Data.Classes.Idioma
{
    public static class IdiomaProvider
    {
        public static string ObtenerLineaHeader(IdiomaEnum idioma)
        {
            return idioma switch
            {
                IdiomaEnum.Castellano => "<h1>Reporte de Formas</h1>",
                IdiomaEnum.Ingles => "<h1>Shapes report</h1>",
                IdiomaEnum.Italiano => "<h1>Rapporto sulle forme</h1>",
                _ => "<h1>Shapes report</h1>"
            };
        }

        public static string ObtenerLineaVacia(IdiomaEnum idioma)
        {
            return idioma switch
            {
                IdiomaEnum.Castellano => "<h1>Lista vacía de formas!</h1>",
                IdiomaEnum.Ingles => "<h1>Empty list of shapes!</h1>",
                IdiomaEnum.Italiano => "<h1>Elenco vuoto di forme!</h1>",
                _ => "<h1>Empty list of shapes!</h1>"
            };
        }

        public static string ObtenerTotalFormas(int cantidad, IdiomaEnum idioma)
        {
            return idioma switch
            {
                IdiomaEnum.Castellano => cantidad == 1 ? "forma" : "formas",
                IdiomaEnum.Ingles => cantidad == 1 ? "shape" : "shapes",
                IdiomaEnum.Italiano => cantidad == 1 ? "forma" : "forme",
                _ => cantidad == 1 ? "shape" : "shapes"
            };
        }

        public static string ObtenerTotalPerimetro(IdiomaEnum idioma)
        {
            return idioma switch
            {
                IdiomaEnum.Castellano => "Perimetro",
                IdiomaEnum.Ingles => "Perimeter",
                IdiomaEnum.Italiano => "Perimetro",
                _ => "Perimeter"
            };
        }

        public static string ObtenerTotalArea(IdiomaEnum idioma)
        {
            return idioma switch
            {
                IdiomaEnum.Castellano => "Area",
                IdiomaEnum.Ingles => "Area",
                IdiomaEnum.Italiano => "Area",
                _ => "Area"
            };
        }
    }
}