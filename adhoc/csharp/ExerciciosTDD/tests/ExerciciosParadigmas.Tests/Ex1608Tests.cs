using ExerciciosParadigmas.ex1608;
using Xunit;

namespace ExerciciosParadigmas.Tests
{
    public class Ex1608Tests
    {
        [Fact(DisplayName = "Adicionar Ingrediente ao Bolo")]
        [Trait("Categoria", "Ex 1608")]
        public void AdicionarIngredienteAoBolo()
        {
            // Arrange
            var bolo = new Bolo();
            var ingrediente = new Ingrediente(id: 0, valor: 2);
            var ingredienteBolo = new IngredienteBolo(ingrediente: ingrediente, quantidade: 2);
            // Act
            bolo.AdicionarIngrediente(ingredienteBolo);

            // Assert
            Assert.Equal(1, bolo.Ingredientes.Count);
        }

        [Fact(DisplayName = "Calcular Valor do Ingrediente ")]
        [Trait("Categoria", "Ex 1608")]
        public void CalcularValorIngrediente()
        {
            // Arrange
            var ingrediente1 = new Ingrediente(id: 0, valor: 3);
            var ingredienteBolo1 = new IngredienteBolo(ingrediente: ingrediente1, quantidade: 2);

            var valorEsperado = ingrediente1.Valor * ingredienteBolo1.Quantidade;

            // Act
            var result = ingredienteBolo1.ValorTotalIngrediente;

            // Assert
            Assert.Equal(valorEsperado, result);
        }

        [Fact(DisplayName = "Calcular Valor do Bolo")]
        [Trait("Categoria", "Ex 1608")]
        public void CalcularValorBolo()
        {
            // Arrange
            var bolo = new Bolo();
            var ingrediente1 = new Ingrediente(id: 0, valor: 3);
            var ingredienteBolo1 = new IngredienteBolo(ingrediente: ingrediente1, quantidade: 2);

            var ingrediente2 = new Ingrediente(id: 1, valor: 4);
            var ingredienteBolo2 = new IngredienteBolo(ingrediente: ingrediente2, quantidade: 3);

            bolo.AdicionarIngrediente(ingredienteBolo1);
            bolo.AdicionarIngrediente(ingredienteBolo2);

            var valorTotal = (ingredienteBolo1.Ingrediente.Valor * ingredienteBolo1.Quantidade) +
                             (ingredienteBolo2.Ingrediente.Valor * ingredienteBolo2.Quantidade);

            // Act
            var result = bolo.ValorBolo;

            // Assert
            Assert.Equal(valorTotal, result);
        }
    }
}
