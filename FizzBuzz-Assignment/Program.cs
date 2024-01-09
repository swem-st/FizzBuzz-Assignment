using FizzBuzz_Assignment.DomainModels;
using FizzBuzz_Assignment.Interfaces;

namespace FizzBuzz_Assignment;

abstract class Program
{
    static void Main()
    {
        // Essential logic
        var fizzAction = new FizzAction();
        var buzzAction = new BuzzAction();
        var fizzBuzzAction = new FizzBuzzAction();
        var standardAction = new StandardAction(0); // Instantiate StandardAction with any initial number

        var fizzBuzz = new FizzBuzz(new IFizzBuzzAction[] { fizzBuzzAction, buzzAction, fizzAction, standardAction });

        for (int i = 1; i <= 100; i++)
        {
            standardAction.SetNumber(i);
            Console.WriteLine(fizzBuzz.Execute(i));
        }
    }
}