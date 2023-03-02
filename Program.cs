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
        }

        private static void Feladat3()
        {
            Console.WriteLine("3.feladat: Legdrágább termék neve, ára");
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