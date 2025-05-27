using System;

namespace Commando.Models
{
    public class Paratrooper : Commando
    {
        public Paratrooper(string name, List<string> tools) : base(name,tools)
        {
            Tools = tools;
        }

        public void Parachute()
        {
            Console.WriteLine($"{CodeName} is parachuting");
            CurrentStatus = "In the air";
        }
    }
}
