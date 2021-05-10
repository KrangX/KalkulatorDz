using System;

namespace KalkulatorDz
{
    class Unos
    {
        public double[] GetElementsOffArray(int arrayCount) {
            double[] inputArray = new double[arrayCount];
            
            for(int count=0; count<arrayCount; count++)
            {
                do
                {
                    Console.Write("niz[{0}]=", count);
                    try
                    {
                        inputArray[count] = Convert.ToDouble(Console.ReadLine());
                        break;
                    }
                    catch 
                    {
                        Console.WriteLine("User input must be value type of double!");
                    }
                } while (true);
            }
            return inputArray;
        }
        public int GetIntNumber(string userMessage) {
            int inputIntNumber = 0;
            Console.Write(userMessage);

            try
            {
                inputIntNumber = Convert.ToUInt16(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("This is not valid integer value!");
                return -1;
            }
            return inputIntNumber;
        }
        public double? GetDoubleNumber(string userMessage)
        {
            double? inputDoubleNumber = null;
            Console.Write(userMessage);

            try
            {
                inputDoubleNumber = Convert.ToDouble(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("This is not valid double value!");
                return null;
            }
            return inputDoubleNumber;
        }
    }
}
