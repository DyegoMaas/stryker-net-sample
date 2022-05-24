using FluentAssertions;
using NUnit.Framework;
using RiscDetection;

namespace RiscDetectionTest
{
    /// <summary>
    /// Os testes abaixo geral um mutation score de 66,67%.
    /// </summary>
    public class FaixaRiscoDoencaXTest
    {
        [TestCase(27)]
        public void pessoa_com_20_anos_esta_na_zona_de_risco(int idade)
        {
            new FaixaRiscoDoencaX().FaixaRisco(idade).Should().BeTrue();
        }
        
        [TestCase(15)]
        [TestCase(40)]
        public void pessoa_com_15_anos_esta_fora_da_zona_de_risco(int idade)
        {
            new FaixaRiscoDoencaX().FaixaRisco(idade).Should().BeFalse();
        }
    }
}