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
        var orderedRules = rules.OrderBy(x => x.OrderOfExecution).ToArray();

        foreach (var rule in orderedRules)
        {
            var result = rule.ApplyRule(number);
            if (result != null)
            {
                return result;
            }
        }

        return number.ToString();
    }
}