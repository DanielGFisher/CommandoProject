using System;

namespace CommandoOOP.Models
{
    public class Paratrooper : Commando
    {
        public Paratrooper(string name,string codename) : base(name, codename)
        {

        }

        public void Parachute()
        {
            Console.WriteLine($"{_CodeName} is parachuting");
            CurrentStatus = "In the air";
        }
        public override void Attack()
        {
            Console.WriteLine($"{_CodeName} is engaging from the skies");
        }
    }
}
