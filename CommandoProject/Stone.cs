using System;

namespace CommandoOOP.Models
{
    public class Stone : HandToHand
    {
        public Stone(string name, string colour, float weight, int maxHit) : base(name, colour, weight, maxHit)
        {

        }
        public override void Hit()
        {
            if (HitCount == MaxHit) Status = "Smashed";
            else if (HitCount > 0 && HitCount < MaxHit / 2)
            {
                Status = "Chipped";
                HitCount += 1;
                Console.WriteLine($"You hit with {Status} {Name}");
            }
            else if (HitCount > 0 && HitCount > MaxHit / 2)
            {
                Status = "Cracked";
                HitCount += 1;
                Console.WriteLine($"You hit with {Status} {Name}");
            }
        }
    }
}

