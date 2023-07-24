using System.Text;

namespace CodeGenerator;
internal class GeneratorInternal
{
    private Random? _random;
    internal string Run()
    {
        _random = new();
        HashSet<int> items = new(6);
        while (items.Count < 6)
        {
            int i = _random.Next(0, 10);
            if (!items.Contains(i))
                items.Add(i);
        }
        return string.Join("", items);
    }
}
