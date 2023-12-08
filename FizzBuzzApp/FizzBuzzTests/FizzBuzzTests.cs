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
        Assert.That(evaluator.EvaluateRule(6), Is.EqualTo("Fizz"));
        Assert.That(evaluator.EvaluateRule(18), Is.EqualTo("Fizz"));
    }

    [Test]
    public void EvaluateRule_ShouldOutputBuzzForMultiplesOfFive()
    {
        Assert.That(evaluator.EvaluateRule(5), Is.EqualTo("Buzz"));
        Assert.That(evaluator.EvaluateRule(10), Is.EqualTo("Buzz"));
        Assert.That(evaluator.EvaluateRule(20), Is.EqualTo("Buzz"));
    }

    [Test]
    public void EvaluateRule_ShouldOutputFizzBuzzForMultiplesOfBothThreeAndFive()
    {
        Assert.That(evaluator.EvaluateRule(15), Is.EqualTo("FizzBuzz"));
        Assert.That(evaluator.EvaluateRule(30), Is.EqualTo("FizzBuzz"));
        Assert.That(evaluator.EvaluateRule(45), Is.EqualTo("FizzBuzz"));
    }

    [Test]
    public void EvaluateRule_ShouldOutputNumbersForOtherValues()
    {
        Assert.That(evaluator.EvaluateRule(2), Is.EqualTo("2"));
        Assert.That(evaluator.EvaluateRule(56), Is.EqualTo("56"));
        Assert.That(evaluator.EvaluateRule(92), Is.EqualTo("92"));
    }
}