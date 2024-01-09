using FizzBuzz_Assignment.Interfaces;

namespace FizzBuzz_Assignment.DomainModels;

public class FizzBuzzAction: IFizzBuzzAction
{
    public bool ApplyNumber(int number)
    {
        return number % 3 == 0 && number % 5 == 0;
    }

    public string ReceiveResult()
    {
        return "FizzBuzz";
    }
}