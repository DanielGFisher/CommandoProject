using System;

namespace CommandoOOP.Models
{
    public class Paratrooper : Commando
    {
        public Paratrooper() : base()
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
