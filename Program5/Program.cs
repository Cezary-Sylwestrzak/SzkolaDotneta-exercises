namespace Program5
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Witaj nowy pracowniku!");            
            Console.WriteLine("Za chwilę przeprowadzimy Cię przez proces rejestracji w systemie.");
            Console.WriteLine("Kiedy skończymy, będziesz figurował w systemie jako nowy pracownik.");
            Console.WriteLine("Teraz zadamy Ci kilka pytań, prosimy o szczerą odpowiedź.");

            Console.WriteLine(string.Empty);

            Console.WriteLine("Pytanie numer 1:");
            Console.WriteLine("Podaj swoje imię.");
            string firstName = Console.ReadLine();

            Console.WriteLine(string.Empty);

            Console.WriteLine("Pytanie numer 2:");
            Console.WriteLine("Podaj swoje nazwisko.");
            string lastName = Console.ReadLine();

            Console.WriteLine(string.Empty);

            Console.WriteLine("Pytanie numer 3:");
            int age;
            bool ageIsANumber = false;
            do
            {
                Console.WriteLine("Podaj swój wiek, samą liczbę.");

                ageIsANumber = int.TryParse(Console.ReadLine(), out age);

                if (!ageIsANumber)
                {
                    Console.WriteLine("To nie jest wartość liczbowa! Podaj ponownie swój wiek używając w tym celu TYLKO wartości liczbowej.");
                }
            }
            while (!ageIsANumber);

            Console.WriteLine(string.Empty);

            Console.WriteLine("Pytanie numer 4:");
            Console.WriteLine("Wybierz swoją płeć.");
            
            Console.WriteLine(string.Empty);
            
            Console.WriteLine("1.Mężczyzna.");
            Console.WriteLine("2.Kobieta.");
            string sex = Console.ReadLine();
            int chosedSex = int.Parse(sex);

            Console.WriteLine(string.Empty);

            Console.WriteLine("Pytanie numer 5:");
            Console.WriteLine("Podaj swój numer telefonu.");
            string telephoneNumber = Console.ReadLine();
            
            Console.WriteLine(string.Empty);

            Console.WriteLine("Pytanie numer 6:");
            Console.WriteLine("Podaj swój adres zamieszkania.");
            string adress = Console.ReadLine();

            Console.WriteLine(string.Empty);

            Console.WriteLine("Pytanie numer 7:");
            Console.WriteLine("Podaj swój numer PESEL.");
            string pesel = Console.ReadLine();
            
            Console.WriteLine(string.Empty);
            
            Console.WriteLine("Pytanie numer 8:");
            Console.WriteLine("Podaj swój adres email.");
            string emailAdress = Console.ReadLine();
           
            Console.WriteLine(string.Empty);

            Console.WriteLine("Pytanie numer 9:");
            double height;
            bool heightIsANumber = false;
            do
            {
                Console.WriteLine("Podaj swój wzrost, samą liczbę.");

                heightIsANumber = double.TryParse(Console.ReadLine(), out height);

                if (!heightIsANumber)
                {
                    Console.WriteLine("To nie jest wartość liczbowa! Podaj ponownie swój wzrost używając w tym celu TYLKO wartości liczbowej.");
                }
            }
            while (!heightIsANumber);

            Console.WriteLine(string.Empty);
            
            Console.WriteLine("Pytanie numer 10:");

            double weight;
            bool weightIsANumber = false;
            do
            {
                Console.WriteLine("Podaj swóją wagę, samą liczbę.");

                weightIsANumber = double.TryParse(Console.ReadLine(), out weight);

                if (!weightIsANumber)
                {
                    Console.WriteLine("To nie jest wartość liczbowa! Podaj ponownie swoją wagę używając w tym celu TYLKO wartości liczbowej.");
                }
            }
            while (!weightIsANumber);


            Console.WriteLine(string.Empty);

            Console.WriteLine("Pytanie numer 11:");
            Console.WriteLine("Podaj swój kolor oczu");
            string eyesColor = Console.ReadLine();

            Console.WriteLine(string.Empty);

            Console.WriteLine("Pytanie numer 12:");
            Console.WriteLine("Podaj nadany ci numer pracownika.");
            string employeeNumber = Console.ReadLine();
            
            Console.WriteLine(string.Empty);
            
            Console.WriteLine("To już wszystkie pytania, sprawdz proszę czy podane przez Ciebie dane są poprawne.");
            
            Console.WriteLine(string.Empty);
            
            Console.WriteLine($"Imię:{firstName}");
            Console.WriteLine($"Nazwisko:{lastName}");
            Console.WriteLine($"Wiek:{age}" + "lat.");

            bool writeChosedSex = chosedSex < 2;
            if (writeChosedSex)
            {
                Console.WriteLine("Płeć: Mężczyzna.");
            }
            else
            {
                Console.WriteLine("Płeć: Kobieta.");
            }
            
            Console.WriteLine($"Numer telefonu:{telephoneNumber}");
            Console.WriteLine($"Adres zamieszkania:{adress}");
            Console.WriteLine($"Numer PESEL:{pesel}");
            Console.WriteLine($"Adres Email:{emailAdress}");
            Console.WriteLine($"Wzrost:{height}" + "cm.");
            Console.WriteLine($"Waga:{weight}" + "kg");
            Console.WriteLine($"Kolor oczu:{eyesColor}");
            Console.WriteLine($"Numer pracownika:{employeeNumber}");
            
            Console.WriteLine(string.Empty);
            
            Console.WriteLine("Jeśli wszystkie dane się zgadzają zakończ pracę programu wciskając klawisz ENTER.");
            Console.WriteLine("Jeśli widzisz jakiś błąd wciśnij klawisz F1 aby zacząć proces od nowa.");
            
            // I tutaj można dodać jeszcze warunek logiczny który obsługował by klawisz F1,
            // oraz wyświetlał wiadomość pożegnalną jeśli wszystko było by dobrze. 

        }
    }
}
