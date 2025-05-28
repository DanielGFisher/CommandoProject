using System;

namespace CommandoOOP.Models
{
    public class Knife : HandToHand
    {
        public Knife(string name, string colour, float weight, int maxHit) : base(name, colour, weight, maxHit)
        {

        }

        public override void Hit()
        {
            if (HitCount == MaxHit) Status = "Broken";
            else if (HitCount > 0 && HitCount < MaxHit / 2)
            {
                Status = "Dulled";
                HitCount += 1;
                Console.WriteLine($"You hit with {Status} {Name}");
            }
            else if (HitCount > 0 && HitCount > MaxHit / 2)
            {
                Status = "Rusted";
                HitCount += 1;
                Console.WriteLine($"You hit with {Status} {Name}");
            }
        }
    }
}