using FizzBuzz_Assignment.Interfaces;

namespace FizzBuzz_Assignment.DomainModels;

public class FizzBuzz
{
    private readonly IFizzBuzzAction[] actions;

    public FizzBuzz(IFizzBuzzAction[] actions)
    {
        this.actions = actions;
    }

    public string Execute(int number)
    {
        foreach (var action in actions)
        {
            if (action.ApplyNumber(number))
            {
                return action.ReceiveResult();
            }
        }
        return string.Empty;
    }
}