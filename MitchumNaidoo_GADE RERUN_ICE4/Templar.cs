using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace MitchumNaidoo_GADE_RERUN_ICE4
{
    public class Templar : Hero
    {
        //properties
        protected int Hp { get => hp; set => hp = value; }
        protected int Attack { get => attack; set => attack = value; }
        protected int Crit { get => crit; set => crit = value; }
        protected int Defense { get => defense; set => defense = value; }
        protected string Name { get => name; set => name = value; }
        protected string Battlecry { get => battlecry; set => battlecry = value; }

        //constructor
        public Templar(int hp, int attack, int crit, int defense, string name, string battlecry) : base (hp ,attack, crit, defense, name, battlecry)
        {
            Hp = hp = SetHp();
            Attack = attack = SetAtk();
            Crit = crit = SetCrit();
            Defense = defense = SetDef();
            Name = name = SetName();
            Battlecry = battlecry = SetCry();
        }

        //Deconstructor
        ~Templar()
        {

        }

        //methords
        public static void CreateTemplar(int hp, int attack, int crit, int defense, string name, string battlecry)
        {
            SetHp();
            SetAtk();
            SetCrit();
            SetDef();
            SetName();
            SetCry();
            Console.WriteLine(name + " the Templar\nHp " + hp + "\nAttack " + attack + "\nDefense " + defense + "\nCritChance " + crit + "\nBattlecry " + battlecry);
        }

        public static int SetHp()
        {
            int newHp;
            Console.WriteLine("Hero HP: ");
            string typedHp = Console.ReadLine();
            newHp = Convert.ToInt32(typedHp);
            return newHp;
        }

        public static int SetAtk()
        {
            int newAtk;
            Console.WriteLine("Hero Atk: ");
            string typedAtk = Console.ReadLine();
            newAtk = Convert.ToInt32(typedAtk);
            return newAtk;
        }

        public static int SetCrit()
        {
            int newCrit;
            Console.WriteLine("Hero Crit: ");
            string typedCrit = Console.ReadLine();
            newCrit = Convert.ToInt32(typedCrit);
            return newCrit;
        }

        public static int SetDef()
        {
            int newDef;
            Console.WriteLine("Hero Def: ");
            string typedDef = Console.ReadLine();
            newDef = Convert.ToInt32(typedDef);
            return newDef;
        }

        public static string SetName()
        {
            string newName;
            Console.WriteLine("Hero Name: ");
            newName = Console.ReadLine();
            return newName;
        }

        public static string SetCry()
        {
            string newCry;
            Console.WriteLine("Hero Battlecry: ");
            newCry = Console.ReadLine();
            return newCry;
        }

        public override string ToString()
        {
            return (name + " " + hp + " " + attack + " " + defense + " " + crit + " " + battlecry);
        }
    }
}
