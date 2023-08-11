namespace ExercicioPropostoHP;

public class Product:IProduct
{
    public string _name { get; set; }
    public double _price { get; set; }

    public Product(string name, double price)
    {
        _name = name;
        _price = price;
    }
    
    public virtual string priceTag()
    {
        string priceTag = $"{_name} $ {_price}";
        return priceTag;
    }
}