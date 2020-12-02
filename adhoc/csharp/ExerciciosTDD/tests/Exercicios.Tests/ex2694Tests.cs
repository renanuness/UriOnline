using ExerciciosApp.ex2694;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace Exercicios.Tests
{
    public class ex2694Tests
    {
        private readonly Ex2694 _ex2964;

        public ex2694Tests()
        {
            _ex2964 = new Ex2694();
        }

        [Fact(DisplayName = "Testar Valor Inteiro Menor Maximo Casos de Teste")]
        [Trait("Categoria", "Exercicio 2964")]
        public void InsereNumeroCasosDeTesteMenorQueMaximo_DeveRetornarTrue()
        {
            // Arrange
            var valorValido = Ex2694.MAX_CASOS_TESTE - 1;

            // Act
            var result =_ex2964.ValidarCasosDeTeste(valorValido);

            // Assert
            Assert.True(result);
        }

        [Fact(DisplayName = "Remover Letras e Devolver array de inteiros")]
        [Trait("Categoria", "Exercicio 2964")]
        public void InsereLinhaComDiversosCaracters_DevolveArrayDeInteiros()
        {
            // Arrange
            var listaCaracteres = "Ab23s249ttu21";

            // Act
            var intList = _ex2964.ExtrairNumeros(listaCaracteres);

            // Assert
            Assert.Equal(23, intList[0]);
            Assert.Equal(249, intList[1]);
            Assert.Equal(21, intList[2]);
            Assert.Equal(3, intList.Count);
        }

        [Fact(DisplayName = "Soma valores")]
        [Trait("Categoria", "Exercicio 2964")]
        public void SomarListaDeNumeros_DeveRetornarValorCorreto()
        {
            // Arrange
            List<int> numeros = new List<int> { 23, 249, 21 };

            var soma = 23 + 249 + 21;

            // Act
            var result = _ex2964.SomaValores(numeros);

            // Assert
            Assert.Equal(soma, result);
        }
    }
}
