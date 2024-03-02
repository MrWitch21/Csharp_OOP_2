using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beadando_10_feladat
{
    public class Kate
    {
        //kati allatai
        private readonly List<Animal> animals =new();
        private bool Bonus = true;
        public string Days;
        public Kate() { }
        public void AddAnimal(Animal animal)
        {
            animals.Add(animal);
        }
        //Kati napjai..
        public void Daily_Moods()
        {
            Days = Days.ToLower();
            Bonus = CheckBonus();
            for (int i = 0; i < Days.Length; i++)
            {
                switch(Days[i])
                {
                    case 'v':
                        H();
                        break;
                    case 'a':
                        if(Bonus == true) { H();} else { A(); }
                        Bonus = CheckBonus();
                        break;
                    case 's':
                        if (Bonus == true) { A(); } else { S(); }
                        Bonus = CheckBonus();
                        break;
                    default:
                        throw new Exception("Rossz napkod"+ Days[i]);
                }
                Print(i);
            }
        }
        //Egyesnapok kiirasa
        private void Print(int i)
        {
           List<Animal> maxA = new();
            int max = 0;
           
           Console.WriteLine($"{i+1}. nap");
           foreach(Animal a in animals)
           {
                Console.WriteLine(a.Status());
                //maximum keresessel egybekotve
                if(a.Health >= max)
                {
                    if(a.Health == max)
                    {
                        maxA.Add(a);
                    }
                    else
                    {
                        max = a.Health;
                        maxA.Clear();
                        maxA.Add(a);
                    }
                }
           }
           Console.WriteLine("\nA legeletrevalobb allat(ok): ");
           foreach(Animal a in maxA)
           {
                Console.WriteLine($"Nev: {a.Name} eletero: {a.Health}");
           }
            Console.WriteLine();
        }
        //Jar-e még "bonusz"?
        //teszteles miatt public
        public bool CheckBonus()
        {
            foreach(Animal a in animals)
            {
                if(a.CheckHP())
                {
                    return false;
                }
            }
            return true;
        }
        private void H()
        {
            foreach(Animal a in animals)
            {
                a.Happy();
            }
        }
        private void A()
        {
            foreach (Animal a in animals)
            {
                a.Avg();
            }
        }
        private void S()
        {
            foreach (Animal a in animals)
            {
                a.Sad();
            }
        }
        /*private void AnimalRemover()
        {
            int i = 0;
            foreach (Animal a in animals)
            {
                if (a.Health == 0)
                {
                    animals.RemoveAt(i);
                }
                i++;
            }
        }*/
    }
}