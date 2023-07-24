using CodeGenerator;

namespace CodeGeneratorTest;

public class UnitTest1
{
    [Fact]
    public void ShouldGet6DigitCode()
    {
        string code = Code.Generate();
        Assert.Equal(6, code.Length);
    }

    [Fact]
    public void ShouldGetDistinctDigits()
    {
        string code = Code.Generate();
        Assert.Distinct(code);
    }
}