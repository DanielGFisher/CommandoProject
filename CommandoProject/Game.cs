using System

using System.Data.Common;

namespace CommandoOOP.Models
{
    public class Game
    {
        private WeaponsFactory weaponCreator = new WeaponsFactory();
        private CommandoFactory commandoFactory = new CommandoFactory();
        private EnemyFactory enemyFactory = new EnemyFactory();

        public Game()
        {

        }

    }
}
