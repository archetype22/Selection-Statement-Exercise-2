namespace SelectionStatementsExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your favorite subject in school?");
            var subject = Console.ReadLine();
            
            switch (subject.ToLower()) 
            {
                    case "English":
                    Console.WriteLine("English can be tedious.");
                    break;
                    case "History":
                    Console.WriteLine("History was my favorite subject too!");
                    break;
                    case "Math":
                    Console.WriteLine("Math is a pretty difficult subject.");
                    break;
                    case "Reading":
                    Console.WriteLine("Reading is great for your imagination!");
                    break;
                    case "Science":
                    Console.WriteLine("Science is really fun!!");
                    break;  
                    default: Console.WriteLine($"Interesting. I don't know that subject, but {subject} sure sounds neat.");
                    break;  
            }       
        }
    }
}