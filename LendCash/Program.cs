using System;

namespace LendCash
{
    class Program
    {
        static void Main(string[] args)
        {
            Guy joe = new Guy()
            {
                Name = "joe",
                Cash = 50
            };

            Guy bob = new Guy()
            {
                Name = "bob",
                Cash = 100
            };

            while (true)
            {
                joe.WriteMyInfo();
                bob.WriteMyInfo();

                Console.Write("Enter an amount: ");
                string howMuch = Console.ReadLine();

                if (howMuch == "") return;
                if (int.TryParse(howMuch,out int result))
                {
                    Console.Write("Who should give the cash: ");
                    string whichGuy = Console.ReadLine();

                    if (whichGuy == "joe")
                    {
                        int cashGiven = joe.GiveCash(result);
                        bob.ReceiveCash(result);
                    }
                    else if (whichGuy == "bob")
                    {
                        int cashGiven = bob.GiveCash(result);
                        joe.ReceiveCash(result);
                    }
                    else
                    {
                        Console.WriteLine("Please Enter 'joe' or 'bob'");
                    }
                }
                else
                {
                    Console.WriteLine("Please enter an amount( or blank line to exit).");
                }
            }
        }
    }
}
