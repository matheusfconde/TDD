using Alura.LeilaoOnline.Core;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Alura.LeilaoOnline.Tests
{
    public class LeilaoTerminaPregao
    { 
        //Teste por classe de equivalência.
        [Theory]
        [InlineData(1200,new Double[] { 800, 900, 1000, 1200 })]
        [InlineData(1000,new Double[] { 800, 900, 1000, 990 })]
        [InlineData(800,new Double[] { 800 })]      
        public void RetornaMaiorValorDadoLeilaoComPeloMenosUmLance(double valorEsperado,double[] ofertas)
        {
            //Arranje - cenário 
            var leilao = new Leilao("Van Gogh");
            var fulano = new Interessada("Fulano", leilao);

            foreach(var valor in ofertas)
            {
                leilao.RecebeLance(fulano, valor);
            }

            //Act - método sob teste
            leilao.TerminaPregao();

            //Assert (Verificação do cenário)            
            var valorObtido = leilao.Ganhador.Valor;
            Assert.Equal(valorEsperado, valorObtido);
        }

        [Fact]
        public void RetornaZeroDadoLeilaoSemLances()
        {
            //Arranje - cenário 
            var leilao = new Leilao("Van Gogh");

            //Act - método sob teste
            leilao.TerminaPregao();

            //Assert (Verificação do cenário)
            var valorEsperado = 0;
            var valorObtido = leilao.Ganhador.Valor;

            Assert.Equal(valorEsperado, valorObtido);
        }


    }
}
