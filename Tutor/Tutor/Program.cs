using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutor
{
    public class Car
    {
        int maxSpeed;

        public static void ShowSpeed()
        {
            Car myObj = new Car();
            myObj.maxSpeed = 200;
            Console.WriteLine(myObj.maxSpeed);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int x = 5, y = 6;
            int z = Math.Max(x, y);
            string hello = "Hello";
            Console.WriteLine(hello.ToUpper());
            Console.WriteLine(x + y);
            Car.ShowSpeed();
            Console.ReadKey();
        }
    }
}
