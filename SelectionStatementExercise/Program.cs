namespace SelectionStatementExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            int favNumber = r.Next(1, 100);
            //int favNumber = 5;
            int userInput = 0;

            while (favNumber != userInput)
            {
                Console.WriteLine("Guess my favorite number 1-100:");
                userInput = int.Parse(Console.ReadLine());

                if (userInput < favNumber)
                {
                    Console.WriteLine("Too low.");
                }

                else if (userInput > favNumber)
                {
                    Console.WriteLine("Too high.");
                }

                else
                {
                    Console.WriteLine("You got my favorite number!");
                }
            }
        }
    }
}
