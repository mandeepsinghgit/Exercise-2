using System;

namespace Exercise_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int age;
            int height;
            // Max heart rate is 220-age

            age = 23;
            height = 186;
            // Console should write: I am ## years old, my max heartrate is ##,
            // and I am ## centimeters tall.
            int heartrate;
            heartrate = 220 - age;


           

            Console.Write("I am " + age + " years old, My max heartrate is " + heartrate + ", I am " + height + " centimeters tall.");
           
            Console.ReadLine();
        }
    }
}
