using Strategy.Pattern.Classes;

namespace Strategy.ConsoleTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var output = new Output(new Printer());
            output.Print();

            output = new Output(new Console());
            output.Print();

            System.Console.ReadKey();
        }
    }
}
