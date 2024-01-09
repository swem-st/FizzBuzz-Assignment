using FizzBuzz_Assignment.Interfaces;

namespace FizzBuzz_Assignment.DomainModels;

// Fallback rule for numbers that don't meet any of the above conditions
public class StandardAction : IFizzBuzzAction
{
    private readonly int number;

    public StandardAction(int number)
    {
        this.number = number;
    }

    public bool AddNumber(int number)
    {
        return true;
    }

    public string ReceiveResult()
    {
        return number.ToString();
    }
}