public class InvalidEmailException : Exception
{
    public InvalidEmailException(string message) : base(message) { }
}

public class EmailHandler
{
    private string email;

    public void SetEmail(string email)
    {
        if (!email.Contains("@"))
        {
            throw new InvalidEmailException("Некорректный адрес электронной почты: отсутствует символ '@'.");
        }
        this.email = email;
        Console.WriteLine("Email установлен: " + email);
    }
}

class Program
{
    static void Main(string[] args)
    {
        EmailHandler emailHandler = new EmailHandler();

        Console.WriteLine("Введите адрес электронной почты:");
        string userInput = Console.ReadLine();

        try
        {
            emailHandler.SetEmail(userInput);
        }
        catch (InvalidEmailException ex)
        {
            Console.WriteLine($"Ошибка: {ex.Message}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Произошла непредвиденная ошибка: {ex.Message}");
        }
    }
}
