using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMI
{
    class Program
    {
        public static void Main()
        {
            Console.Write("Vill du räkna ut BMI?");
            if (Console.ReadLine().ToLower() == "ja")
            {
                RäknaUt();
                Console.ReadLine();
            } 
            else
            {
                Console.Write("SAD");
            }
        }

        public static void RäknaUt()
        {
            double vikt = 0;
            double längd = 0;
            int midjemått = 0;

            /**
             * get weight and check if it is an double
             * */
            Console.Write("Ange vikt: ");
            if (!double.TryParse(Console.ReadLine(), out vikt))
            {
                Console.WriteLine("Måste vara ett numeriskt värde");
                return;
            }

            Console.Write("Ange längd: ");
            if (!double.TryParse(Console.ReadLine(), out längd))
            {
                Console.WriteLine("Måste vara ett numeriskt värde");
                return;
            }

            Console.Write("Ange midjemått: ");
            midjemått = int.Parse(Console.ReadLine());

            double bmi = längd / vikt;

            bmi = bmi * bmi;

            Console.WriteLine("BMI: " + bmi.ToString("F"));

            if (bmi > 18.5)
            {
                Console.WriteLine("Undervikt!");
            }
            else if (bmi > 25)
            {
                Console.WriteLine("Normalvikt!");
            }
            else if (bmi > 30)
            {
                Console.WriteLine("Måttlig övervikt!");
            }
            else
            {
                Console.WriteLine("Klinisk fara!");
            }
        }

        public static double ReadDouble(double label)
        {
            Console.Write(label);
            double d = 0;

            while (!double.TryParse(Console.ReadLine(), out d))
            {
                Console.WriteLine("Måste vara ett numeriskt värde");
                Console.Write(label);
            }
            return d;
        }


    }
}
