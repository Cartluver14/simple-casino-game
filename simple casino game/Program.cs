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
            string answer;


           
            

            while (score >= 0)
            {
                Console.WriteLine("heads or tails?");
                answer = Console.ReadLine().ToLower();
                result = rnd.Next(2);
                if (result == 1 && answer == "tails")
                    Console.WriteLine("Correct");
                {
                    Console.WriteLine("Tails");
                    tails = tails + 1;
                    score = score + 1;


                }
                else if (result == 0)
                {

                    Console.WriteLine("Heads");
                    heads = heads + 1;
                    score = score + 1;
                }




            }


            
            
            Console.WriteLine("Hello welcome to my casino game ");

        }
    }
}
