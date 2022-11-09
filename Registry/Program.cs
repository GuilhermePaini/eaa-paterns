namespace Registry;
internal class Program
{
    private static void Main(string[] args)
    {
        var registry = new OrderRegistry();
        var teste = registry["123"];
    }
}