using System;

namespace CommandoOOP.Models
{
    public class Commando
    {
        private string _Name;
        protected string _CodeName;
        public List<string> Tools { get; set; }
        public string CurrentStatus { get; set; }

        public Commando()
        {
            _Name = AddName();
            _CodeName = AddCodeName();
            Tools = new List<string>{ "Gun", "Grenade", "Knapsack", "Water", "Rations" };
            CurrentStatus = "N/A";
        }
        public string NameReveal(string commanderRank)
        {
            if (commanderRank == "GENERAL") return $"Name: {_Name}"; 
            else if (commanderRank == "COLONEL") return $"Code Name: {_CodeName}";
            else return "Rank inssuficient";   
        }

        public void Walk()
        {
            Console.WriteLine($"{_CodeName} is walking");
            CurrentStatus = "Walking";
        }

        public void Hide()
        {
            Console.WriteLine($"{_CodeName} is hiding");
            CurrentStatus = "Hiding";
        }

        public virtual void Attack()
        {
            Console.WriteLine($"{_CodeName} is attacking");
            CurrentStatus = "In combat";
        }

        public static string AddCodeName()
        {
            string[] commandoNames = new string[] { "Shadow Viper", "Iron Hawk", "Ghost Wolf", "Steel Fang", "Crimson Blade", "Black Panther", "Thunder Strike", "Rogue Falcon", "Night Reaper", "Blaze Phantom", "Sniper Fox", "Silent Dagger", "Venom Eagle", "Warhound", "Echo Scorpion" };


            Random rnd = new Random();
            string Name = commandoNames[rnd.Next(0, commandoNames.Length - 1)];

            return Name;
        }

        public static string AddName()
        {
            string[] soldierNames = new string[] { "John Miller", "James Anderson", "Michael Thompson", "Robert Jackson", "William Johnson", "David Martinez", "Christopher Davis", "Matthew Wilson", "Joshua Garcia", "Andrew Moore" };


            Random rnd = new Random();
            string Name = soldierNames[rnd.Next(0, soldierNames.Length - 1)];

            return Name;
        }
    }
}