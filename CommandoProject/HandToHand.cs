using System;
using System.ComponentModel.Design;

namespace CommandoOOP.Models
{
    public class HandToHand : IBreakable
    {
        public string Name;
        public string Colour;
        public float Weight;
        public string Status = "New";
        public int MaxHit;
        public int HitCount = 0;
        
        public HandToHand(string name, string colour, float weight, int maxHit)
        {
            Name = name;
            Colour = colour;
            Weight = weight;
            MaxHit = maxHit;
        }

        public virtual void Hit()
        {
            if (HitCount == MaxHit) Status = "Broken";
            else if (HitCount > 0 && HitCount < MaxHit / 2) 
            { 
                Status = "Used"; 
                HitCount += 1; 
                Console.WriteLine($"You hit with {Status} {Name}"); 
            }
            else if (HitCount > 0 && HitCount > MaxHit / 2)
            { 
                Status = "Damaged";
                HitCount += 1;
                Console.WriteLine($"You hit with {Status} {Name}");
            }
        }
    }
}
