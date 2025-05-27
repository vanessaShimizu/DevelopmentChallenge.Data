using DevelopmentChallenge.Data.Classes.Enums;

namespace DevelopmentChallenge.Data.Classes.Formas
{
    public class Circulo(decimal diametro) : FormaGeometrica
    {
        private readonly decimal _diametro = diametro;
        public override TipoFormaEnum Tipo => TipoFormaEnum.Circulo;

        public override decimal CalcularArea()
        {
            return (decimal)Math.PI * (_diametro/ 2) * (_diametro / 2);
        }

        public override decimal CalcularPerimetro()
        {
            return (decimal)Math.PI * _diametro;
        }

        public override string Traducir(int cantidad, IdiomaEnum idioma)
        {
            return idioma switch
            {
                IdiomaEnum.Ingles => cantidad == 1 ? "Circle" : "Circles",
                IdiomaEnum.Italiano => cantidad == 1 ? "Cerchio" : "Cerchi",
                IdiomaEnum.Castellano => cantidad == 1 ? "Círculo" : "Círculos",
                _ => string.Empty
            };
        }
    }
}
