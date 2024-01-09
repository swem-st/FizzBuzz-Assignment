using FizzBuzz_Assignment.Interfaces;

namespace FizzBuzz_Assignment.DomainModels;

public class FizzAction: IFizzBuzzAction
{
    public bool AddNumber(int number)
    {
        return number % 3 == 0;
    }

    public string ReceiveResult()
    {
        return "Fizz";
    }
}