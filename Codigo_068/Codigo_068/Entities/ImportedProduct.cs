using System.Globalization;

namespace Codigo_068.Entities
{
    class ImportedProduct : Product
    {
        public double CustomsFee { get; set; }
        public ImportedProduct() { }
        public ImportedProduct(string name, double price, double customsFee) : base(name, price)
        {
            Name = name;
            Price = price;
            CustomsFee = customsFee;
        }

        public double TotalPrice()
        {
            return Price + CustomsFee;
        }

        public override string PriceTag()
        {
            return Name + " $" + TotalPrice().ToString("F2", CultureInfo.InvariantCulture) + " (Customs fee: $" + CustomsFee.ToString("F2", CultureInfo.InvariantCulture) + ")";
        }
    }
}
