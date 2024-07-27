using System.Net.NetworkInformation;

namespace SelectionStatementsExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your favorite subject in school?");
            var subject = Console.ReadLine();
    
            switch (subject)
            {
                case "Math" or "math":
                    Console.WriteLine($"Your favorite subject is {subject}.\nYou're a mathmatical genius!");
                    break;
                case "History" or "history":
                    Console.WriteLine($"Your favorite subject is {subject}.\nCan you tell me some things about the Revolutionary War?");
                    break;
                case "Computer Science" or "computer science":
                    Console.WriteLine($"Your favorite subject is {subject}.\nCan you teach me how to code??");
                    break;
                case "English" or "english":
                    Console.WriteLine($"Your favorite subject is {subject}.\n Would you mind proofreading my essay?");
                    break;
                case "Physical Education" or "physical education":
                    Console.WriteLine($"Your favorite subject is {subject}.Wow! You sure are strong.");
                    break;
                default:
                    Console.WriteLine($"Your favorite subject is {subject}");
                    break;
            }
        }
    }
}