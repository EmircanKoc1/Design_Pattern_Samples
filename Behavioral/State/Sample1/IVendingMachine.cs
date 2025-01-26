namespace Behavioral.State.Sample1;

public interface IVendingMachine
{
    IVendingMachineState State { get; set; }
    short Money { get; set; }
    VendingProduct? SelectedProduct { get; }
    IEnumerable<VendingProduct> Products { get; }

    void InsertMoney(short amount);
    void SelectProduct(short productCode);
    void BuyProduct();
    int ReturnMoney();

}
