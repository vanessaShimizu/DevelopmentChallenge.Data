README - Development Challenge Data Visão Geral do Projeto Este projeto implementa um sistema de cálculo e relatório de formas geométricas com suporte a múltiplos idiomas, seguindo princípios SOLID e boas práticas de Orientação a Objetos.

Estrutura do Projeto
DevelopmentChallenge.Data

├── Classes/ │ ├── Formas/
│ ├── Idioma/
│ └── Relatorio/
├── Enums/
└── Tests/

Implementações das formas geométricas
Lógica de internacionalização
Geração de relatórios
Enumeradores do sistema
Testes unitários
Processo de Desenvolvimento
Modelagem das Formas Geométricas Hierarquia de classes usando herança:
public abstract class FormaGeometrica { public abstract TipoForma Tipo { get; } public abstract decimal CalcularArea(); public abstract decimal CalcularPerimetro(); public abstract string Traducir(int cantidad, Idioma idioma); }

Princípios aplicados:

-Open/Closed Principle: Fácil adição de novas formas -Liskov Substitution: Todas as formas derivam da mesma base

Implementação das Formas Cada forma implementa seus próprios cálculos:
public class Cuadrado : FormaGeometrica { // Implementação específica para quadrados }

public class Circulo : FormaGeometrica { // Implementação específica para círculos }

Sistema de Internacionalização Criado um IdiomaProvider centralizado:
public static class IdiomaProvider { public static string ObtenerLineaHeader(IdiomaEnum idioma) { ... }
}

Geração de Relatórios Implementação da classe GeradorRelatorio seguindo o Single Responsibility Principle:
public static class GeradorRelatorio { public static string Imprimir(List<FormaGeometrica> formas, IdiomaEnum idioma) { // Lógica de geração de relatório } }

-Estratégia de Testes Desenvolvemos testes unitários abrangentes: Testes por Forma Geométrica:

Verificação de cálculos de área e perímetro Testes de tradução em todos os idiomas Testes de Integração: Relatórios completos com múltiplas formas Verificação de formatação e soma total

Exemplo de teste:

[Fact] public void TestCalculoAreaCirculo() { var circulo = new Circulo(5m); Assert.Equal(19.634954m, circulo.CalcularArea(), 5); }

Configuração do Ambiente Requisitos: .NET 9 SDK xUnit (para testes)
Como executar: bash dotnet restore dotnet test

Dados Técnicos Métrica Valor Cobertura de Testes 100% formas Idiomas Suportados 3 Formas Implementadas 4
-Processo de Build O sistema usa: Injeção de Dependência implícita Formatação consistente de números

Checklist de Qualidade Todos os testes passando
Princípios SOLID aplicados Suporte a múltiplos idiomas

-Notas de Implementação As principais decisões de design foram:

Uso de classes abstratas para formas Centralização das traduções Separação clara entre cálculo e relatório Formatação consistente de números