namespace Calculator;
public class Programs
{
    public static void Main()
    {        
        Account account = new();
        Console.WriteLine("Указать тип счёта. По умолчанию [Обычный], либо пропишите [Зарплатный]:");
        account.Type = Console.ReadLine();
        Console.WriteLine("Укажите баланс счёта:");
        account.Balance = Double.Parse(Console.ReadLine()!);
        Calculator calculator = new Calculator(account);
        calculator.Interest();
        calculator.Print();
    }
}
