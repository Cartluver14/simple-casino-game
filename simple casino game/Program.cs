using System.Runtime.InteropServices;

namespace simple_casino_game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int result;
            int score = 3;
            int tails = 0;
            int heads = 0;
            string answer, again;
            bool done;


            Console.WriteLine("Hello welcome to my casino game");
            Console.WriteLine("Quick Run down of the rules. The Computer will ask you heads or tails. points are gained or lost depending if the anwser is right or wrong, Good Luck");




            done = false;
            while (!done)
            {
                
                Console.WriteLine("heads or tails?");
                answer = Console.ReadLine().ToLower();
                result = rnd.Next(2);
                if (result == 1 && answer == "tails")
                    
                {
                    Console.WriteLine("Tails");
                    Console.WriteLine("Correct");                    
                    tails = tails + 1;
                    score = score + 1;
                    Console.WriteLine(" Your score is "  +score);


                }
                 else if (result == 0 && answer == "heads")
                {                   
                    Console.WriteLine("Heads");
                    Console.WriteLine("correct");
                    heads = heads + 1;
                    score = score + 1;
                    Console.WriteLine(" Your score is "   + score);
                }
                if (result == 0 && answer == "tails")
                {

                    Console.WriteLine("Heads!");
                    Console.WriteLine("Incorrect, try again");
                    
                    score = score - 1;
                    Console.WriteLine(" Your score is "  +   score);

                }
                if (result == 1 && answer == "heads")
                {

                    Console.WriteLine("Tails" +
                        "!");
                    Console.WriteLine("Incorrect, try again");

                    score = score - 1;
                    Console.WriteLine(" Your score is " +   score);

                }
                if (score == 0)
                {
                    done = true;

                    Console.WriteLine("Good game, better luck next time");
                    
                }
                else
                {
                    Console.WriteLine("Would you like to play again?");
                    again = Console.ReadLine().ToLower();

                    if (again == "no")
                    {
                        done = true ;
                    }


                }
                





            }




            

        }
    }
}
