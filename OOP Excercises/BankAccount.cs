using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Excercises
{
    internal class BankAccount
    {
        public string? AccId { get; set; }
        public string? CardId { get; set; }
        public string? Name { get; set; }
        public decimal Balance { get; set; }
        public int Transactions { get; set; }
        public static int OnlineUsers { get; set; }

        public BankAccount(string? accId, string? cardId, string? name, decimal balance)
        {
            this.CardId = cardId;
            this.Name = name;
            this.Balance = balance;
            this.Transactions = 0;
            OnlineUsers++;
        }

        public void Deposit(decimal amount) 
        {
            if(amount == 0)
                Console.WriteLine("Enter Valid Value");
            this.Balance += amount;
            Console.WriteLine($"Successfully Deposited {amount}");
            Console.WriteLine($"Your Balance Is : {Balance}");
            Transactions++;
        }
        public void Withdraw(decimal amount) 
        {
            if(amount > Balance)
                Console.WriteLine("Enter Valid Value");
            this.Balance -= amount;
            Console.WriteLine($"Successfully Withdrawed {amount}");
            Console.WriteLine($"Your Balance Is : {Balance}");
            Transactions++;
        }

        public void ViewBalance() 
        {
            Console.WriteLine($"Your Current Balance is : {Balance:C2}, {DateTime.Now} ");
        }
    }
}
