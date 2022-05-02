using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    internal class Program
    {
        class Bank
        {
            int money = 23000;
            String accountName = "AJAY";
            String accountNum;
            static String bankName = "HDFC";
            static public int updatedBalance;
            public void depositMoney()
            {

                Console.WriteLine("Enter the deposit Amount :");
                int depositMoney = int.Parse(Console.ReadLine());
                updatedBalance = money + depositMoney;
                if (depositMoney <= 100)
                {
                    Console.WriteLine(" Add minimum amount of Money 1000 ");
                }
                else
                {
                    Console.WriteLine(" total balance  " + accountName + " After deposit  " + updatedBalance);
                }

            }
            public void withdrawMoney()
            {
                try
                {
                    Console.WriteLine("Enter the account name  " + accountName + " accont balance: " + updatedBalance);
                    Console.WriteLine("Enter the amount how much you want to withdraw is:");
                    int withdraw = int.Parse(Console.ReadLine());
                    updatedBalance = updatedBalance - withdraw;
                    if (withdraw > updatedBalance)
                    {
                        Console.WriteLine(" Balance does not Sufficient");
                    }
                    else
                    {
                        Console.WriteLine(" Remaining Updated balance " + accountName + " after withdrawal  " + updatedBalance);
                    }

                }
                catch (Exception)
                {
                    Console.WriteLine(" The enter balance in number whose in words are not taken to the inputmissmatch exception ");
                }
            }
            public void Balance()
            {
                Console.WriteLine("Display to the " + bankName + "bank details ");
                Console.WriteLine("Enter account number  ");
                accountNum = Console.ReadLine();
                Console.WriteLine("Display  your account balance is : " + money);
            }
        }
        static void Main(string[] args)
        {
            Bank details = new Bank();
            details.Balance();
            details.depositMoney();
            details.withdrawMoney();
            Console.ReadLine();

        }

    }
}
