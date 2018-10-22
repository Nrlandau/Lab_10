//Lab 10 by Nicholas Landau
using System;
using System.Text.RegularExpressions;

namespace Lab10
{
    class Circle
    {
        //vars
        double radius;
        static int numCircles = 0;
        //constructer
        public Circle(double r)
        {
            if(r < 0)
                throw new ArgumentOutOfRangeException("The radius of a circle must be nonnegitive");
            radius = r;
            numCircles++;
        }
        //methods
        public double CalculateCircumference() //2PIr
        {
            return Math.PI * 2.0 * radius;
        }
        public string CalculateFormattedCircumference()
        {
            return FormatNumber(CalculateCircumference());
        }
        public double CalculateArea() //PIr^2
        {
            return Math.PI * radius * radius;
        }
        public string CalculateFormattedArea()
        {
            return FormatNumber(CalculateArea());
        }
        private string FormatNumber(double x)
        {
            return Math.Round(x,2).ToString();
        }
        //Properties
        public double Radius
        {
            get
            {
                return radius;
            }
            set
            {
                if(value < 0)
                    throw new ArgumentOutOfRangeException("The radius of a circle must be nonnegitive");
                radius = value;
            }
        }
        public static int NumCircles 
        {
            get
            {
                return numCircles;
            }
        }

    }
    class Program
    {
        static Circle getInput()
        {
            Circle cir;
            while (true)
            {
                try
                {
                    System.Console.WriteLine("Input a radius for a circle:");
                    cir = new Circle(double.Parse(System.Console.ReadLine()));
                    return cir;
                }
                catch(ArgumentOutOfRangeException ex) //negitive input
                {
                    System.Console.WriteLine(ex.Message);
                }
                catch(FormatException)
                {
                    System.Console.WriteLine("That is not a number");
                }
            }
        }
        static bool isContinue() 
        {
            string con;
            while(true)
            {
            System.Console.WriteLine("Do you want to enter another Circle");
            con = System.Console.ReadLine();
            if(Regex.IsMatch(con,@"^[nNyY]"))
            {
                if(Regex.IsMatch(con,@"^[nN]"))
                    return false;
                return true;
            }
            }

        }
        static void Main(string[] args) 
        {
            Circle circle;
            while (true)
            {
                circle = getInput();
                System.Console.WriteLine("Circumference: {0}\nArea:           {1}",circle.CalculateFormattedCircumference(),circle.CalculateFormattedArea());
                if(!isContinue())
                    break;
            }
            System.Console.WriteLine("You made {0} circles",Circle.NumCircles);
        }
    }
}
