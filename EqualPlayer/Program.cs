using System;

namespace EqualPlayer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
    public enum PlayerClass
    {
        Tank,
        Fighter,
        Slayer,
        Mage,
        Controller,
        Marksmen
    }

    public class Player
    {
        public PlayerClass PClass { get;}
        public string Name {get;}

        public Player(PlayerClass pClass, string name)
        {
            PClass = pClass;
            Name = name;    
        }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            Player other = (Player)obj;
            return PClass == other.PClass && Name == other.Name;
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hash = 17;
                hash = hash * 23 + PClass.GetHashCode();
                hash = hash * 23 + (Name != null ? Name.GetHashCode() : 0);
                return hash;
            }
        }
    }
}
