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
                if (YesOrNo == "YES") 
                {
                    bankBalance = bankBalance - billPaymentPrice - 0.75;
                    Console.WriteLine("Your new account balancce is " + bankBalance);
                    }

                    else if (YesOrNo == "NO") 
                {
                    bankBalance = bankBalance - 0.75;
                    Console.WriteLine("Your new account balance is " + bankBalance);
                }
                    

            }
            else if (transactionName == "ACCOUNT BALANCE")
            {
                bankBalance = bankBalance - 0.75;
                Console.WriteLine("Your account balance is " + bankBalance);

            }
            
            else
            {
                Console.WriteLine("");
            }



            //Parking garage cost

            int minutes;
            int hours;
            double cost;


            Console.WriteLine("How many minutes were you parked in Sam's Parking Garage?");
            minutes = Convert.ToInt32(Console.ReadLine());
            hours = minutes / 60;
           if (minutes % 60 > 0)
            {
                hours += 1;
            }
            Console.WriteLine("You were parked for " + hours + " hours.");

            cost = 4 + ((hours -1) * 2.00);
            if (cost > 20)
            {
                cost = 20;
            }
            Console.WriteLine("You owe " + cost.ToString("C"));


            //Hurricane 


            int category; 

            Console.WriteLine("Which cateogry hurricane do you want to know the wind speed of?");
            Console.WriteLine("Type 1, 2, 3, 4 or 5");
            category = Convert.ToInt32(Console.ReadLine());

            switch (category)
            {
                case 1:
                 Console.WriteLine("74-95 mph/hr");
                 Console.WriteLine("64-82 kt/hr");
                 Console.WriteLine("119-153 km/hr");
                    break;
                case 2:
                    Console.WriteLine("90-110 mph/hr");
                    Console.WriteLine("83-95 kt/hr");
                    Console.WriteLine("154-177 km/hr");
                    break;
                case 3:
                 Console.WriteLine("111-130 mph/hr");
                 Console.WriteLine("96-113 kt/hr");
                 Console.WriteLine("178-209 km/hr");
                    break;
                case 4:
                    Console.WriteLine("131-155 mph/hr");
                    Console.WriteLine("114-135 kt/hr");
                    Console.WriteLine("210-249 km/hr");
                    break;
                case 5:
                    Console.WriteLine("Greater than 155 mph/hr");
                    Console.WriteLine("Greater than 135 kt/hr");
                    Console.WriteLine("Greater than 249 km/hr");
                    break;
            }



            //if (category == 1 ) 
            // {
            //     Console.WriteLine("74-95 mph/hr");
            //     Console.WriteLine("64-82 kt/hr");
            //     Console.WriteLine("119-153 km/hr");
            //  }
            // if (category == 2)
            //  {
            //     Console.WriteLine("90-110 mph/hr");
            //       Console.WriteLine("83-95 kt/hr");
            //       Console.WriteLine("154-177 km/hr");
            //   }
            //   if (category == 3)
            //  {
            //      Console.WriteLine(" mph/hr");
            //     Console.WriteLine(" kt/hr");
            //      Console.WriteLine(" km/hr");
            //  }

        }
    }
} 
