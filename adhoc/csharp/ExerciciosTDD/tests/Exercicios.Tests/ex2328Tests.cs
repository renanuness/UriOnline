using ExerciciosAdHoc.ex2328;
using Xunit;

namespace Exercicios.Tests
{
    public class ex2328Tests
    {
        [Fact(DisplayName = "")]
        [Trait("Categoria", "Ex 2328")]
        public void PassarValores_DeveRetornarCorreto()
        {
            // Arrange
            var ex = new Ex2328();

            ex.Executar();
        }
    }
}
