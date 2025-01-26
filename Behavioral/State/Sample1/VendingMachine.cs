namespace Behavioral.State.Sample1;

public class VendingMachine : IVendingMachine
{
    public VendingMachine(IEnumerable<VendingProduct> products)
    {
        Products = products;
    }
    public IVendingMachineState State { get; set; } = new WaitingState();
    public short Money { get; set; }
    public VendingProduct? SelectedProduct { get; set; }

    public IEnumerable<VendingProduct> Products { get; }

    public void BuyProduct()
    {
        State.Handle(this);
    }

    public void InsertMoney(short amount)
    {
        Money += amount;
        State.Handle(this);
    }

    public int ReturnMoney()
    {
        var money = Money;
        Money = 0;
        State = new WaitingState();
        return money;
    }

    public void SelectProduct(short productCode)
    {
        SelectedProduct = Products.FirstOrDefault(p => p.Code.Equals(productCode));
        State.Handle(this);
    }
}
