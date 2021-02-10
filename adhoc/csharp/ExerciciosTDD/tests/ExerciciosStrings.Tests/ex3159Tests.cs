using ExerciciosStrings.ex3159;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace ExerciciosStrings.Tests
{
    public class ex3159Tests
    {
        [Fact(DisplayName ="Tecla 2")]
        [Trait("Categoria", "Ex3159")]
        public void TeclaDoisRetornando_ABC()
        {
            var ex = new Ex3159();

            #region
            var textoA = 'a';
            var textoB = 'b';
            var textoC = 'c';
            #endregion

            // Act 
            var a2 = ex.EncontrarTecla(textoA);
            var b22 = ex.EncontrarTecla(textoB);
            var c222 = ex.EncontrarTecla(textoC);

            //Assert
            Assert.Equal("2", a2);
            Assert.Equal("22", b22);
            Assert.Equal("222", c222);
        }

        [Fact(DisplayName = "Traduzir texto")]
        [Trait("Categoria", "Ex3159")]
        public void TraduzirTexto_DeveRetornarOTextoCorreto()
        {
            // Arrange 
            var ex = new Ex3159();

            var texto = "cAfe";
            var traducao = "222#2333*33";

            // Act 
            var resposta = ex.TraduzirTexto(texto);

            //Assert
            Assert.Equal(traducao, resposta);
        }
    }
}
