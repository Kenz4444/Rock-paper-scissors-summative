namespace Rock_paper_scissors_summative
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int choice;
            Console.WriteLine("Hello and welcome to my rock paper scissors casino game!");
            Console.WriteLine("Would you like to view the rules(1) or go right into the game(2)?");
            int.TryParse(Console.ReadLine(), out choice);
            if (choice == 1)
            {
                Part1();
            }
            else if (choice== 2)
            {
                Part2();
            }

        }



        static void Part1()
        {
            Console.Clear();
            string ready;
            Console.WriteLine("THE RULES");
            Console.WriteLine();
            Console.WriteLine("\t 1. You have $500 current in your bank account.");
            Console.WriteLine();
            Console.WriteLine("\t 2. You will be asked how much money you would like to bet on each round, you can bet up to $200  per round");
            Console.WriteLine() ;
            Console.WriteLine("\t 3. Every round you will be prompted to pick either rock, paper, or scissors, as will the computer");
            Console.WriteLine();
            Console.WriteLine("\t 4. You will then get a count down and if what you picked beats the computer, the money you bet, will go to your \t account. If you lose, the money will be taken from your account");
            Console.WriteLine();
            Console.WriteLine("\t 5. IF you lose best out of three, you lose all your money!");
            Console.WriteLine();
            Console.WriteLine("READY TO PLAY? TYPE YES");
            ready= Console.ReadLine();
             if (ready.ToLower() == "yes")
            {
                Part2();
            }
            else
            {
                Part1();
            }
            

            
            
        }




        static void Part2()
        {
            double bankAccount = 500;
            string yesOrNoBet;
            double bettingAmount;
            bool done=false;
            int round = 1;
            int bettingMax = 200;
            int rock = 1, paper = 2, scissors = 3;


            //Random generator = new Random();
            //int randNum; 
            //randNum = generator.Next(1,4);

            while (!done)
            {
                Console.Clear();
                Console.WriteLine("\t \t \t \t \t \t WELCOME TO THE GAME!");
                Console.WriteLine("Right now you have $" + bankAccount + ". How much would you like to bet? your betting max is $200 (Just type the number)");
                
                while(!double.TryParse(Console.ReadLine(), out bettingAmount) || bettingAmount < 0 || bettingAmount > bettingMax)
                {
                    Console.WriteLine("Invalid bet. Try again");
                    Console.ReadLine();

                }
                
                    Console.Clear() ;
                    Console.WriteLine("Okay! You are betting " + bettingAmount + " on this round!");
                    Console.WriteLine("Choose one of the following:");
                    Console.WriteLine("\t Rock" + rock);
                    Console.WriteLine("\t 2.) paper");
                    Console.WriteLine("\t 3.) scissors");

                
               








            }





            


                    

                   
                       
                        
                        

                    

            }

                 
                //else if (yesOrNoBet.ToLower() == "no")
                //{
                //    Console.WriteLine("Okay good luck!");
                //}
            
            

        
    }
}
