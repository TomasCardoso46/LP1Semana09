using System;
using System.Collections.Generic;   

namespace EqualPlayer
{
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
    class Program
    {
        static void Main(String[] args)
        {
            HashSet<Player> players = new HashSet<Player>();
            players.Add(new Player(PlayerClass.Tank,"Ana"));
            players.Add(new Player(PlayerClass.Slayer,"Paulo"));
            players.Add(new Player(PlayerClass.Tank,"Ana"));
            foreach (Player p in players)
            {
                Console.WriteLine($"{p.Name} is a {p.PClass}");
            }
        }
    }
}
