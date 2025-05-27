using CommandoOOP.Models;

namespace CommandoOOP
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            Commando StrikeUnitMember = new Commando("Or Zelinger", "Jack Reacher");
            Paratrooper ThirtyFirstAirborneMember = new Paratrooper("Menachem Mendel Kuperman", "Eagles Wing");
            AmphibiousCommando MarineCorpMember = new AmphibiousCommando("Eli Fisher", "Deep Dive");

            List<Commando> StrikeTeam = new List<Commando> { StrikeUnitMember, ThirtyFirstAirborneMember, MarineCorpMember };
            foreach (var member in StrikeTeam)
            {
                member.Attack();
            }
        }
    }
}