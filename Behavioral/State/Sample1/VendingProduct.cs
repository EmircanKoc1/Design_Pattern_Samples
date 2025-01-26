namespace Behavioral.State.Sample1;

public class VendingProduct
{
    public VendingProduct(short code, short price)
    {
        Code = code;
        Price = price;
    }

    public short Code { get; set; }
    public short Price { get; set; }
}
