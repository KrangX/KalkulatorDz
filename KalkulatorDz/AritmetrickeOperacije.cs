
namespace KalkulatorDz
{
    class AritmetrickeOperacije
    {
        public static double Sum(double[] a)
        {
            double result = 0;
            foreach(double i in a)
            {
                result = result + i;  
            }
            return result;
        }

        public static double Max(double[] a)
        {
            double result = a[0];
            for(int i = 1; i < a.Length; i++)
            {
                if (a[i] > result) result = a[i];
            }
            return result;
        }

        public static double Min(double[] a)
        {
            double result = a[0];
            for (int i = 1; i < a.Length; i++)
            {
                if (a[i] < result) result = a[i];
            }
            return result;
        }


        public static double Add(double a, double b)
        {
            return a + b;
        }
        public static double Sub(double a, double b)
        {
            return a - b;
        }
        public static double Mul(double a, double b)
        {
            return a * b;
        }
        public static double Div(double a, double b)
        {
            return a / b;
        }
        public static void ReplaceValues(ref double? a, ref double? b)
        {
            a = a + b;
            b = a - b;
            a = a - b;
        }


    }
}
