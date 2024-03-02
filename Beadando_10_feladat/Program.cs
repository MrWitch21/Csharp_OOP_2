/*
 * Készítette: Gyönge Máté László
 * Neptun kód: LFVY9F
 * E-mail: lfvy9f@inf.elte.hu / mategyonge@gmail.com
 * Feladat: beadando2: 10. feladat (Kati és az állatok)
 */
namespace Beadando_10_feladat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Kerem adja meg a feljnak a nevet: ");
            string falj = Console.ReadLine();
            Kate kate = new Kate();
            FileIn file = new FileIn(falj, kate);
            kate.Daily_Moods();
            //Console.ReadKey();
        }
    }
}