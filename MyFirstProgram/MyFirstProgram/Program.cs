using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.WriteLine("Hello Wolrd");
            Console.WriteLine("I love to eat food!!!");
            */

            /* 
            int x;
            x = 123;


            int y = 321;

            int z = x + y;

            string name = "Paul";

            int age = 21; //whole integer

            double height = 30.1; // decimal number

            bool alive = true;
            char symbol = '@';

            Console.WriteLine("i am " + age + " years old");
            Console.WriteLine("am i alive? " + alive);
            Console.WriteLine("Username is " + symbol + name);
            */


            /*
            //TYPE CASTING

            double a = 3.14;
            int b = Convert.ToInt32(a);

            int c = 123;
            double d = Convert.ToDouble(c);

            int e = 321;
            String f  = Convert.ToString(e);

            String i = "true";
            bool j = Convert.ToBoolean(i);

            Console.WriteLine(c.GetType());
            Console.WriteLine(d);

            Console.WriteLine(b.GetType()); // Used in getting the data type 
            Console.WriteLine(b);

            */


            /* 
            //USER INPUT

            Console.WriteLine("What is your name?");
            String name = Console.ReadLine();

            Console.WriteLine("What's your age? ");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Hello " + name);
            Console.WriteLine("You are " + age + " years old");

            */


            /*

            // ARITHMETIC OPERATION

            int friends = 5;

            friends = friends + 2;
            friends += 2;
            friends++;

            friends = friends - 2;
            friends -= 2;
            friends--;

            friends = friends * 2;
            friends *= 2;
            friends**;

            friends = friends / 2;
            friends /= 2;

            int remainder =  friends % 3;

            */


            /* 
            //MATH CLASS

            double x = 3;
            double y = 5;

            double a = Math.Pow(x, 3);
            double b = Math.Sqrt(x);
            double c = Math.Abs(x);
            double d = Math.Round(x);
            double e = Math.Ceiling(x);
            double f = Math.Floor(x);
            double g = Math.Max(x, y);
            double h = Math.Min(x, y);

            Console.WriteLine(a);
            */

            /*

            //RANDOM NUMBER

            Random random = new Random();

            int num1 = random.Next(1, 7);
            int num2 = random.Next(1, 7);
            int num3 = random.Next(1, 7);

            //double num = random.NextDouble();

            Console.WriteLine(num1);
            Console.WriteLine(num2);
            Console.WriteLine(num3);

            */

            /*

            // STRING METHODS

            String fullName = "Paul Salako";
            String phoneNumber = "123-456-7890";

            fullName = fullName.ToUpper();
            fullName = fullName.ToLower();
            Console.WriteLine(fullName);

            phoneNumber = phoneNumber.Replace("-", "");
            Console.WriteLine(phoneNumber);

            String userName = fullName.Insert(0, "Mr.");
            Console.WriteLine(userName);

            Console.WriteLine(fullName.Length);

            string firstName = fullName.Substring(0, 3);
            string lastName = fullName.Substring(4, 4);
            Console.WriteLine(firstName);
            Console.WriteLine(lastName);

            */

            /*
             
            //IF STATEMENT

            Console.WriteLine("Please enter your age: ");
            int age = Convert.ToInt32(Console.ReadLine());

            if (age >= 18) 
            {
                Console.WriteLine("You are now signed up!");
            } else if (age > 100)
            {
                Console.WriteLine("You are too old to signed up!");
            }
            else if (age < 0)
            {
                Console.WriteLine("You haven't been born yet!");
            }else
            { 
                Console.WriteLine("You must be 18+ to sign up!");
            }
            */

            /*
            Console.WriteLine("Please enter your name! ");
            String name = Console.ReadLine();

            if (name == "")
            { 
                Console.WriteLine("You did not enter your name!");
            }else
            {
                Console.WriteLine("Hello " + name);
            }
            */

            //Console.WriteLine("What day is it today?");
            //String day = Console.ReadLine();

            //if (day == "Monday")
            //{
            //    Console.WriteLine("It's Monday");
            //}
            //else if (day == "Tuesday")
            //{
            //    Console.WriteLine("It's Tuesday");
            //}
            //else if (day == "Wednesday")
            //{
            //    Console.WriteLine("It's Wednesday");
            //}
            //else if (day == "Thursday")
            //{
            //    Console.WriteLine("It's Thursday");
            //}
            //else if (day == "Friday")
            //{
            //    Console.WriteLine("It's Friday");
            //}
            //else if (day == "Saturday")
            //{
            //    Console.WriteLine("It's Saturday");
            //}
            //else if (day == "Sunday")
            //{
            //    Console.WriteLine("It's Sunday");
            //}else
            //{
            //    Console.WriteLine("Its not a day");
            //}

            /*

            // SWITCH CASE

            switch (day)
            {
                case "Monday":
                    Console.WriteLine("It's Monday!");
                    break;

                case "Tuesday":
                    Console.WriteLine("It's Tuesday!");
                    break;

                case "Wednesday":
                    Console.WriteLine("It's Wednesday!");
                    break;

                case "Thurdsay":
                    Console.WriteLine("It's Thurdsay!");
                    break;

                case "Friday":
                    Console.WriteLine("It's Friday!");
                    break;

                case "Saturday":
                    Console.WriteLine("It's Saturday!");
                    break;

                case "Sunday":
                    Console.WriteLine("It's Sunday!");
                    break;

                default:
                    Console.WriteLine("Its not a day");
                    break;
            }

            */

            /*

            //LOGICAL OPERATORS

            Console.WriteLine("What's the temperature outside: (C)");
            double temp = Convert.ToDouble(Console.ReadLine());

            if (temp >= 10 && temp <= 25)
            {
                Console.WriteLine("It's warm outside!");
            } else if (temp <= -50 || temp >= 50)
            {
                Console.WriteLine("DO NOT GO OUTSIDE!");
            }

            */

            /*
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();

            while (name == "")
            {
                Console.WriteLine("Enter your name: ");
                name = Console.ReadLine();
            }
            Console.WriteLine("Hello " + name);

            */


            // FOR LOOPS

            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine(i);
            //}
            //Console.WriteLine("Happy New Year!");

            /*
            Console.Write("How many rows?: ");
            int rows = Convert.ToInt32(Console.ReadLine());

            Console.Write("How many column?: ");
            int columns = Convert.ToInt32(Console.ReadLine());

            Console.Write("What symbol: ");
            string symbol = Console.ReadLine();

            for (int i = 0; i < rows; i++)
            {
                for(int j = 0; j < columns; j++)
                {
                    Console.Write(symbol);
                }
                Console.WriteLine();
            }
            */

            double num1 = 0;
            double num2 = 0;
            double result = 0;

            Console.WriteLine("--------------------");
            Console.WriteLine("Calculator Program");
            Console.WriteLine("--------------------");




            Console.ReadKey();
        }
    }
}
