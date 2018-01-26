using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace MitchumNaidoo_GADE_RERUN_ICE4
{
    class Program
    {
        //varibles
        protected int i;
        //Array
        public Hero[] Protages = new Hero[20];

        static void Main(string[] args)
        {
            if (Directory.Exists("saves") != true)
            {
                Directory.CreateDirectory("saves");
                Console.WriteLine("Directory created");
            }
            else
            {
                if (!File.Exists("saves/save.file"))
                {
                    File.Create("saves/save.file").Close();
                    Console.WriteLine("File created");
                }

                FileStream file = new FileStream("saves/save.file", FileMode.Open, FileAccess.ReadWrite);
                StreamWriter writer = new StreamWriter(file);
                StreamReader read = new StreamReader(file);

                if (file.Length == 0)
                {
                    Console.WriteLine("The Battlefield is Empty");
                    PlayerInput();
                }
                if(file.Length != 0)
                {
                    PlayerInput();
                    Hero Mitchum =  HeroCreation();
                    writer.WriteLine(Mitchum.ToString());
                    string line = read.ReadLine();
                    while(line != null)
                    {
                        string[] textt = File.ReadAllLines(Convert.ToString(file));
                        string[] rogue = line.Split(' ');
                        string[] barb = line.Split(' ');
                        string[] wiz = line.Split(' ');
                        string[] sham = line.Split(' ');
                        string[] tem = line.Split(' ');
                        string[] monkas = line.Split(' ');
                        Rogue newRog = new Rogue(Convert.ToInt32(rogue[0]), Convert.ToInt32(rogue[1]), Convert.ToInt32(rogue[2]), Convert.ToInt32(rogue[3]), rogue[4], rogue[5]);
                        Barbarian newBar = new Barbarian(Convert.ToInt32(barb[0]), Convert.ToInt32(barb[1]), Convert.ToInt32(barb[2]), Convert.ToInt32(barb[3]), barb[4], barb[5]);
                        Wizard newWiz = new Wizard(Convert.ToInt32(wiz[0]), Convert.ToInt32(wiz[1]), Convert.ToInt32(wiz[2]), Convert.ToInt32(wiz[3]), wiz[4], wiz[5]);
                        Shaman newSham = new Shaman(Convert.ToInt32(sham[0]), Convert.ToInt32(sham[1]), Convert.ToInt32(sham[2]), Convert.ToInt32(sham[3]), sham[4], sham[5]);
                        Templar newTem = new Templar(Convert.ToInt32(tem[0]), Convert.ToInt32(tem[1]), Convert.ToInt32(tem[2]), Convert.ToInt32(tem[3]), tem[4], tem[5]);
                        Monk newMonkas = new Monk(Convert.ToInt32(monkas[0]), Convert.ToInt32(monkas[1]), Convert.ToInt32(monkas[2]), Convert.ToInt32(monkas[3]), monkas[4], monkas[5]);
                        line = read.ReadLine();
                    }

                    writer.Close();
                    file.Close();
                }
                writer.Close();
                file.Close();
            }
        }

        public static void PlayerInput()
        {
            Console.WriteLine("Welcome master would you like to create a hero?");
            string YN = Console.ReadLine();
            if(YN == "yes")
            {
                HeroCreation();
            }
            if(YN == "no")
            {
                Environment.Exit(0);
            }

        }

        public static Hero HeroCreation()
        { 
            int heroClass = 0;
            Console.WriteLine("What hero would u like to make");
            Console.WriteLine("1 Rogue\n2 Barbarian\n3 Wizard\n4 Shaman\n5 Templar\n6 Monk");
            string HeroType = Console.ReadLine();
            heroClass = Convert.ToInt32(HeroType);
            switch (heroClass)
            {
                case 1:
                    Rogue RoG = new Rogue(0, 0, 0, 0, "", "");
                    return RoG;
                    break;

                case 2:
                    Barbarian Bro = new Barbarian(0, 0, 0, 0, "", "");
                    return Bro;
                    break;

                case 3:
                    Wizard Wiz = new Wizard(0, 0, 0, 0, "", "");
                    return Wiz;
                    break;

                case 4:
                    Shaman Sham = new Shaman(0, 0, 0, 0, "", "");
                    return Sham;
                    break;

                case 5:
                    Templar Temp = new Templar(0, 0, 0, 0, "", "");
                    return Temp;
                    break;

                case 6:
                    Monk MoN = new Monk(0, 0, 0, 0, "", "");
                    return MoN;
                    break;
            }
            return null;
        }
    }
}
