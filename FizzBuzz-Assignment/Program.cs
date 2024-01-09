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
        var standardRule = new StandardAction(0);

        var fizzBuzz = new FizzBuzz(new IFizzBuzzAction[] { fizzBuzzAction, buzzAction, fizzAction, standardRule });

        for (int i = 1; i <= 100; i++)
        {
            Console.WriteLine(fizzBuzz.Execute(i));
        }
    }
}