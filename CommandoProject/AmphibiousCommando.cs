using System;

namespace Commando.Models
{
    public class AmphibiousCommando : Commando
    {
        public AmphibiousCommando(string name, List<string>  tools) : base(name,tools)
        {
            Tools = tools;
        }

        public static void Dive()
        {
            Console.WriteLine($"{CodeName} is diving");
        }
    }
}