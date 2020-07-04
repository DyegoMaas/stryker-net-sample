namespace RiscDetection
{
    public class FaixaRiscoDoencaX
    {
        public bool FaixaRisco(int idade)
        {
            return idade > 17 && idade <= 35;
        }
    }
}