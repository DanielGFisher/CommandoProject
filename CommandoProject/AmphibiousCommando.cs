using System;

namespace CommandoOOP.Models
{
    public class AmphibiousCommando : Commando
    {
        public AmphibiousCommando() : base()
        {
       
        }

        public void Dive()
        {
            Console.WriteLine($"{_CodeName} is diving");
        }

        public override void Attack()
        {
            Console.WriteLine($"{_CodeName} is engaging from the waves");
        }
    }
}