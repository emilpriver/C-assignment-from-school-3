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
            RäknaUt();
            Console.ReadLine();
        }

        public static void RäknaUt()
        {
            double vikt = 0;
            double längd = 0;
            int midjemått = 0;

            Console.Write("Ange vikt: ");
            vikt = double.Parse(Console.ReadLine());
            Console.Write("Ange längd: ");
            längd = double.Parse(Console.ReadLine());
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

        // Den här metoden kan ge en hint om hur 
        // uppgift j kan lösas... ;-)
        public static double ReadDouble(string label)
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
