using DevelopmentChallenge.Data.Classes.Enums;

namespace DevelopmentChallenge.Data.Classes.Formas
{
    public class TrianguloEquilatero(decimal lado) : FormaGeometrica
    {
        private readonly decimal _lado = lado;
        public override TipoFormaEnum Tipo => TipoFormaEnum.TrianguloEquilatero;

        public override decimal CalcularArea()
        {
            return ((decimal)Math.Sqrt(3)/4) * _lado * _lado;
        }

        public override decimal CalcularPerimetro()
        {
           return _lado * 3;
        }

        public override string Traducir(int cantidad, IdiomaEnum idioma)
        {
            return idioma switch
            {
                IdiomaEnum.Ingles => cantidad == 1 ? "Triangle" : "Triangles",
                IdiomaEnum.Italiano => cantidad == 1 ? "Triangolo" : "Triangoli",
                IdiomaEnum.Castellano => cantidad == 1 ? "Triángulo" : "Triángulos",
                _ => string.Empty
            };
        }
    }
}
