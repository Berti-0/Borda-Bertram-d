using System.Text;

namespace Borda_Bertram_10._25
{
    internal class Program
    {
        static List<Bolygo> bolygok = new List<Bolygo>();


        static void Main(string[] args)
        {

            using var sr = new StreamReader(path:@"..\..\..\src\solsys.txt", encoding: Encoding.UTF8);
            while (!sr.EndOfStream)
            {
                bolygok.Add(new Bolygo(sr.ReadLine()));
            }

            Console.WriteLine("3. feladat:");

            Console.WriteLine($"\t3.1: {bolygok.Count} bolygó van a naprendszerben");
            

            double holdak = 0;
            foreach (var item in bolygok)
            {
                holdak += item.Hold;
            }
            double atlag = holdak / bolygok.Count;

            Console.WriteLine($"\t3.2: a naprendszerben egy bolygonak átlagosan {atlag} holdja van");
            

            var legnagyobb = bolygok.MaxBy(k => k.terfogat);



            Console.WriteLine($"\t3.3: a legnagyobb terfogatú bolygó a {legnagyobb.Nev}");

            Console.Write($"\t3.4: írd be a kersett bolygó nevét: ");
            string bolygo = Console.ReadLine().ToLower();

            bool van_e = false;
            foreach (var item in bolygok)
            {
                if (item.Nev.ToLower() == bolygo)
                {
                    van_e = true;
                    Console.WriteLine("\t\tvan ilyen bolygó a naprendszerben");
                    break;
                }
            }

            if (!van_e)
            {
                Console.WriteLine("\t\tsajnos nincs ilyen nevű bolygó");
            }

            Console.Write($"\t3.5: Írj be egy egész számot: ");
            int szam = Convert.ToInt32(Console.ReadLine());
            string nevek = "[";
            foreach (var item in bolygok)
            {
                if (item.Hold> szam)
                {
                    nevek += "'" + item.Nev + "',";
                    
                }
            }
            nevek += "]";
            

            Console.WriteLine($"\t\t a következő bolygóknak van 10-nál/nél több holdja:");
            Console.WriteLine($"\t\t{nevek}");
            Console.ReadKey();
        }
    }
}