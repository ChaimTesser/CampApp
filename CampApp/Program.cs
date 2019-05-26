using CampLib.Models;
using System;

namespace CampApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Name");
            Camper c = new Camper();
            c.FirstName = Console.ReadLine();
            Console.WriteLine("Hello " + c.FirstName);
        }
    }
}
