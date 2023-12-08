namespace FizzBuzzAPI;

public class FizzBuzzRule : IRule
{
    private readonly FizzRule fizzRule;
    private readonly BuzzRule buzzRule;

    public FizzBuzzRule(FizzRule fizzRule, BuzzRule buzzRule)
    {
        this.fizzRule = fizzRule;
        this.buzzRule = buzzRule;
    }

    public int OrderOfExecution => 1;

    public string ApplyRule(int number)
    {
        if (fizzRule.IsDivisibleByThree(number) && buzzRule.IsDivisibleByFive(number))
        {
            return "FizzBuzz";
        }

        return null;
    }
}