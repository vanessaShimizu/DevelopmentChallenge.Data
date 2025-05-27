using DevelopmentChallenge.Data.Classes.Enums;


namespace DevelopmentChallenge.Data.Classes.Formas
{
    public abstract class FormaGeometrica 
    {
        public abstract decimal CalcularArea();
        public abstract decimal CalcularPerimetro();
        public abstract string Traducir(int cantidad, IdiomaEnum idioma);
        public abstract TipoFormaEnum Tipo { get; }

    }
}
