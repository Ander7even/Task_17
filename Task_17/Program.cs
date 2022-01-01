using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_17 //Обобщения
{
    class Program
    {

        static void Main(string[] args)
        {
            BankAccount<int> bankAccount1 = new BankAccount<int>(12345, 1012.45, "Иванов");
            bankAccount1.print();

            BankAccount<string> bankAccount2 = new BankAccount<string>("AB-12345", 1245.56, "Петров");
            bankAccount2.print();






            Console.ReadKey();
        }
    }

    
    class BankAccount<T> 
    {

        private T accountNumber { get; set; }
        private double accountBalance { get; set; }
        private string accountHolder { get; set; }

        public BankAccount(T number, double balance, string holder)
        {
            accountNumber = number;
            accountBalance = balance;
            accountHolder = holder;
        }
        public void print()
        {
            Console.Write("Номер счета:{0} ", accountNumber);
            Console.Write("Баланс:{0} ", accountBalance);
            Console.WriteLine("Держатель счета:{0} ", accountHolder);
        }


    }
}
