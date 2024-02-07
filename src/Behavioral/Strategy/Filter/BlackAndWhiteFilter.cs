namespace Strategy.Filter;

public class BlackAndWhiteFilter : IFilter
{
    public void Apply(string fileName) => Console.WriteLine("Applying B&W filter");
}
