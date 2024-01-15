namespace StringCalculator.Tests;

[TestFixture]
[TestOf(typeof(Calculator))]
public class CalculatorTests
{
    [SetUp]
    public void SetUp()
    {
        _systemUnderTest = new Calculator();
    }

    private Calculator _systemUnderTest = null!;

    [Test]
    public void Constructor_Always_Succeeds()
    {
        Assert.That(_systemUnderTest, Is.Not.Null);
    }

    [TestCase("", 0)]
    [TestCase(null, 0)]
    [TestCase("1", 1)]
    [TestCase("1,2", 3)]
    public void Calculate_Always_ReturnsExpectedResult(string input, int expectedResult)
    {
        var result = _systemUnderTest.Calculate(input);

        Assert.That(result, Is.EqualTo(expectedResult));
    }

    [TestCase("1,2", 3)]
    [TestCase("2\n3", 5)]
    [TestCase("1,2\n3", 6)]
    public void Calculate_Supports_ExpectedDelimiters(string input, int expectedResult)
    {
        var result = _systemUnderTest.Calculate(input);

        Assert.That(result, Is.EqualTo(expectedResult));
    }
}