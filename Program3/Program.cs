using System.Security.Cryptography.X509Certificates;

namespace Program3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Witaj w aplikacji do obliczania długości przekątnej prostokąta.");
            Console.WriteLine("Aby obliczyć przekątną potrzebujemy danych na temat długości boków.");

            Console.WriteLine(string.Empty);

            double userInputOneChanged;
            bool isNotANumber = false;
            do
            {
                Console.WriteLine("Podaj długość pierwszego boku:");

                isNotANumber = double.TryParse(Console.ReadLine(), out userInputOneChanged);

                if (!isNotANumber)
                {
                    Console.WriteLine("To nie jest wartość liczbowa! Wprowadź ponownie długość pierwszego boku używając w tym celu wartości liczbowych.");
                }
            }
            while (!isNotANumber);

            Console.WriteLine(string.Empty);

            double userInputTwoChanged;
            bool isNotANumberNext = false;
            do
            {
                Console.WriteLine("Podaj długość drugiego boku:");

                isNotANumberNext = double.TryParse(Console.ReadLine(), out userInputTwoChanged);

                if (!isNotANumberNext)
                {
                    Console.WriteLine("To nie jest wartość liczbowa! Wprowadź ponownie długość drugiego boku używając w tym celu wartości liczbowych.");
                }
            }
            while (!isNotANumberNext);

            Console.WriteLine(string.Empty);

            Console.WriteLine("Przekątna prostokąta wynosi:");
            int power = 2;
            Console.WriteLine(Math.Sqrt(Math.Pow(userInputOneChanged, power) + Math.Pow(userInputTwoChanged, power)));
        }  
    }
}
