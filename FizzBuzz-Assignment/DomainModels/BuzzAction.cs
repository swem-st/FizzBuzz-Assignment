using FizzBuzz_Assignment.Interfaces;

namespace FizzBuzz_Assignment.DomainModels;

public class BuzzAction: IFizzBuzzAction
{
    public bool AddNumber(int number)
    {
        return number % 5 == 0;
    }

    public string ReceiveResult()
    {
        return "buzz";
    }
}