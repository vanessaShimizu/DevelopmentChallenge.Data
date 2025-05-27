using DevelopmentChallenge.Data.Classes.Enums;
using DevelopmentChallenge.Data.Classes.Formas;
using DevelopmentChallenge.Data.Classes.Idioma;
using System.Text;

namespace DevelopmentChallenge.Data.Classes
{
    public static class GeradorRelatorio
    {
        public static string Imprimir(List<FormaGeometrica> formas, IdiomaEnum idioma)
        {
            var sb = new StringBuilder();

            if (formas.Count == 0)
            {
                sb.Append(IdiomaProvider.ObtenerLineaVacia(idioma));
                return sb.ToString();
            }

            sb.Append(IdiomaProvider.ObtenerLineaHeader(idioma));

            var grupos = formas.GroupBy(f => f.Tipo);

            foreach (var grupo in grupos)
            {
                var cantidad = grupo.Count();
                var area = grupo.Sum(f => f.CalcularArea());
                var perimetro = grupo.Sum(f => f.CalcularPerimetro());
                var forma = grupo.First();

                sb.Append(ObtenerLinea(cantidad, area, perimetro, forma, idioma));
            }

            sb.Append(ObtenerTotal(formas, idioma));

            return sb.ToString().Replace(".", ",");
        }

        private static string ObtenerLinea(int cantidad, decimal area, decimal perimetro, FormaGeometrica forma, IdiomaEnum idioma)
        {
            if (cantidad <= 0) return string.Empty;

            var palabraPerimetro = idioma == IdiomaEnum.Ingles ? "Perimeter" : "Perimetro";
            var nombreForma = forma.Traducir(cantidad, idioma);

            return $"{cantidad} {nombreForma} | Area {area:#.##} | {palabraPerimetro} {perimetro:#.##} <br/>";
        }

        private static string ObtenerTotal(List<FormaGeometrica> formas, IdiomaEnum idioma)
        {
            var totalFormas = formas.Count;
            var totalPerimetro = formas.Sum(f => f.CalcularPerimetro());
            var totalArea = formas.Sum(f => f.CalcularArea());

            var sb = new StringBuilder();
            sb.Append("TOTAL:<br/>");
            sb.Append($"{totalFormas} {IdiomaProvider.ObtenerTotalFormas(totalFormas, idioma)} ");
            sb.Append($"{IdiomaProvider.ObtenerTotalPerimetro(idioma)} {totalPerimetro:#.##} ");
            sb.Append($"{IdiomaProvider.ObtenerTotalArea(idioma)} {totalArea:#.##}");

            return sb.ToString();
        }
    }
}