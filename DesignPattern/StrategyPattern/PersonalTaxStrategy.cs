namespace StrategyPattern
{
    public class PersonalTaxStrategy:ITaxStragety
    {
        public double CalculateTax(double income)
        {
            return income * 0.12;
        }
    }
}