using Beadando_10_feladat;
using System.Xml.Linq;
using TextFile;
namespace Tesztek
{
    [TestClass]
    public class AnimalTests
    {
        [TestMethod]
        public void Basic()
        {
            //Tarantula
            Console.WriteLine("Tarantula");

            Tarantula tarantula1 = new Tarantula("Bob", 40);

            string e_name = "Bob";
            Assert.AreEqual(e_name, tarantula1.Name);
            Console.WriteLine(e_name + " = "+tarantula1.Name + " -> OK");

            int e_health = 40;
            Assert.AreEqual(e_health, tarantula1.Health, e_health + " != " + tarantula1.Health);
            Console.WriteLine(e_health + " = "+tarantula1.Health + " -> OK");

            string e_type = "Tarantula";
            Assert.AreEqual(e_type, tarantula1.AnimalType, e_type + " != " + tarantula1.AnimalType);
            Console.WriteLine(e_type + " = "+tarantula1.AnimalType + " -> OK");

            tarantula1.Happy();
            e_health = 41;
            Assert.AreEqual(e_health, tarantula1.Health, e_health + " != " + tarantula1.Health);
            Console.WriteLine(e_health + " = " + tarantula1.Health + " -> OK");

            tarantula1.Avg();
            e_health = 39;
            Assert.AreEqual(e_health, tarantula1.Health, e_health + " != " + tarantula1.Health);
            Console.WriteLine(e_health + " = " + tarantula1.Health + " -> OK");

            tarantula1.Sad();
            e_health = 36;
            Assert.AreEqual(e_health, tarantula1.Health, e_health +" != "+tarantula1.Health);
            Console.WriteLine(e_health + " = " + tarantula1.Health + " -> OK");

            Assert.IsFalse(tarantula1.CheckHP(), tarantula1.CheckHP().ToString());
            Console.WriteLine("CheckHP = false -> OK");

            Assert.AreEqual($"Nev: {e_name} {e_type} eletero: {e_health}", tarantula1.Status(), $"Nev: {e_name} {e_type} eletero: {e_type}" + " != " + tarantula1.Status());
            Console.WriteLine("status1 -> OK");

            Tarantula tarantula2 = new Tarantula("Ivan", 4);
            Assert.IsTrue(tarantula2.CheckHP(), tarantula2.CheckHP().ToString());
            Console.WriteLine("CheckHP = true -> OK");

            tarantula2.Avg();
            tarantula2.Avg();
            e_name = "Ivan";
            Assert.AreEqual($"{e_name} {e_type} elpusztult. ;(", tarantula2.Status(), $"{e_name} {e_type} elpusztult. ;(" + " != " + tarantula2.Status());
            Console.WriteLine("status2 -> OK");
            //Cat
            Console.WriteLine("\nCat");

            Cat cat1 = new Cat("Joe", 30);

            e_name = "Joe";
            Assert.AreEqual(e_name, cat1.Name);
            Console.WriteLine(e_name + " = " + cat1.Name + " -> OK");

            e_health = 30;
            Assert.AreEqual(e_health, cat1.Health, e_health + " != " + cat1.Health);
            Console.WriteLine(e_health + " = " + cat1.Health + " -> OK");

            e_type = "Macska";
            Assert.AreEqual(e_type, cat1.AnimalType, e_type + " != " + cat1.AnimalType);
            Console.WriteLine(e_type + " = " + cat1.AnimalType + " -> OK");

            cat1.Happy();
            e_health = 33;
            Assert.AreEqual(e_health, cat1.Health, e_health + " != " + cat1.Health);
            Console.WriteLine(e_health + " = " + cat1.Health + " -> OK");

            cat1.Avg();
            e_health = 36;
            Assert.AreEqual(e_health, cat1.Health, e_health + " != " + cat1.Health);
            Console.WriteLine(e_health + " = " + cat1.Health + " -> OK");

            cat1.Sad();
            e_health = 29;
            Assert.AreEqual(e_health, cat1.Health, e_health + " != " + cat1.Health);
            Console.WriteLine(e_health + " = " + cat1.Health + " -> OK");

            Assert.IsFalse(cat1.CheckHP(), cat1.CheckHP().ToString());
            Console.WriteLine("CheckHP = false -> OK");

            Assert.AreEqual($"Nev: {e_name} {e_type} eletero: {e_health}", cat1.Status(), $"Nev: {e_name} {e_type} eletero: {e_type}" + " != " + cat1.Status());
            Console.WriteLine("status1 -> OK");

            Cat cat2 = new Cat("Zoe", 4);
            Assert.IsTrue(cat2.CheckHP(), cat2.CheckHP().ToString());
            Console.WriteLine("CheckHP = true -> OK");

            cat2.Sad();
            e_name = "Zoe";
            Assert.AreEqual($"{e_name} {e_type} elpusztult. ;(", cat2.Status(), $"{e_name} {e_type} elpusztult. ;(" + " != " + cat2.Status());
            Console.WriteLine("status2 -> OK");
            //Hamster
            Console.WriteLine("\nHamster");

            Hamster hamster1 = new Hamster("Hori", 50);

            e_name = "Hori";
            Assert.AreEqual(e_name, hamster1.Name);
            Console.WriteLine(e_name + " = " + hamster1.Name + " -> OK");

            e_health = 50;
            Assert.AreEqual(e_health, hamster1.Health, e_health + " != " + hamster1.Health);
            Console.WriteLine(e_health + " = " + hamster1.Health + " -> OK");

            e_type = "Horcsog";
            Assert.AreEqual(e_type, hamster1.AnimalType, e_type + " != " + hamster1.AnimalType);
            Console.WriteLine(e_type + " = " + hamster1.AnimalType + " -> OK");

            hamster1.Happy();
            e_health = 52;
            Assert.AreEqual(e_health, hamster1.Health, e_health + " != " + hamster1.Health);
            Console.WriteLine(e_health + " = " + hamster1.Health + " -> OK");

            hamster1.Avg();
            e_health = 49;
            Assert.AreEqual(e_health, hamster1.Health, e_health + " != " + hamster1.Health);
            Console.WriteLine(e_health + " = " + hamster1.Health + " -> OK");

            hamster1.Sad();
            e_health = 44;
            Assert.AreEqual(e_health, hamster1.Health, e_health + " != " + hamster1.Health);
            Console.WriteLine(e_health + " = " + hamster1.Health + " -> OK");

            Assert.IsFalse(hamster1.CheckHP(), hamster1.CheckHP().ToString());
            Console.WriteLine("CheckHP = false -> OK");

            Assert.AreEqual($"Nev: {e_name} {e_type} eletero: {e_health}", hamster1.Status(), $"Nev: {e_name} {e_type} eletero: {e_type}" + " != " + hamster1.Status());
            Console.WriteLine("status1 -> OK");

            Hamster hamster2 = new Hamster("Hami", 4);
            Assert.IsTrue(hamster2.CheckHP(), hamster2.CheckHP().ToString());
            Console.WriteLine("CheckHP = true -> OK");

            hamster2.Sad();
            hamster2.Sad();
            e_name = "Hami";
            Assert.AreEqual($"{e_name} {e_type} elpusztult. ;(", hamster2.Status(), $"{e_name} {e_type} elpusztult. ;(" + " != " + hamster2.Status());
            Console.WriteLine("status2 -> OK");
        }
        [TestMethod]
        public void Advanced()
        {
            //Tarantula
            Console.WriteLine("Tarantula");

            Tarantula tarantula1 = new Tarantula("Bob", 70);

            tarantula1.Happy();
            int e_health = 70;
            Assert.AreEqual(e_health, tarantula1.Health, e_health + " != " + tarantula1.Health);
            Console.WriteLine($"{e_health} = {tarantula1.Health} -> OK" );

            Tarantula tarantula2 = new Tarantula("Ivan", 0);
            e_health = 0;
            tarantula2.Avg();
            Assert.AreEqual(e_health, tarantula2.Health, e_health + " != " + tarantula2.Health);
            Console.WriteLine($"{e_health} = {tarantula2.Health} -> OK");

            tarantula2.Sad();
            Assert.AreEqual(e_health, tarantula2.Health, e_health + " != " + tarantula2.Health);
            Console.WriteLine($"{e_health} = {tarantula2.Health} -> OK");

            //Cat
            Console.WriteLine("\nMacska");

            Cat cat1 = new Cat("Joe", 70);

            cat1.Happy();
             e_health = 70;
            Assert.AreEqual(e_health, cat1.Health, e_health + " != " + cat1.Health);
            Console.WriteLine($"{e_health} = {cat1.Health} -> OK");

            cat1.Avg();
            Assert.AreEqual(e_health, cat1.Health, e_health + " != " + cat1.Health);
            Console.WriteLine($"{e_health} = {cat1.Health} -> OK");

            Cat cat2 = new Cat("Zoe", 0);

            cat2.Sad();
            e_health = 0;
            Assert.AreEqual(e_health, cat2.Health, e_health + " != " + cat2.Health);
            Console.WriteLine($"{e_health} = {cat2.Health} -> OK");
            //Hamster
            Console.WriteLine("\nHorcsog");

            Hamster hamster1 = new Hamster("Hori", 70);

            hamster1.Happy();
            e_health = 70;
            Assert.AreEqual(e_health, hamster1.Health, e_health + " != " + hamster1.Health);
            Console.WriteLine($"{e_health} = {hamster1.Health} -> OK");

            cat1.Avg();
            Assert.AreEqual(e_health, cat1.Health, e_health + " != " + cat1.Health);
            Console.WriteLine($"{e_health} = {hamster1.Health} -> OK");

            Hamster hamster2 = new Hamster("Hami", 0);

            e_health = 0;
            hamster2.Avg();
            Assert.AreEqual(e_health, hamster2.Health, e_health + " != " + hamster2.Health);
            Console.WriteLine($"{e_health} = {hamster2.Health} -> OK");

            hamster2.Sad();
            Assert.AreEqual(e_health, hamster2.Health, e_health + " != " + hamster2.Health);
            Console.WriteLine($"{e_health} = {hamster2.Health} -> OK");
        }
    }

    [TestClass]
    public class FileInTests
    {
        [TestMethod]
        public void Correct_Input()
        {
            Console.WriteLine("File6");
            Kate kate1 = new Kate();
            FileIn f1 = new FileIn("for_tester_6_G.txt", kate1);
            Console.WriteLine("OK");

            Console.WriteLine("\nFile7");
            Kate kate2 = new Kate();
            FileIn f2 = new FileIn("for_tester_7_G.txt", kate2);
            Console.WriteLine("OK");

        }
        [TestMethod]
        public void Wrong_Inputs()
        {
            Console.WriteLine("File1");
            Kate kate1 = new Kate();
            FileIn f1;
            Assert.ThrowsException<Exception>(() => f1 = new FileIn("for_tester_1_W.txt", kate1));
            Console.WriteLine("OK");

            Console.WriteLine("\nFile2");
            FileIn f2;
            Assert.ThrowsException<Exception>(() => f2 = new FileIn("for_tester_2_W.txt", kate1));
            Console.WriteLine("OK");

            Console.WriteLine("\nFile3");
            FileIn f3;
            Assert.ThrowsException<Exception>(() => f3 = new FileIn("for_tester_3_W.txt", kate1));
            Console.WriteLine("OK");

            Console.WriteLine("\nFile4");
            FileIn f4;
            Assert.ThrowsException<Exception>(() => f4 = new FileIn("for_tester_4_W.txt", kate1));
            Console.WriteLine("OK");

            Console.WriteLine("\nFile5");
            FileIn f5;
            Assert.ThrowsException<Exception>(() => f5 = new FileIn("for_tester_5_W.txt", kate1));
            Console.WriteLine("OK");

        }
    }
    [TestClass]
    public class KateTests
    {
        [TestMethod]
        public void CheckBonusTests()
        {
            Console.WriteLine("File8_Bonus_Check");
            Kate kate1 = new Kate();
            FileIn f1 = new FileIn("for_tester_8_Bonus.txt", kate1);
            kate1.Daily_Moods();
            Assert.IsFalse(kate1.CheckBonus());
            Console.WriteLine("File8_Bunus_Check -> Ok\n");

            Console.WriteLine("File9_Bonus_Check");
            Kate kate2 = new Kate();
            FileIn f2 = new FileIn("for_tester_9_Bonus.txt", kate2);
            kate2.Daily_Moods();
            Assert.IsTrue(kate2.CheckBonus());
            Console.WriteLine("File9_Bunus_Check -> Ok");
        }
        [TestMethod]
        public void Daily_MoodsTests()
        {
            Console.WriteLine("File10_Moods_Check");
            Kate kate1 = new Kate();
            FileIn f1 = new FileIn("for_tester_10_Moods.txt", kate1);
            kate1.Daily_Moods();
            Console.WriteLine("File10_Moods -> Ok\n");

            Console.WriteLine("File11_Moods_Check");
            Kate kate2 = new Kate();
            FileIn f2 = new FileIn("for_tester_11_Moods.txt", kate2);
            Assert.ThrowsException<Exception>(() => kate2.Daily_Moods());
            Console.WriteLine("File11_Moods -> Ok\n");

            Console.WriteLine("File12_Moods_Check");
            Kate kate3 = new Kate();
            FileIn f3 = new FileIn("for_tester_12_Moods.txt", kate3);
            kate3.Daily_Moods();
            Console.WriteLine("File12_Moods -> Ok");
        }
    }
}