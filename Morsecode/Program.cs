namespace Morsecode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //We collect the users input
            Console.WriteLine("Indtast det du vil oversætte");
            string userInput = Console.ReadLine();
            
            //This piece so that we can have translate more than one letter at once
            foreach (char item in userInput)
            {
                
                //this we use to translate the input
                switch (item)
                {
                    case 'a':
                        Console.Write("· —");
                        break;
                    case 'b':
                        Console.Write("— · · ·");
                        break;
                    case 'c':
                        Console.Write("— · — ·");
                        break;
                    case 'd':
                        Console.Write("— · ·");
                        break;
                    case 'e':
                        Console.Write("·");
                        break;
                    case 'f':
                        Console.Write("· · — ·");
                        break;
                    case 'g':
                        Console.Write("— — · ");
                        break;
                    case 'h':
                        Console.Write("· · · ·");
                        break;
                    case 'i':
                        Console.Write("· ·");
                        break;
                    case 'j':
                        Console.Write("· — — —");
                        break;
                    case 'k':
                        Console.Write("— · —");
                        break;
                    case 'l':
                        Console.Write("· — · ·");
                        break;
                    case 'n':
                        Console.Write("— ·");
                        break;
                    case 'm':
                        Console.Write("— —");
                        break;
                    case 'o':
                        Console.Write("— — —");
                        break;
                    case 'p':
                        Console.Write("· — — ·");
                        break;
                    case 'q':
                        Console.Write("— — · —");
                        break;
                    case 'r':
                        Console.Write("· — ·");
                        break;
                    case 's':
                        Console.Write("· · ·");
                        break;
                    case 't':
                        Console.Write("—");
                        break;
                    case 'u':
                        Console.Write("· · —");
                        break;
                    case 'v':
                        Console.Write("· · · —");
                        break;
                    case 'w':
                        Console.Write("· — —");
                        break;
                    case 'x':
                        Console.Write("— · · —");
                        break;
                    case 'y':
                        Console.Write("— · · —");
                        break;
                    case 'z':
                        Console.Write("— — · ·");
                        break;
                    case 'æ':
                        Console.Write("· — · —");
                        break;
                    case 'ø':
                        Console.Write("— — — ·");
                        break;
                    case 'å':
                        Console.Write("· — — · —");
                        break;
                    case '1':
                        Console.WriteLine("· — — — —");
                        break;
                    case '2':
                        Console.WriteLine("· · — — —");
                        break;
                    case '3':
                        Console.WriteLine("· · · — —");
                        break;
                    case '4':
                        Console.WriteLine("· · · · —");
                        break;
                    case '5':
                        Console.WriteLine("· · · · ·");
                        break;
                    case '6':
                        Console.WriteLine("— · · · ·");
                        break;
                    case '7':
                        Console.WriteLine("— — · · ·");
                        break;
                    case '8':
                        Console.WriteLine("— — — · ·");
                        break;
                    case '9':
                        Console.WriteLine("— — — — ·");
                        break;
                    case '0':
                        Console.WriteLine("— — — — —");
                        break;
                    case '.':
                        Console.WriteLine("· — · — · —");
                        break;
                    case ',':
                        Console.WriteLine("— — · · — —");
                        break;
                    case ':':
                        Console.WriteLine("— — — · · ·");
                        break;
                    case '?':
                        Console.WriteLine("· · — — · ·");
                        break;
                    case '\'':
                        Console.WriteLine("· — — — — ·");
                        break;
                    case '-':
                        Console.WriteLine("— · · · · —");
                        break;
                    case '/':
                        Console.WriteLine("— · · — ·");
                        break;
                    case '(':
                        Console.WriteLine("— · — — ·");
                        break;
                    case ')':
                        Console.WriteLine("— · — — · —");
                        break;
                    case '"':
                        Console.WriteLine("· — · · — ·");
                        break;
                    case '×':
                        Console.WriteLine("— · · —");
                        break;
                    case '@':
                        Console.WriteLine("· — — · — ·");
                        break;
                    default:
                        break;

                }
            }
            
            Console.Read();

            
        }
    }
}