using FizzBuzzAPI;

namespace FizzBuzzTests;

public class Tests
{
    private RuleEvaluator evaluator;

    [SetUp]
    public void Setup()
    {
        var rules = new IRule[] { new FizzRule(), new BuzzRule(), new FizzBuzzRule(new FizzRule(), new BuzzRule())};
        evaluator = new RuleEvaluator(rules);
    }

    [Test]
    public void EvaluateRule_ShouldOutputFizzForMultiplesOfThree()
    {
        Assert.That(evaluator.EvaluateRule(3), Is.EqualTo("Fizz"));
    }

    [Test]
    public void EvaluateRule_ShouldOutputBuzzForMultiplesOfFive()
    {
        Assert.That(evaluator.EvaluateRule(5), Is.EqualTo("Buzz"));
    }

    [Test]
    public void EvaluateRule_ShouldOutputFizzBuzzForMultiplesOfBothThreeAndFive()
    {
        Assert.That(evaluator.EvaluateRule(15), Is.EqualTo("FizzBuzz"));
    }
}