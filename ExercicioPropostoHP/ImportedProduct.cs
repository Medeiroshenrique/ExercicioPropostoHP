using System.Globalization;

namespace ExercicioPropostoHP;

public class ImportedProduct : Product, IProduct
{
    private double _customsFee { get; set; }

    public ImportedProduct(string name, double price, double customsFee):base(name, price)
    {
        _customsFee = customsFee;
    }

    public override string priceTag()
    {
        return _name + " $ "+ totalPrice().ToString("F2", CultureInfo.InvariantCulture) +
            $" (Customs fee : {_customsFee.ToString("F2",CultureInfo.InvariantCulture)})";
}

    public double totalPrice()
    {
        return _price + _customsFee;
    }

}