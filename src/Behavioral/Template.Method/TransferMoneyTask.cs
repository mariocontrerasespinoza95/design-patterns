namespace Template.Method;

public class TransferMoneyTask : Task
{
    protected override void DoExecute()
    {
        Console.WriteLine("Transfer money");
    }
}
