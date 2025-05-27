using System;

namespace Commando.Models
{
    public class Commando
    {
        public string Name { get; set; }
        public string CodeName { get; set; }
        public List<string> Tools { get; set; }
        public string CurrentStatus { get; set; }

        public Commando(string name, string codename, List<string> tools, string status)
        {
            Name = name;
            CodeName = codename;
            Tools = tools;
            CurrentStatus = status;
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
            CurrentStatus = "Hiding";
        }
    }
}