namespace HelperLib
{
    public class Calculator
    {
        public static double Plus(double n1, double n2, int decimalPlaces = 2)
        {
            double[] n = { n1, n2 };
            return Plus(n, decimalPlaces);
        }
        public static double Plus(double[] n, int decimalPlaces = 2)
        {
            double sum = 0;
            foreach (double d in n)
            {
                if (decimalPlaces >= 0)
                    sum += Math.Round(d, decimalPlaces);
                else
                    sum += d;
            }
            return sum;
        }

        public static double Minus(double n1, double n2, int decimalPlaces = 2)
        {
            double[] n = { n1, n2 };
            return Minus(n, decimalPlaces);
        }
        public static double Minus(double[] n, int decimalPlaces = 2)
        {
            double sum = 0;
            foreach (double d in n)
            {
                if (decimalPlaces >= 0)
                    sum -= Math.Round(d, decimalPlaces);
                else
                    sum -= d;
            }
            return sum;
        }
    }
}