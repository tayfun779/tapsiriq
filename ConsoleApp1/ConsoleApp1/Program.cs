using System;
using System.Collections.Generic;

namespace Program
{
    public class person
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Age { get; set; }
    }
    public class Program
    {

        public static void Main(string[] args)
        {
            var pr1 = new person()
            {
                Name = "Qalib",
                Surname = " Agaev",
                Age = "19"
            };
            var pr2 = new person()
            {
                Name = "Qafur",
                Surname = "Mamedof",
                Age = "20"
            };
            var pr3 = new person()
            {
                Name = "Gunduz",
                Surname = "Nuriev",
                Age = "21"
            };
            var pr4 = new person()
            {
                Name = "Revan",
                Surname = "Nuri",
                Age = "19"
            };
            var pr5 = new person()
            {
                Name = "Mahammad",
                Surname = "Azizov",
                Age = "24"
            };
            var pr6 = new person()
            {
                Name = "Amin",
                Surname = "Agaev",
                Age = "25"

            };
            var pr7 = new person()
            {
                Name = "Farid",
                Surname = "Azizov",
                Age = "26"

            };
            var pr8 = new person()
            {
                Name = "Taleh",
                Surname = "Shamiev",
                Age = "27"
            };
            var pr9 = new person()
            {
                Name = "Ayxan",
                Surname = "Elxanly",
                Age = "21"
            };
            var pr10 = new person()
            {
                Name = "Altun",
                Surname = "Asifli",
                Age = "23"
            };
            var list = new List<person>();
            list.Add(pr1);
            list.Add(pr2);
            list.Add(pr3);
            list.Add(pr4);
            list.Add(pr5);
            list.Add(pr6);
            list.Add(pr7);
            list.Add(pr8);
            list.Add(pr9);
            list.Add(pr10);
            Console.WriteLine("please enter name");
            string input = Console.ReadLine();
            var result = list.Find(x => x.Name == input);
            if (result == null)
            {
                Console.WriteLine("Not founded:(");
            }
            else
                Console.WriteLine("Founded:)");
        }

    }
}

