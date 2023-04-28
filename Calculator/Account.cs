namespace Calculator;
public class Account
{
    private string _type = "Обычный";
    private double _balance;
    // тип учетной записи
    public string? Type
    {
        get => _type;
        set
        {
            if (value!.Equals("Зарплатный"))
                _type = value;
        }
    }
    // баланс учетной записи
    public double Balance
    {
        get => _balance;
        set
        {
            if (value >= 0)
                _balance = value;
        }
    }
    // процентная ставка
    public double Interest { get; set; }
}