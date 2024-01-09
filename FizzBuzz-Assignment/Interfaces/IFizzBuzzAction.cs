namespace FizzBuzz_Assignment.Interfaces;

public interface IFizzBuzzAction
{
    bool ApplyNumber(int number);
    string ReceiveResult();
}