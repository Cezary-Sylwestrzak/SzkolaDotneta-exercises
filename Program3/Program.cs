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

            Console.WriteLine("Podaj długość pierwszego boku.");
            string valueNumberOne = Console.ReadLine();
            int valueNumberOneInt = int.Parse(valueNumberOne);

            Console.WriteLine(string.Empty);

            Console.WriteLine("Podaj długość drugiego boku.");
            string valueNumberTwo = Console.ReadLine();
            int valueNumberTwoInt = int.Parse(valueNumberTwo);

            Console.WriteLine(string.Empty);

            Console.WriteLine("Przekątna prostokąta wynosi:");
            int power = 2;
            Console.WriteLine(Math.Sqrt(Math.Pow(valueNumberOneInt, power) + Math.Pow(valueNumberTwoInt, power)));
 
        }  
    }
}
