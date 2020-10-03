using System;

namespace bmiclass
{
    class BMI
    {
        private double blm;

        public double Calc(double bl, double bw)
        {
            blm = bl / 100.0;
            return bw / Math.Pow(blm, 2.0);
        }
    }

    class BMIclass
    {
        public static void Main()
        {
            string strBl, strBw;
            double blcm, bwkg;

            Console.Write("--- 身長(cm)");
            strBl = Console.ReadLine();
            blcm = double.Parse(strBl);

            Console.Write("--- 体重(kg)");
            strBw = Console.ReadLine();
            bwkg = double.Parse(strBw);

            BMI bmi = new BMI();

            Console.WriteLine(bmi.Calc(blcm, bwkg));
        }
    }
}
