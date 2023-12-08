namespace FizzBuzzAPI;

public interface IRule
{
    int OrderOfExecution { get; }
    string ApplyRule(int number);
}