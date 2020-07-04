using FluentAssertions;
using NUnit.Framework;
using RiscDetection;

namespace RiscDetectionTest
{
    public class FaixaRiscoDoencaXTest
    {
        [TestCase(18)]
        [TestCase(35)]
        public void pessoa_com_20_anos_esta_na_zona_de_risco(int idade)
        {
            new FaixaRiscoDoencaX().FaixaRisco(idade).Should().BeTrue();
        }
        
        [TestCase(17)]
        [TestCase(36)]
        public void pessoa_com_15_anos_esta_fora_da_zona_de_risco(int idade)
        {
            new FaixaRiscoDoencaX().FaixaRisco(idade).Should().BeFalse();
        }
    }
}