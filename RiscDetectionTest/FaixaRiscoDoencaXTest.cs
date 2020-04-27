using FluentAssertions;
using NUnit.Framework;
using RiscDetection;

namespace RiscDetectionTest
{
    public class FaixaRiscoDoencaXTest
    {
        [Test]
        public void pessoa_com_20_anos_esta_na_zona_de_risco()
        {
            new FaixaRiscoDoencaX().FaixaRisco(20).Should().BeTrue();
        }
        
        [Test]
        public void pessoa_com_15_anos_esta_fora_da_zona_de_risco()
        {
            new FaixaRiscoDoencaX().FaixaRisco(15).Should().BeFalse();
        }
    }
}