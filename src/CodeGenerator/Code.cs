namespace CodeGenerator;

public static class Code
{
    public static string Generate()
    {
        GeneratorInternal gi = new();
        return gi.Run();
    }
}
