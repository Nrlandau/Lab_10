using System;

namespace Lab10
{
    class Circle
    {
        //vars
        double radius;
        //constructer
        public Circle()
        {

        }
        //methods
        public double CalculateCircumference()
        {
            return Math.PI * 2.0 * radius;
        }
        public string CalculateFormattedCircumference(){return "";}
        public double CalculateArea(){return 0;}
        public string CalculateFormattedArea(){return "";}
        private string FormatNumber(double x){return "";}
        //Propertys
        public double Radius
        {
            get{return radius;}
            set{radius = value;}
        }

    }
    class Program
    {
        static void Main(string[] args)
        {

        }
    }
}
