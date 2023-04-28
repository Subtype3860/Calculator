namespace Calculator;

public class Calculator : PrintRezult, ICalculator
{
    private Account _account;
    public Calculator(Account account): base(account)
    {
        _account = account;
    }
  
    public void Interest()
    {
        if (_account.Type!.Equals("Зарплатный"))
        {
            _account.Type = _account.Type;
            _account.Interest = 0.5;
        }
        else
        {
            _account.Interest = _account.Balance < 1000 ? 0.2 : 0.4;
        }
        
    }
}