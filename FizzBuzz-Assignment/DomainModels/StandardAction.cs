using FizzBuzz_Assignment.Interfaces;

namespace FizzBuzz_Assignment.DomainModels;

// Fallback rule for numbers that don't meet any of the above conditions
public class StandardAction : IFizzBuzzAction
{
    private int _number;

    public StandardAction(int number)
    {
        _number = number;
    }

    public bool ApplyNumber(int number)
    {
        return true;
    }

    public void SetNumber(int number)
    {
        _number = number;
    }

    public string ReceiveResult()
    {
        return _number.ToString();
    }
}