using System;

namespace CommandoOOP.Models
{
    public class WeaponsFactory
    {
        public static List<Weapon> Weapons = new List<Weapon>();
        public static Weapon CreateWeapon(string name, string company, int ammo)
        {
            Weapon weapon = new Weapon(name, company, ammo);
            Weapons.Add(weapon);

            return weapon;
        }
    }

    public class CommandoFactory
    {
        public static List<Commando> Operators = new List<Commando>();

        public static Commando CreateCommando(string typeInput)
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