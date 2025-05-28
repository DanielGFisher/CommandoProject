using System;

using System.Data.Common;
using System.Runtime.InteropServices.Swift;
using System.Security.Cryptography.X509Certificates;

namespace CommandoOOP.Models
{
    public class Game
    {
        public WeaponFactory weaponCreator;
        private CommandoFactory commandoFactory;
        private EnemyFactory enemyFactory;

        public Game(WeaponFactory weaponProduction, CommandoFactory commandoProduction, EnemyFactory enemyProduction)
        {
            weaponCreator = weaponProduction;
            commandoFactory = commandoProduction;
            enemyFactory = enemyProduction;
        }
        
        public Weapon LoadWeapon()
        {
            return weaponCreator.CreateWeapon("M-16", "COLT", 29);
        }
    }
}
