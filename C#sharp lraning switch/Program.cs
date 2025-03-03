namespace C_sharp_lraning_switch
{
    internal class Program
    {
        static void Main(string[] args)
        {

            bool play_again = true;
            while (play_again)
            {

                Random random = new Random();
                int min = 1;
                int max = 100;
                int correct_number = random.Next(min, max + 1);
                int guess_count = 0;
                
                while (true)
                {
                   
                    Console.WriteLine($"guess a number between ({min}) and ({max}) ");
                    int user_guess = Convert.ToInt32(Console.ReadLine());//users guess
                    guess_count += 1;

                    if (user_guess == correct_number)
                    {
                        Console.WriteLine($"CONGRATS the correct answer was ({correct_number})");
                        Console.WriteLine($"your total number of guesses was ({guess_count})");
                        Console.WriteLine("Would you like to play again? \nY/N");

                        string user_input = (Console.ReadLine());//continue
                        user_input = user_input.ToUpper();

                        if (user_input == "N")
                        {
                            play_again = false;
                        }
                        
                        Console.WriteLine("Thank you for playing.....");
                        break;//reset number

                    }
                    else if (user_guess < correct_number)
                    {
                        Console.WriteLine("guess higher");
                    }
                    else
                    {
                        Console.WriteLine("guess lower");
                    }
                }
            }
        }
    }
}
