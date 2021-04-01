using System;

namespace PascalTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            string line;
            Console.WriteLine("This program will attempt to generate Pascal's Triangle\nHow tall do u want Pascal's Triangle to be?");
            double heightstore = double.Parse(Console.ReadLine());
            for (double z =1; z <= heightstore; z++) 
            {
                double height = z;
                line = "";
                for (double x = 0; x < height; x++)
                {
                    double value;
                    if (x == 0)
                    {
                        value = 1;
                        line = line+value;
                    }
                    else if (x == 1)
                    {
                        value = height - 1;
                        line = line + " " + value;
                    }
                    else
                    {
                        double temp = height - 2;
                        value = height - 1;
                        for (double y = 1; y < x; y++)
                        {
                            value = value * temp;
                            temp--;
                        }
                        value = value / Factorial(x);
                        line = line + " " + value;
                    }
                }
                Console.WriteLine(line);
            }

            Console.ReadKey();
        }
       static double Factorial(double number)
        {
            double result = number;
            double stored = number - 1;
           for (double x =1; x < number; x++)
            {
                result = result * stored;
                stored--;
            }
            return result;
        }
    }
    
}
