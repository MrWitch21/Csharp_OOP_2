using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextFile;

namespace Beadando_10_feladat
{
     public class FileIn
     {
       private readonly TextFileReader reader;
       private readonly int n;
       public FileIn(string file, Kate k)
       {
            reader = new TextFileReader(file);
            if(!int.TryParse(reader.ReadLine(), out n))
            {
                throw new Exception("Hiba: Helytelen adat sorokszamanak beolvasasakor.");
            }
            if (n < 1)
            {
                throw new Exception("Hiba: Helytelen adat sorokszamanak beolvasasakor.");
            }
            string[] sor;
            for(int i = 0; i < n; i++)
            {
                sor=reader.ReadLine().Split(' ');
                switch(sor[0].ToUpper())
                {
                    case "T":
                        if (CheckIn(sor[1], sor[2])) { k.AddAnimal(new Tarantula(sor[1], int.Parse(sor[2]))); } else { throw new Exception("Hiba: rossz/tul hosszu nev vagy rossz eletero formatum."); }; 
                        break;
                    case "M":
                        if (CheckIn(sor[1], sor[2])) { k.AddAnimal(new Cat(sor[1], int.Parse(sor[2]))); } else { throw new Exception("Hiba: rossz/tul hosszu nev vagy rossz eletero formatum."); };
                        break;
                    case "H":
                        if (CheckIn(sor[1], sor[2])) { k.AddAnimal(new Hamster(sor[1], int.Parse(sor[2]))); } else { throw new Exception("Hiba: rossz/tul hosszu nev vagy rossz eletero formatum."); };
                        break;
                    default:
                        throw new Exception("Hiba: Helytelen allat meghatarozas" + sor[0]);
                }
            }
            k.Days = reader.ReadLine();
            Console.WriteLine("File sikeresen beolvasva!\nAdatok sikeresen letarolva!\n");

        }
        //Bemeno adatok ellenorzese
        private static bool CheckIn(string name, string hp)
        {
            if(name.Length <= 2 || name.Length > 64)
            {
                return false;
            }
            int health;
            if (!int.TryParse(hp, out health))
            {
                return false;
            }
            else
            {
                if(health<1 || health > 70)
                {
                    return false;
                }
            }
            return true;
        }
     }
}
