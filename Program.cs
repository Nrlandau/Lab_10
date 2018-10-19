﻿using System;

namespace Lab10
{
    class Circle
    {
        //vars
        double radius;
        static int numCircles = 0 ;
        //constructer
        public Circle(double r)
        {
            if(r < 0)
                throw new ArgumentOutOfRangeException("The radius of a circle must be nonnegitive");
            radius = r;
            numCircles++;
        }
        //methods
        public double CalculateCircumference()
        {
            return Math.PI * 2.0 * radius;
        }
        public string CalculateFormattedCircumference()
        {
            return FormatNumber(CalculateCircumference());
        }
        public double CalculateArea()
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
        static void Main(string[] args)
        {
            
        }
    }
}
