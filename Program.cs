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