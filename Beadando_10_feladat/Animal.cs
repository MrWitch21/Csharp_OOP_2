using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beadando_10_feladat
{
    //A tesztek miatt publikusak
    public abstract class Animal
    {
        public string Name { get; set; }
        public int Health { get; protected set; }
        public string AnimalType { get; }
        public Animal(string name, int hp, string type)
        {
            Name = name;
            Health = hp;
            AnimalType = type;
        }
        //Mikor vidám, egyik állatáról sem feledkezik meg: ilyenkor a tarantulák életereje 1-gyel, a hörcsögöké 2-vel, a macskáké 3-mal nő.
        virtual public void Happy() { }
        virtual public void Avg() { }
        virtual public void Sad() { }
        //ha minden !!!élő!!! kedvencének az életéreje !!!!legalább 5!!!!
        public bool CheckHP()
        {
            return Health != 0 && Health < 5;
        }
        public string Status()
        {
            if (Health == 0)
            {
                return $"{Name} {AnimalType} elpusztult. ;(";
            }
            else
            {
                return $"Nev: {Name} {AnimalType} eletero: {Health}";
            }
        }
    }

    public class Tarantula : Animal
    {
        public Tarantula(string name, int hp) : base(name, hp, "Tarantula") { }
        public override void Happy()
        {
            if (Health != 0)
            {
                Health = Math.Min(Health + 1, 70);
            }
        }
        public override void Avg()
        {
            if (Health != 0)
            {
                Health = Math.Max(Health - 2, 0);
            }
        }
        public override void Sad()
        {
            if (Health != 0)
            {
                Health = Math.Max(Health - 3, 0);
            }
        }
    }

    public class Cat : Animal
    {
        public Cat(string name, int hp) : base(name, hp, "Macska") { }
        public override void Happy()
        {
            if (Health != 0)
            {
                Health = Math.Min(Health + 3, 70);
            }
        }
        public override void Avg()
        {
            if (Health != 0)
            {
                Health = Math.Min(Health + 3, 70);
            }
        }
        public override void Sad()
        {
            if (Health != 0)
            {
                Health = Math.Max(Health - 7, 0);
            }
        }
    }

    public class Hamster : Animal
    {
        public Hamster(string name, int hp) : base(name, hp, "Horcsog") { }
        public override void Happy()
        {
            if (Health != 0)
            {
                Health = Math.Min(Health + 2, 70);
            }
        }
        public override void Avg()
        {
            if (Health != 0)
            {
                Health = Math.Max(Health - 3, 0);
            }
        }
        public override void Sad()
        {
            if (Health != 0)
            {
                Health = Math.Max(Health - 5, 0);
            }
        }
    }
}
