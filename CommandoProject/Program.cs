using CommandoOOP.Models;

namespace CommandoOOP
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(WeaponsFactory.CreateWeapon("M-16", "Colt", 29)); 
        }
    }
}