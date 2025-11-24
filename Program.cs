using Money.Entities;
using System.Xml;

namespace Money
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Digite os dados da conta bancária: ");
                Console.Write("Número: ");
                int number = int.Parse(Console.ReadLine());
                Console.WriteLine("Nome: ");
                string name = Console.ReadLine();
                Console.WriteLine("Saldo inicial:  ");
                double balance = double.Parse(Console.ReadLine());
                Console.WriteLine("Limite de saque: ");
                double withdrawLimit = double.Parse(Console.ReadLine());

                Account conta = new Account(number, name, balance, withdrawLimit);

                Console.WriteLine("Digite o valor do saque: ");
                double withdraw = double.Parse(Console.ReadLine());
                Console.WriteLine("Novo saldo: ");
                conta.Withdraw(withdraw);
                Console.WriteLine(conta.Balance);
            }
            catch (Exception erro)
            {
                Console.WriteLine(erro.Message);
            }
        }
    }
}
