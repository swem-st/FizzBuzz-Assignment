using FizzBuzz_Assignment.Interfaces;

namespace FizzBuzz_Assignment.DomainModels;

public class BuzzAction: IFizzBuzzAction
{
    public bool ApplyNumber(int number)
    {
        return number % 5 == 0;
    }

    public string ReceiveResult()
    {
        return "Buzz";
    }
}