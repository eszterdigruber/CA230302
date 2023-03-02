using System.IO;
using System.Text;
namespace HelloWorld
{
    class Program
    {
        static List<Csoki> Csoki_List = new List<Csoki>();
        static void Main(string[] args)
        {
            Feladat1Beolvasas(); Console.WriteLine("\n---------------\n");
            Feladat2(); Console.WriteLine("\n---------------\n");
            Feladat3(); Console.WriteLine("\n---------------\n");
            Feladat4(); Console.WriteLine("\n---------------\n");
            Feladat5(); Console.WriteLine("\n---------------\n");
            Feladat6(); Console.WriteLine("\n---------------\n");
        }

        private static void Feladat6()
        {
            Console.WriteLine("6.feladat: Kód bekérés");
            Console.Write("Kérem adjon meg egy kódot: ");

        }

        private static void Feladat5()
        {
            Console.WriteLine("5.feladat: 1 db csoki mindegyikből. Mennyibe kerül?");
            int Osszeg = 0;
            foreach (var cs in Csoki_List)
            {
                Osszeg += cs.Ar;
            }
            Console.WriteLine($"Ha minden csokiból veszek egyet: {Osszeg} Ft-ba kerül.");
        }

        private static void Feladat4()
        {
            Console.WriteLine("4.feladat: Csokik 150 Ft-ból");
            foreach (var cs in Csoki_List)
            {
                if (cs.Ar <= 150)
                { Console.WriteLine($"{cs.Nev} : {cs.Ar}"); }
            }
        }

        private static void Feladat3()
        {
            Console.WriteLine("3.feladat: Legdrágább termék neve, ára");
            int MaxAr = int.MinValue;
            string MaxCsoki = "tehén";
            foreach (var cs in Csoki_List)
            {
                if (MaxAr < cs.Ar)
                {
                    MaxCsoki = cs.Nev;
                    MaxAr = cs.Ar;
                }
            }
            Console.WriteLine($"A legdrágább csoki: {MaxCsoki} : ára: {MaxAr}");
        }

        private static void Feladat2()
        {
            Console.WriteLine("2.feladat: Sorok száma");
            Console.WriteLine($"Beolvasott sorok száma: {Csoki_List.Count}");
        }

        private static void Feladat1Beolvasas()
        {
            Console.WriteLine("1.feladat: Beolvasás");
            var sr = new StreamReader(@"csoki.txt", Encoding.UTF8);
            int db = 0;
            while (!sr.EndOfStream)
            {
                Csoki_List.Add(new Csoki(sr.ReadLine()));
                db++;
            }
            sr.Close();
            if (db > 0) { Console.WriteLine($"Sikeres a beolvasás: {db}"); }
            else { Console.WriteLine("Sikertelen a beolvasás"); }
        }
    }
}