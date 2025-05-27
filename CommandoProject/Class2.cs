using System;

namespace Commando.Models
{
    public class Weapon
    {
        public string Name { get; set; }
        public string Producer { get; set; }
        public int Cartridge { get; set; } 
        
        public Weapon(string name, string company, int ammo)
        {
            Name = name;
            Producer = company;
            Cartridge = ammo;
        }

        public void Shoot()
        {
            Console.WriteLine($"{Name} Fired");
            Cartridge -= 1;
        }
    }
}
