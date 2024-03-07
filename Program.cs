using System.ComponentModel.Design;

namespace Topic_5_Assignment
{
    internal class Program
    { public static void bank()
        {
        }
        static void Main(string[] args)
        {
            double bankBalance;
            string name;
            string transactionName;
            double depositAmount;
            double withdrawlAmount;
            string billName;
            double billPaymentPrice;
            string YesOrNo;
            Random generator = new Random();
            bankBalance = 150.00;
            //Simple Banking Machine 
            Console.WriteLine("Welcome to the Bank of Blorb");
            Console.WriteLine("Please enter your name to sign into your bank account.");
            name = Console.ReadLine();
            Console.WriteLine("Hi, " + name + ". Your current balance is $" + bankBalance);
            Console.WriteLine("Please type the name of the type of transaction you would like to complete. ($0.75 fee)");
            Console.WriteLine("Deposit, Withdrawl, Bill Payment, Account Balance");
            transactionName = Console.ReadLine();
            transactionName = transactionName.ToUpper();
            if (transactionName == "DEPOSIT")
            {
                Console.WriteLine("How much money would you like to deposit?");
                depositAmount = Convert.ToDouble(Console.ReadLine());
                bankBalance = bankBalance + depositAmount - 0.75;
                Console.WriteLine("Your new bank balance is " + bankBalance.ToString("C"));
            }

            else if (transactionName == "WITHDRAWL") 
            {
                Console.WriteLine("How much money would you like to withdrawl?");
                withdrawlAmount = Convert.ToDouble(Console.ReadLine());
                bankBalance = bankBalance - withdrawlAmount - 0.75;
                Console.WriteLine("Your new bank balance is " + bankBalance.ToString("C"));

            }
            else if (transactionName == "BILL PAYMENT")
            {
                Console.WriteLine("What is the name of the bill you would like to pay?");
                billName = Console.ReadLine();
                billPaymentPrice = Convert.ToDouble(generator.Next(25, 75));
                Console.WriteLine("Your " + billName + " bill costs " + billPaymentPrice.ToString("C") + ". Would you like to pay it now? (Type Yes or No)");
                YesOrNo = Console.ReadLine();
                YesOrNo = YesOrNo.ToUpper();
                if (YesOrNo == "YES") ;
                {
                    bankBalance = bankBalance - billPaymentPrice - 0.75;
                    Console.WriteLine("Your new bank balancce is " + bankBalance);
                }
                if (YesOrNo == "NO") ;
                {
                    Console.WriteLine("Would you like to complete a different transaction?"); //??
                    YesOrNo = Console.ReadLine();
                    if (YesOrNo == "YES")
                    {
                        bank();
                    }
                }

            }
            else if (transactionName == "ACCOUNT BALANCE")
            {
                bankBalance = bankBalance - 0.75;
                Console.WriteLine("Your account balance is " + bankBalance);

            }
        }
    }
} 
