namespace StringCalculator;

public class Calculator
{
    private readonly string[] _delimiters = [",", "\n"];

    public int Calculate(string input)
    {
        if (string.IsNullOrEmpty(input)) return 0;

        var operands = input.Split(_delimiters, StringSplitOptions.None);

        return operands.Select(int.Parse).Sum();
    }
}