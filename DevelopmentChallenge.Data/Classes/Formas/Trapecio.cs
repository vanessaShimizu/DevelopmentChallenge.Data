using DevelopmentChallenge.Data.Classes.Enums;

namespace DevelopmentChallenge.Data.Classes.Formas
{
    public class Trapecio : FormaGeometrica
    {
        private readonly decimal _baseMayor;
        private readonly decimal _baseMenor;
        private readonly decimal _ladoIzquierdo;
        private readonly decimal _ladoDerecho;
        private readonly decimal _altura;

        public override TipoFormaEnum Tipo => TipoFormaEnum.Trapecio;

        public Trapecio(decimal baseMayor, decimal baseMenor, decimal ladoIzquierdo, decimal ladoDerecho, decimal altura)
        {
            if (baseMayor <= 0 || baseMenor <= 0 || ladoIzquierdo <= 0 || ladoDerecho <= 0 || altura <= 0)
                throw new ArgumentException("Todos los parámetros del trapecio deben ser valores positivos");

            _baseMayor = baseMayor;
            _baseMenor = baseMenor;
            _ladoIzquierdo = ladoIzquierdo;
            _ladoDerecho = ladoDerecho;
            _altura = altura;
        }

        public override decimal CalcularArea()
        {            
            return ((_baseMayor + _baseMenor) / 2) * _altura;
        }

        public override decimal CalcularPerimetro()
        {         
            return _baseMayor + _baseMenor + _ladoIzquierdo + _ladoDerecho;
        }

        public override string Traducir(int cantidad, IdiomaEnum idioma)
        {
            return idioma switch
            {
                IdiomaEnum.Castellano => cantidad == 1 ? "Trapecio" : "Trapecios",
                IdiomaEnum.Ingles => cantidad == 1 ? "Trapezoid" : "Trapezoids",
                IdiomaEnum.Italiano => cantidad == 1 ? "Trapezio" : "Trapezi",
                _ => string.Empty
            };
        }
    }
}