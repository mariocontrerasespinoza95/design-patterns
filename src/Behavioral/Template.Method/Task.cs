namespace Template.Method;

public class Task
{
    private readonly AuditTrail _auditTrail = new();

    public void Execute()
    {
        _auditTrail.Record();

        DoExecute();
    }

    protected virtual void DoExecute() => Console.WriteLine("Task Execute");
}
