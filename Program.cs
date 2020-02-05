using System;

namespace DIS_inClassThree
{
    class Program
    {
        static void Main(string[] args)
        {
            Car myObj1 = new Car();
            Console.WriteLine(myObj1.color);

            Car myObj2 = new Car();
            Console.WriteLine(myObj2.color);
            Console.WriteLine(myObj2.maxSpeed);

            Car myObj3 = new Car();
            myObj3.color = "vidhi";
            Console.WriteLine(myObj3.color);

            Car2 myObj4 = new Car2();
            Console.WriteLine(myObj4.color);
            Console.WriteLine(myObj4.maxSpeed);

            Car2 myObj5 = new Car2();
            myObj5.fullThrottle();

        }
    }

    class Car
    {
        public string color = "red";
        public int maxSpeed = 300;
    }

    class Car2
    {
        public string color = "green";
        public int maxSpeed = 200;
        public void fullThrottle()
        {
            Console.WriteLine("The car is going as fast as it can!");
        }
    }

    class Car3
    {

    }


}
