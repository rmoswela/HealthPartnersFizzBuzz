namespace FizzBuzzAPI;

public class FizzRule : IRule
{
    public string ApplyRule(int number)
    {
        if (number % 3 == 0)
        {
            return "Fizz";
        }

        return null;
    }
}