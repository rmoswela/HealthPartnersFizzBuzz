using System.Reflection;
using FizzBuzzAPI;

// Load FizzBuzzAPI assembly
var assembly = Assembly.Load("FizzBuzzAPI");

// Retrieve RuleEvaluator type
// Information contains details about the class's structure, methods, and properties
var evaluatorType = assembly.GetType("FizzBuzzAPI.RuleEvaluator");

// Retrieve the constructor with the specified generic type parameter
var bindingFlags = BindingFlags.Instance | BindingFlags.Public;
var constructors = evaluatorType.GetConstructors(bindingFlags);

// The FirstOrDefault method filters list to find first constructor that matches the specified conditions.
var constructor = constructors.FirstOrDefault(c =>
    c.GetParameters().Length == 1 &&
    c.GetParameters()[0].ParameterType == typeof(IEnumerable<IRule>)
);

// Create an instance of RuleEvaluator
var fizzRule = new FizzRule();
var buzzRule = new BuzzRule();
var fizzBuzzRule = new FizzBuzzRule(fizzRule, buzzRule);
var ruleArray = new IRule[] { fizzRule, buzzRule, fizzBuzzRule };
var evaluator = Activator.CreateInstance(evaluatorType, new object[] { ruleArray });

// Create an instance of FizzBuzzGenerator
var generator = new FizzBuzzGenerator(evaluator as RuleEvaluator);

// Generate FizzBuzz output for a range of numbers
generator.GenerateFizzBuzz(1, 100);
