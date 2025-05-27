using System;
using System.ComponentModel.Design;

namespace Commando.Models
{
    public class Commando
    {
        private string Name;
        private string CodeName { get; set; }
        public List<string> Tools { get; set; }
        public string CurrentStatus { get; set; }

        public Commando(string name, List<string> tools)
        {
            Name = name;
            Tools = tools;
            CurrentStatus = "N/A";
        }

        public string NameReveal(string commanderRank)
        {
            if (commanderRank == "GENERAL") return $"Name: {Name}"; 
            else if (commanderRank == "COLONEL") return $"Code Name: {CodeName}";
            else return "Rank inssuficient";   
        }

        public void Walk()
        {
            Console.WriteLine($"{CodeName} is walking");
            CurrentStatus = "Walking";
        }

        public void Hide()
        {
            Console.WriteLine($"{CodeName} is hiding");
            CurrentStatus = "Hiding";
        }

        public void Attack()
        {
            Console.WriteLine($"{CodeName} is attacking");
            CurrentStatus = "In combat";
        }
    }
}