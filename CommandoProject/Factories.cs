using System;

namespace CommandoOOP.Models
{
    public class WeaponsFactory
    {
        public List<Weapon> Weapons = new List<Weapon>();
    }
    public Weapon CreateWeapon(string name, string company, int ammo)
        {
            Weapon weapon = new Weapon(name, company, ammo);
            Weapons.Add(weapon)

        return weapon;
        }

    public class CommandoFactory
    {
        public List<Commando> Operators = new List<Commando>();
    }
    
    public Commando CreateCommando(string nameInput, string codeNameInput, string typeInput)
        {
            Commando commando;

            switch (typeInput)
            {
                case "Normal":
                    Commando commando = new Commando(string nameInput, string codeNameInput);
                    break;

                case "Paratrooper":
                    Paratrooper commando = new Paratrooper(string nameInput, string codeNameInput);
                    break;

                case "Marine":
                    AmphibiousCommando commando = new AmphibiousCommando(string nameInput, string codeNameInput);

                    break;

                default:
                    Console.WriteLine("Invalid Type Input, Creating base commando");
                    Commando commando = new Commando(string nameInput, string codeNameInput);
                    break;

            }
            Operators.Add(commando)
        return commando;
        }

    public class EnemyFactory
    {
        public List<Enemy> Enemies = new List<Enemy>();

        public Enemy CreateEnemy()
        {
            Enemy enemy = new Enemy();

            enemy.Name = Enemy.AddName();
            enemy.EnemyQuote = Enemy.AddQuote();

            Enemies.Add(enemy)

                return eenemy;
        }
    }

}