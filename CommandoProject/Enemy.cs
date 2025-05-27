using System;

namespace CommandoOOP.Models
{
    public class Enemy
    {
        public static string Name = AddName();
        public int Health = 100;
        public string Status = "Alive";
        public static string EnemyQuote = AddQuote();

        public static string AddName()
        {
            string[] badGuyNames = {"Victor Grimsbane", "Silas Crowe", "Damien Thornhart",
                "Lucien Blackmoor", "Kara Vyle", "Gideon Thorne",
                "Morgana Kreel", "Vlad Vire", "Ezra Grimm", "Nikolai Drex" };

            Random rnd = new Random();
            string Name = badGuyNames[rnd.Next(0, badGuyNames.Length - 1)];

            return Name;
        }

        public static string AddQuote()
        {
            string[] badGuyQuotes = {"You can’t stop what’s already begun.", "Heroes are so predictable.",
             "This world will burn, and I will light the match.", "Power is taken, not given.",
             "I’m not the villain. I’m the solution.",
             "Fear is the only true motivator.", "The end justifies the devastation.",
             "You're already too late.", "I was never one of you.", "They called me a monster. So I became one.",
             "Mercy is for the weak.", "Hope is a fragile thing. Easy to crush.", "Your resistance only amuses me.",
             "Darkness is where I thrive.", "Every empire begins with a single betrayal.",
             "I offer chaos… and clarity.", "You don't need to understand. You only need to obey.",
             "My patience is thinner than your chances.", "Your fate was sealed the moment you opposed me.",
             "I don’t lose. I adapt."
             };

            Random rnd = new Random();
            string Quote = badGuyQuotes[rnd.Next(0, badGuyQuotes.Length - 1)];

            return Quote;
        }
    }
}

    
    


