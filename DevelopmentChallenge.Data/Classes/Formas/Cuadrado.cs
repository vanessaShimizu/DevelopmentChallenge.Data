using DevelopmentChallenge.Data.Classes.Enums;

namespace DevelopmentChallenge.Data.Classes.Formas
{
    public class Cuadrado(decimal lado) : FormaGeometrica
    {
        private readonly decimal _lado = lado;
        public override TipoFormaEnum Tipo => TipoFormaEnum.Cuadrado;

        public override decimal CalcularArea()
        {
            return _lado * _lado;
        }

        public override decimal CalcularPerimetro()
        {
            return _lado * 4;
        }

        public override string Traducir( int cantidad , IdiomaEnum idioma)
        {
            return idioma switch
            {
                IdiomaEnum.Castellano => cantidad == 1 ? "Cuadrado" : "Cuadrados",
                IdiomaEnum.Ingles => cantidad == 1 ? "Square" : "Squares",
                IdiomaEnum.Italiano => cantidad == 1 ? "Quadrato" : "Quadri",
                _ => string.Empty
            };
        } 
            
    }
}
