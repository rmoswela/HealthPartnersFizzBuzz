namespace FizzBuzzAPI;

public class BuzzRule : IRule
{
    public int OrderOfExecution => 3;
    public bool IsDivisibleByFive(int number)
    {
        return number % 5 == 0;
    }
    public string ApplyRule(int number)
    {
        if (IsDivisibleByFive(number))
        {
            return "Buzz";
        }

        return null;
    }
}