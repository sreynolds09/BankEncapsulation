namespace BankEncapsulation
{
    public class Program
    {
        static void Main(string[] args)
        {
            var account = new BankAccount();
            Console.WriteLine("How much do you want to deposit");
            var depositAmount = double.Parse(Console.ReadLine());
            account.Deposit(depositAmount);
            Console.WriteLine($"Thank you! Your balanace is now {account.GetBalance()}");
        }
    }
}
