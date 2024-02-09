namespace LINQ
{
    public class Program
    {
        static void Main()
        {
            List<string> strings = new List<string>() {"Final Fantasy I", "Doom", "Monster Rancher", "Galactica", "Faster Than Light", "GTA 5" };
            IOrderedEnumerable<string> orderedStrings = strings.OrderByDescending(x => x.Length);
            Console.WriteLine("Hello, World!");
        }
    }
}
