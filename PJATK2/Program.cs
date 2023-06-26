namespace Cwiczenie2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // PrzykladyZajecia2();

            /*
             * program z zajęc 2
            */

            // klasa (szablon) -> obiekt (instancja klasy)
            Student student = new Student();
            student.imie = "Jan";
            student.nazwisko = "Kowalski";
            student.WyswietlSwojaWizytówke();

            Student student1 = new Student();
            student1.imie = "Anna";
            student1.nazwisko = "Kwiatkowska";
            student1.WyswietlSwojaWizytówke();


            // 1. wczytujemy imie i nazwisko
            Console.WriteLine("Podaj imie");
            string imie = Console.ReadLine();
            Console.WriteLine("Podaj nazwisko");
            string nazwisko = Console.ReadLine();

            // 2. wczytujemy oceny
            List<double> oceny = WczytajOcenyOdUzytkownika();

            // 3. wypisujemy srednia ocen
            double srednia = ObliczSrednia(oceny);
            Console.WriteLine($"Imie: {imie}, Nazwisko: {nazwisko}, średnia: {srednia}");


        }

        static double ObliczSrednia(List<double> oceny)
        {
            double suma = 0;
            foreach (double ocena in oceny)
            {
                suma += ocena;
            }
            double srednia = suma / oceny.Count();
            return srednia;
        }
        static List<double> WczytajOcenyOdUzytkownika()
        {
            List<double> oceny = new List<double>();

            while (true)
            {
                Console.WriteLine("Podaj ocene");
                string ocenaStr = Console.ReadLine();

                if (ocenaStr.ToLower() == "koniec")
                {
                    break;
                }

                try
                {
                    double ocena = double.Parse(ocenaStr);
                    oceny.Add(ocena);
                }
                catch (FormatException ex)
                {
                    Console.WriteLine(ex.StackTrace);
                    Console.WriteLine("prosze podac poprawną liczbe");
                }
            }

            return oceny;

        }
        static void PrzykladyZajecia2()
        {
            // tablice / kolekcje

            // 5.1. tablice
            int[] oceny = new int[10];
            oceny[0] = 5;
            oceny[9] = 10;
            Console.WriteLine("Liczba: " + oceny[0]);

            string[] imiona = new string[10];
            string[] imiona2 = new[] { "Ala", "John", "Mike" };

            // 5.1.1. tablice wielowymiarowe
            int[,] tablica = new int[3, 3];
            tablica[0, 0] = 5;

            // 5.2. kolekcje
            // 5.2.1. List<T>
            List<int> oceny2 = new List<int>();
            oceny2.Add(5);
            oceny2.Add(10);
            //oceny2.Insert(1, 10);

            int l1 = oceny2[0];

            // 6. Pętle - wszystkie robią to samo

            // 6.1. for
            Console.WriteLine("pętla for:");
            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine("i=" + i);
            }

            // 6.2. while
            Console.WriteLine("pętla while:");
            int g = 0;
            while (g < 19)
            {
                Console.WriteLine("g=" + g);
                g++;
            }

            // 6.3. do-while
            int h = 0;
            Console.WriteLine("pętla do-while:");
            do
            {
                Console.WriteLine("h=" + h);
                h++;
            } while (h < 20);


            // 6.4. foreach
            List<string> osoby2 = new List<string> { "ala", "john", "mike" };
            foreach (string osoba in osoby2)
            {
                Console.WriteLine("Imie= " + osoba);
            }
        }
    }
}