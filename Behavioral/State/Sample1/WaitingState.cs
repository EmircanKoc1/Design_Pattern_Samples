namespace Behavioral.State.Sample1;

public class WaitingState : IVendingMachineState
{
    public void Handle(IVendingMachine context)
    {
        if (context.Money > 0)
        {
            context.State = new InsertedMoneyState();
        }
        else
            Console.WriteLine("Please add money to the machine ");
    }
}
