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

            // Używam pustych string-ów aby wiadomości w konsoli były bardziej widoczne.
            Console.WriteLine(string.Empty);

            Console.WriteLine("Pytanie numer 1:");
            
            Console.WriteLine("Podaj swoje imię.");
            
            string Imię = Console.ReadLine();

            Console.WriteLine(string.Empty);

            Console.WriteLine("Pytanie numer 2:");

            Console.WriteLine("Podaj swoje nazwisko.");
            
            string Nazwisko = Console.ReadLine();

            Console.WriteLine(string.Empty);

            Console.WriteLine("Pytanie numer 3:");

            Console.WriteLine("Podaj swój wiek.");

            string Wiek = Console.ReadLine();

            int WiekWłaściwy = int.Parse(Wiek);

            Console.WriteLine(string.Empty);

            Console.WriteLine("Pytanie numer 4:");

            Console.WriteLine("Wybierz swoją płeć.");

            Console.WriteLine("1.Mężczyzna.");
            Console.WriteLine("2.Kobieta.");

            string Płeć = Console.ReadLine();
            int PłećWłaściwa = int.Parse(Płeć);

            Console.WriteLine(string.Empty);

            Console.WriteLine("Pytanie numer 5:");
            Console.WriteLine("Podaj swój numer telefonu.");
            string NumerTelefonu = Console.ReadLine();
            int NumerTelefonu1 = int.Parse(NumerTelefonu);

            Console.WriteLine(string.Empty);

            Console.WriteLine("Pytanie numer 6:");
            Console.WriteLine("Podaj swój adres zamieszkania.");
            string AdresZamieszkania = Console.ReadLine();

            Console.WriteLine(string.Empty);

            Console.WriteLine("Pytanie numer 7:");
            Console.WriteLine("Podaj swój numer PESEL.");
            string PESEL = Console.ReadLine();
            Int64 PESEL1 = Int64.Parse(PESEL);
            
            Console.WriteLine(string.Empty);
            
            Console.WriteLine("Pytanie numer 8:");
            Console.WriteLine("Podaj swój adres email.");
            string AdresEmail = Console.ReadLine();
           
            Console.WriteLine(string.Empty);

            Console.WriteLine("Pytanie numer 9:");
            Console.WriteLine("Podaj swój wzrost w centymetrach.");
            string Wzrost = Console.ReadLine();
            int Wzrost1 = int.Parse(Wzrost);

            Console.WriteLine(string.Empty);
            Console.WriteLine("Pytanie numer 10:");
            Console.WriteLine("Podaj swoją wagę w kilogramach.");
            string Waga = Console.ReadLine();
            float Waga1 = float.Parse(Waga);

            Console.WriteLine(string.Empty);

            Console.WriteLine("Pytanie numer 11:");
            Console.WriteLine("Podaj swój kolor oczu");
            string KolorOczu = Console.ReadLine();

            Console.WriteLine(string.Empty);
            
            // Zakładam że numer pracownika został nadany przy podpisywaniu umowy o pracę,
            // i osoba korzytsająca z programu ma już go w formie papierowej,
            // Jeśli nie to można by było dodać funkcje która losuje numer z jakiegoś przedziału liczbowego (jeśli taka funkcja istnieje).

            Console.WriteLine("Pytanie numer 12:");
            Console.WriteLine("Podaj nadany ci numer pracownika.");
            string NumerPracownika = Console.ReadLine();
            Int64 NumerPracownika1 = Int64.Parse(NumerPracownika);
            
            Console.WriteLine(string.Empty);

            //Podsumowanie
            Console.WriteLine("To już wszystkie pytania, sprawdz proszę czy podane przez Ciebie dane są poprawne.");
            Console.WriteLine(string.Empty);
            // I tutaj można by było zastosować typ wyświetlania w dwóch kolumnach aby dane były bardziej widoczne.
            Console.WriteLine($"Imię:{Imię}");
            Console.WriteLine($"Nazwisko:{Nazwisko}");
            Console.WriteLine($"Wiek:{WiekWłaściwy}" + "lat.");

            bool KtóraPłeć = PłećWłaściwa < 2;
            if (KtóraPłeć)
            {
                Console.WriteLine("Płeć: Mężczyzna.");
            }
            else
            {
                Console.WriteLine("Płeć: Kobieta.");
            }
            
            // Do numeru telefonu można jeszcze dodać konkretny sposób wyświetlania
            // jeśli chcielibyśmy aby wyświetlało się 123-456-789 a nie 123456789
            // ale uznałem że nie o to chodzi w tym zadaniu i sobie darowałem aby nie przekombinować.
            Console.WriteLine($"Numer telefonu:{NumerTelefonu1}");
            Console.WriteLine($"Adres zamieszkania:{AdresZamieszkania}");
            Console.WriteLine($"Numer PESEL:{PESEL1}");
            Console.WriteLine($"Adres Email:{AdresEmail}");
            Console.WriteLine($"Wzrost:{Wzrost1}" + "cm.");
            Console.WriteLine($"Waga:{Waga1}" + "kg");
            Console.WriteLine($"Kolor oczu:{KolorOczu}");
            Console.WriteLine($"Numer pracownika:{NumerPracownika1}");
            
            Console.WriteLine(string.Empty);
            
            Console.WriteLine("Jeśli wszystkie dane się zgadzają zakończ pracę programu wciskając klawisz ENTER.");
            Console.WriteLine("Jeśli widzisz jakiś błąd wciśnij klawisz F1 aby zacząć proces od nowa.");
            // I tutaj można dodać jeszcze warunek logiczny który obsługował by klawisz F1,
            // oraz wyświetlał wiadomość pożegnalną jeśli wszystko było by dobrze. 
            





        }
    
    
    
    
    
    
    
    
    
    }
}
