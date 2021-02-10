using ExerciciosAdHoc.ex1278;
using System.Collections.Generic;
using Xunit;

namespace Exercicios.Tests
{
    public class ex1278Tests
    {
        [Fact(DisplayName = "Remover Espacos Duplicados")]
        [Trait("Categoria", "Ex 1278")]
        public void LinhasComVariosEspacos_DeveRetirarEspacosDuplicados()
        {
            // Arrange
            var ex = new Ex1278();

            List<string> linhas = new List<string>();
            var linha1 = "    teste  teste      teste      ";
            var linha2 = "  teste    teste   teste         ";
            var linha3 = "   teste  teste     teste    ";
            linhas.Add(linha1);
            linhas.Add(linha2);
            linhas.Add(linha3);

            // Act 
            var result = ex.RemoverEspacos(linhas);

            // Assert
            foreach (var linha in result)
            {
                var contains = linha.Contains("  ");
                Assert.False(contains);
            }
        }
    }
}
