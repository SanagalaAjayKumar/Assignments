using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    public class WithdrawnException : ApplicationException
    {
        public WithdrawnException(string msg) : base(msg)
        {

        }
    }
    public class Bank
    {
        float Amount = 20000.00f;
        float Balance;
        string Account_Name;
        string Account_Number;

        public Bank()
        {
            Console.WriteLine("Enter Account Number : ");
            Account_Number = Console.ReadLine();
            Console.WriteLine("Enter  Account holder Name :");
            Account_Name = Console.ReadLine();

            Console.WriteLine($"The Account details is : Account Number {Account_Number}, Account Holder Name is {Account_Name}, Amount is {Amount}");

        }


        public void DepositeAmount()
        {
            Console.WriteLine("Enter the Deposited Amount : ");
            float DepositeAmount = Convert.ToSingle(Console.ReadLine());

            if (DepositeAmount == 0)
            {
                Console.WriteLine("Deposite the minimum amount above 1000.00 ");

            }
            else
            {
                Balance = Amount + DepositeAmount;
                Console.WriteLine("Your Account Balance is After amount deposite : " + Balance);
            }
        }

        public void Amount_Withdrawn()
        {

            Console.WriteLine("Enter the With Drawn Amount : ");
            float Withdrawn_Amount = Convert.ToSingle(Console.ReadLine());


            if (Withdrawn_Amount > Balance)
            {
                throw (new WithdrawnException("Insufficent balance"));
            }
            else
            {
                Balance = Balance - Withdrawn_Amount;
                Console.WriteLine("Your Account Balance is After With Draw the amount :" + Balance);
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Bank details = new Bank();
            try
            {
                details.DepositeAmount();
                details.Amount_Withdrawn();

            }
            catch (WithdrawnException we)
            {
                Console.WriteLine(we.Message);
            }
            catch (FormatException fe)
            {
                Console.WriteLine($"Enter only numbers ", fe);
            }
            Console.Read();
        }
    }

}
