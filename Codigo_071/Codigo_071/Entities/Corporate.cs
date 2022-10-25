namespace Codigo_071.Entities
{
    class Corporate : TaxPayer
    {
        public int QuantityEmployees { get; set; }
        public Corporate() { }
        public Corporate(string name, double annualIncome, int quantityEmployees) : base(name, annualIncome)
        {
            QuantityEmployees = quantityEmployees;
        }

        public override double Taxes()
        {
            if (QuantityEmployees > 10)
            {
                return AnnualIncome * 0.14;
            }
            else
            {
                return AnnualIncome * 0.16;
            }
        }
    }
}
