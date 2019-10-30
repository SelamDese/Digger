using System;
using System.Collections.Generic;

namespace Digger
{


    public interface IDigger
    {
        string Name { get; set; }
        void dig();
    }
    public interface IWalker
    {
        string Name { get; set; }
        void walk();
        void run();
    }
    public interface ISwimmer
    {
        string Name { get; set; }
        void swim();
        int MaxDepth { get; }
    }
    public interface IFlier
    {
        string Name { get; set; }
        void fly();
        void land();
    }

    public class Parakeet : IFlier
    {
        public string Name { get; set; }
        public Parakeet(string name)
        {
            Name = name;
        }
        public void fly()
        {
            Console.WriteLine("The parakeet is flying");
        }
        public void land()
        {
            Console.WriteLine("The parakeet has landed");
        }
    }


    public class Earthworm : IDigger
    {
        public string Name { get; set; }
        public Earthworm(string name)
        {
            Name = name;
        }
        public void dig()
        {
            Console.WriteLine("The earthworm is digging");
        }
    }


    public class Terrapin : IWalker, ISwimmer
    {
        public string Name { get; set; }
        public Terrapin(string name)
        {
            Name = name;
        }
        public void walk()
        {
            Console.WriteLine("The terrapin is walking");
        }
        public void run()
        {
            Console.WriteLine("The terrapin is running");
        }
        public void swim()
        {
            Console.WriteLine("The terrapin is swimming");
        }
        public int MaxDepth { get; } = 5;
    }


    public class TimberRattlesnake : IWalker
    {
        public string Name { get; set; }
        public TimberRattlesnake(string name)
        {
            Name = name;
        }
        public void walk()
        {
            Console.WriteLine("The timber rattlesnake is slithering slowly");
        }
        public void run()
        {
            Console.WriteLine("The timber rattlesnake is slithering quickly");
        }
    }


    public class Mouse : IDigger, IWalker
    {
        public string Name { get; set; }
        public Mouse(string name)
        {
            Name = name;
        }
        public void dig()
        {
            Console.WriteLine("The mouse is burrowing");
        }
        public void walk()
        {
            Console.WriteLine("The mouse is walking");
        }
        public void run()
        {
            Console.WriteLine("The mouse is running");
        }
    }


    public class Ant : IDigger, IWalker
    {
        public string Name { get; set; }
        public Ant(string name)
        {
            Name = name;
        }
        public void dig()
        {
            Console.WriteLine("The ant is tunneling");
        }
        public void walk()
        {
            Console.WriteLine("The ant is walking");
        }
        public void run()
        {
            Console.WriteLine("The ant is walking faster");
        }
    }


    public class Finch : IFlier, IWalker
    {
        public string Name { get; set; }
        public Finch(string name)
        {
            Name = name;
        }
        public void fly()
        {
            Console.WriteLine("The finch is flying");
        }
        public void land()
        {
            Console.WriteLine("The finch has landed");
        }
        public void walk()
        {
            Console.WriteLine("The finch is hopping slowly");
        }
        public void run()
        {
            Console.WriteLine("The finch is hopping quickly");
        }
    }


    public class Betta : ISwimmer
    {
        public string Name { get; set; }
        public Betta(string name)
        {
            Name = name;
        }
        public void swim()
        {
            Console.WriteLine("The betta is swimming");
        }
        public int MaxDepth { get; } = 10;
    }


    public class Copperhead : IWalker
    {
        public string Name { get; set; }
        public Copperhead(string name)
        {
            Name = name;
        }
        public void walk()
        {
            Console.WriteLine("The copperhead is slithering slowly");
        }
        public void run()
        {
            Console.WriteLine("The copperhead is slithering quickly");
        }
    }


    public class Gerbil : IDigger, IWalker
    {
        public string Name { get; set; }
        public Gerbil(string name)
        {
            Name = name;
        }
        public void dig()
        {
            Console.WriteLine("The gerbil is burrowing");
        }
        public void walk()
        {
            Console.WriteLine("The gerbil is walking");
        }
        public void run()
        {
            Console.WriteLine("The gerbil is running");
        }
    }


    public class DiggerContainer
    {
        public List<IDigger> ContainedAnimals = new List<IDigger>();
    }
    public class WalkerContainer
    {
        public List<IWalker> ContainedAnimals = new List<IWalker>();
    }
    public class SwimmerContainer
    {
        public List<ISwimmer> ContainedAnimals = new List<ISwimmer>();
    }
    public class FlierContainer
    {
        public List<IFlier> ContainedAnimals = new List<IFlier>();
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
