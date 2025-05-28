using System;
using System.Xml.Linq;

namespace CommandoOOP.Models
{
    public class HandToHandFactory
    {
        public List<HandToHand> H2HWeapons = new List<HandToHand>();

        public HandToHand CreateBreakableWeapon(string name, string colour, float weight, int maxHit, string typeInput)
        {
            HandToHand weapon;

            switch (typeInput)
            {
                case "Knife":
                    weapon = new Knife(name, colour, weight, maxHit);
                    break;

                default:
                    Console.WriteLine("Invalid Type Input, Creating stone");
                    weapon = new Stone(name, colour, weight, maxHit);
                    break;

            }
            H2HWeapons.Add(weapon);
            return weapon;
        }
    }

    public class WeaponFactory
    {
        public List<Weapon> weapons = new List<Weapon>();

        public Weapon CreateWeapon(string name, string company, int ammo)
        {
            Weapon weapon = new Weapon(name, company, ammo);
            weapons.Add(weapon);
            return weapon;
        }
    }


    public class CommandoFactory
    {
        public List<Commando> Operators = new List<Commando>();

        public Commando CreateCommando(string typeInput)
        {
            Commando commando;

            switch (typeInput)
            {
                case "Normal":
                    commando = new Commando();
                    break;

                case "Paratrooper":
                    commando = new Paratrooper();
                    break;

                case "Marine":
                    commando = new AmphibiousCommando();

                    break;

                default:
                    Console.WriteLine("Invalid Type Input, Creating base commando");
                    commando = new Commando();
                    break;

            }
            Operators.Add(commando);
            return commando;
        }
    }

    public class EnemyFactory
    {
        public static List<Enemy> Enemies = new List<Enemy>();

        public static Enemy CreateEnemy()
        {
            Enemy enemy = new Enemy();
            Enemies.Add(enemy);

            return enemy;
        }
    }

}