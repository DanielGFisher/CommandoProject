using System;

namespace CommandoOOP.Models
{
    public class AmphibiousCommando : Commando
    {
        public AmphibiousCommando(string name,string codename) : base(name, codename)
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