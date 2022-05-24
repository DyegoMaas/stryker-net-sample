namespace RiscDetection
{
    public class FaixaRiscoDoencaX
    {
        public bool FaixaRisco(int idade)
        {
            return idade >= 18 && idade <= 35;
        }
    }
}