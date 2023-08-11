namespace ExercicioPropostoHP;

public class UsedProduct : Product, IProduct
{
    public DateTime _manufactureDate { get; set; }
    
    public UsedProduct(string name, double price, DateTime manufactureDate) : base(name, price)
    {
        _manufactureDate = manufactureDate;
    }

    public override string priceTag()
    {
        return $"{_name} (used) $ {_price} (Manufacture date: {_manufactureDate.ToString("dd/MM/yyyy")})";
    }
}