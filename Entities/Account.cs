using Money.Entities.Exceções;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Money.Entities
{
    class Account : AccountException
    {
        public int Number { get; set; }
        public string Name { get; set; }
        public double Balance { get; set; }
        public double WithdrawLimit { get; set; }
        public Account()
        {
        }



        public Account(int number, string name, double balance, double withdrawLimit) 
        {
            
                Number = number;
                Name = name;
                Balance = balance;
                WithdrawLimit = withdrawLimit;
        }

        public void Deposit(double balance)
        {

            Balance += balance;
        }

        public void Withdraw(double withdraw)
        {
            Balance -= withdraw;
            if (Balance <= 0)
            {
                throw new AccountException("Erro: Sua conta não possuí saldo!");
            }
            if (withdraw > WithdrawLimit)
            {
                throw new AccountException("O valor do saque excedeu o limite da conta!");
            }
            if(Balance < withdraw)
            {
                throw new AccountException("O valor do saque excede o valor da conta!");
            }
           

        }
    }
}
