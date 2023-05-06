namespace SelectionStatementExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a number from 1 - 1000");
            var r = new Random();
            var favNumber = r.Next(1, 1000);
            
            var userInput = int.Parse(Console.ReadLine());
            if (userInput < favNumber)
            {
                Console.WriteLine("number to low");

            }
            else if(userInput > favNumber) 
            {
                Console.WriteLine("number too high");
            }
            else 
            {
                Console.WriteLine("congratulation you guessed right");
            }
            // switch case exercise
            Console.WriteLine("what is your favorite subject");
            string subject = Console.ReadLine();
            switch (subject)
            {
                case "math":
                    Console.WriteLine("i hate math");
                    break;
                case "history":
                    Console.WriteLine("history is boring");
                    break;
                case "science":
                    Console.WriteLine("science is hard");
                    break;
                case "sport":
                    Console.WriteLine("sport is cool");
                    break;
                case "spanish":
                    Console.WriteLine("i dont care for it");
                    break;
                default: Console.WriteLine("i dont know that subject");
                    break;
            }


        }
        

    }  
}   
