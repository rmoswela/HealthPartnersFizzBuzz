namespace FizzBuzzAPI;

public class FizzRule : IRule
{
    public int OrderOfExecution => 2;
    public bool IsDivisibleByThree(int number)
    {
        return number % 3 == 0;
    }
    public string ApplyRule(int number)
    {
        if (IsDivisibleByThree(number))
        {
            return "Fizz";
        }

        return null;
    }
}