namespace FizzBuzzAPI;

public class RuleEvaluator
{
    private readonly IRule[] rules;

    public RuleEvaluator(IEnumerable<IRule> rules)
    {
        this.rules = rules.ToArray();
    }

    public string EvaluateRule(int number)
    {
        foreach (var rule in rules)
        {
            var result = rule.ApplyRule(number);
            if (result != null)
            {
                return result;
            }
        }

        return null;
    }
}