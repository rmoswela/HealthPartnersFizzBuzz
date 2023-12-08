namespace FizzBuzzAPI;

public class FizzBuzzGenerator
{
    private readonly RuleEvaluator evaluator;

    public FizzBuzzGenerator(RuleEvaluator evaluator)
    {
        this.evaluator = evaluator;
    }

    public void GenerateFizzBuzz(int fromNumber, int toNumber)
    {
        IEnumerable<int> inputs = new List<int> {fromNumber, toNumber};

        ValidateInputs(inputs);

        for (int number = fromNumber; number <= toNumber; number++)
        {
            Console.WriteLine(evaluator.EvaluateRule(number));
        }
    }

    private void ValidateInputs(IEnumerable<int> numbers)
    {
        if (!numbers.Any())
        {
            throw new ArgumentNullException();
        }

        if (!numbers.All(x => x >= 1 && x <= 100))
        {
            throw new ArgumentOutOfRangeException("The only range allowed is 1 to 100");
        }
    }
}