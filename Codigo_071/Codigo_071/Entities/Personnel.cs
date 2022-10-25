namespace Codigo_071.Entities
{
    class Personnel : TaxPayer
    {
        public double HealthExpenditure { get; set; }
        public Personnel() { }
        public Personnel(string name, double annualIncome, double healthExpenditure) : base(name, annualIncome)
        {
            HealthExpenditure = healthExpenditure;
        }

        public override double Taxes()
        {
            if (AnnualIncome < 20000.00)
            {
                return (AnnualIncome * 0.15) - (HealthExpenditure * 0.50);
            }
            else
            {
                return (AnnualIncome * 0.25) - (HealthExpenditure * 0.50);
            }
        }
    }
}
