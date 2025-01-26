namespace Behavioral.State.Sample1;

public class InsertedMoneyState : IVendingMachineState
{
    public void Handle(IVendingMachine context)
    {



        if (context.SelectedProduct is not null)
            context.State = new DispesingProductState();
        else
            Console.WriteLine("Please select a product");

    }
}
