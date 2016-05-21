namespace StrategyPattern
{
    public class InterestOperation
    {
        private readonly ITaxStragety m_strategy;
        public InterestOperation(ITaxStragety strategy)
        {
            this.m_strategy = strategy;
        }

        public double GetTax(double income)
        {
            return m_strategy.CalculateTax(income);
        } 
    }
}