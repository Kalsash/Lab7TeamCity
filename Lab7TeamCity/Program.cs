using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7TeamCity
{
    public class Program
    {
        static void Main(string[] args)
        {


            double a = 1;  // коэффициент при x^2
            double b = 2; // коэффициент при x
            double c = 0;  // свободный член

            List<double> roots = SolveQuadraticEquation(a, b, c);

            if (roots.Count == 0)
            {
                Console.WriteLine("Уравнение не имеет вещественных корней.");
            }
            else if (roots.Count == 1)
            {
                Console.WriteLine("Уравнение имеет один корень: x = {0}", roots[0]);
            }
            else
            {
                Console.WriteLine("Корни уравнения: x1 = {0}, x2 = {1}", roots[0], roots[1]);
            }
        }
        public static List<double> SolveQuadraticEquation(double a, double b, double c)
        {
            List<double> roots = new List<double>();
            if (a == 0)
            {
                if (b == 0)
                    return roots;
                roots.Add(-c / b);
                return roots;
            }


            double discriminant = b * b - 4 * a * c;

            if (discriminant > 0)
            {
                double x1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
                double x2 = (-b - Math.Sqrt(discriminant)) / (2 * a);

                roots.Add(x1);
                roots.Add(x2);
            }
            if (discriminant == 0)
            {
                double x = -b / (2 * a);
                roots.Add(x);
            }

            return roots;
        }
    }
}
