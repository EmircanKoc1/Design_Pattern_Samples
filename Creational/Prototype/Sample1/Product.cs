using System.Text.Json;

namespace Creational.Prototype.Sample1;

public class Product : ICloneable
{

    public ComplexDefiner? ComplexDefiner { get; set; }
    public string? Name { get; set; }
    public decimal Price { get; set; }

    public object Clone()
    {
        //shallow copy
        //return MemberwiseClone();


        //deep copy first way
        //Product product = (MemberwiseClone() as Product)!;
        //product.ComplexDefiner = new ComplexDefiner()
        //{
        //    CreatedAt = ComplexDefiner?.CreatedAt,
        //    Id = ComplexDefiner?.Id
        //};

        //deep copy second way
        string SerializedProduct = JsonSerializer.Serialize<Product>(this);
        Product product = JsonSerializer.Deserialize<Product>(SerializedProduct)!;

        return product;



    }

    public override string ToString()
    {
        return $" Product Details : \n " +
             $"Id : {ComplexDefiner?.Id} \n " +
             $"CreatedAt : {ComplexDefiner?.CreatedAt} \n" +
             $"Name : {Name} \n" +
             $"Price : {Price}";

    }

}
