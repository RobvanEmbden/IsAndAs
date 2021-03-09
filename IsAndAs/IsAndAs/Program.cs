using System;

namespace IsAndAs
{
    class Program
    {
        static void Main(string[] args)
        {// Is and As in C# working with objects
            Object apple = new Apple("Granny Smith", .6);
            if (apple is Apple)
            {
                Apple granny = apple as Apple;
                Console.WriteLine("Type: {0}, cost per dozen: {1}{2}", granny.Kind, granny.GetCost(), Environment.NewLine);
            }
            else
            {
                Console.WriteLine("This is not an apple!");
            }
        }
    }
    abstract class Fruit // base class - top of hierarchy
    {
        public string Kind { get; protected set; }
        public double Cost { get; protected set; }
        abstract public string GetCost();
    }
    class Apple : Fruit // derived class - an apple is a fruit
    {
        public Apple(string k, double c)
        {
            Kind = k;
            Cost = c;
        }
        public override string GetCost()
        {
            return "$" + Cost * 12;
        }
    }
    class Orange : Fruit // derived class - an orange is a fruit
    {
        public Orange(string k, double c)
        {
            Kind = k;
            Cost = c;
        }
        public override string GetCost()
        {
            return "$" + Cost * 12;
        }
    }
}
