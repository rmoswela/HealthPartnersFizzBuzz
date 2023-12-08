namespace FizzBuzzAPI;

public class BuzzRule : IRule
{
    public string ApplyRule(int number)
    {
        if (number % 5 == 0)
        {
            return "Buzz";
        }

        return null;
    }
}