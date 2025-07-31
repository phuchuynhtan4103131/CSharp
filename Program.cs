// See https://aka.ms/new-console-template for more information
using System;
using System.Linq.Expressions;
using System.Reflection.Metadata.Ecma335;

namespace Hello
{
    class Program
    {

        public static void Main(string[] args)
        {
            Chicken chicken = new Chicken();
            yns yns = new yns();
            chicken.flee();
            yns.hunt();
        }
    }
    interface Prey
    {
        void flee();
    }

    interface Predator
    {
        void hunt();
    }
    class Chicken : Prey
    {
        public void flee()
        {
            System.Console.WriteLine("Running from a black guy");
        }

    }
        class yns : Predator
        {
            public void hunt()
            {
                System.Console.WriteLine("Heading to KFC 🍗🍗🍗🍗🍗");
            }
        }
    }


