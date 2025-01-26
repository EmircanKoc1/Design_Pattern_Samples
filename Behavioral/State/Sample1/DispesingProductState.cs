namespace Behavioral.State.Sample1;

public class DispesingProductState : IVendingMachineState
{
    public void Handle(IVendingMachine context)
    {
        bool isHaveEnoughMoney = context.Money - context.SelectedProduct!.Price >= 0;

        if (isHaveEnoughMoney)
        {
            context.Money -= context.SelectedProduct.Price;
            context.State = new WaitingState();
            Console.WriteLine("Product was bought");
        }
        else
            Console.WriteLine("Not enough money");


    }
}
