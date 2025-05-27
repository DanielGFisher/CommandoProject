using System;

namespace CommandoOOP.Models
{
    public class Commando
    {
        private string _Name;
        protected string _CodeName { get; set; }
        public List<string> Tools { get; set; }
        public string CurrentStatus { get; set; }

        public Commando(string name,string codename)
        {
            _Name = name;
            _CodeName = codename;
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
    }
}