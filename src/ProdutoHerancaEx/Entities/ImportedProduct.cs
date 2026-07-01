namespace ProdutoHerancaEx.Entities
{
    public class ImportedProduct : Product
    {
        public double CustomsFee { get; set; }

        public ImportedProduct()
        {
        }

        public ImportedProduct(string name, double price, double customsFee) : base(name, price)
        {
            CustomsFee = customsFee;
        }

        public override string PriceTag()
        {
            return $"{Name} (imported) $ {Price:F2} (Customs Fee: {CustomsFee:F2})";
        }

        public double TotalPrice()
        {
            return Price + CustomsFee;
        }
    }
}
        