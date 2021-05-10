using System;

namespace KalkulatorDz
{
    class Program
    {
        static void Main(string[] args)
        {
            Unos u = new Unos();
            string unosOperacije = null;
            do
            {
                Console.Clear();
                Console.WriteLine("Unesite zeljenu aritmetricku operaciju na sledeci nacin");
                Console.WriteLine("'+' za sabiranje, '-' za oduzimanje, '*' za mnozenje, '/' deljenje, '#' za sumiranje, '>' za maksimum, '<' za minimum, '~' za zamenu vrednosti");
                Console.Write("Bilo koji drugi unos za izlaz iz aplikacije:");
                unosOperacije = Console.ReadLine();
                
                switch (unosOperacije)
                {
                    case "+":
                        double? a1 = u.GetDoubleNumber("Unesite vrednost za promenljivu a: ");
                        double? b1 = u.GetDoubleNumber("Unesite vrednost za promenljivu b: ");
                        if ((a1!=null)&&(b1!=null))
                        Console.WriteLine("Rezultat sabiranja a + b ={0}", AritmetrickeOperacije.Add(Convert.ToDouble(a1), Convert.ToDouble(b1)));
                        break;
                    case "-":
                        double? a2 = u.GetDoubleNumber("Unesite vrednost za promenljivu a: ");
                        double? b2 = u.GetDoubleNumber("Unesite vrednost za promenljivu b: ");
                        if ((a2 != null) && (b2 != null))
                            Console.WriteLine("Rezultat oduzimanja a - b ={0}", AritmetrickeOperacije.Sub(Convert.ToDouble(a2), Convert.ToDouble(b2)));
                        break;
                    case "*":
                        double? a3 = u.GetDoubleNumber("Unesite vrednost za promenljivu a: ");
                        double? b3 = u.GetDoubleNumber("Unesite vrednost za promenljivu b: ");
                        if ((a3 != null) && (b3 != null))
                            Console.WriteLine("Rezultat mnozenja a * b ={0}", AritmetrickeOperacije.Mul(Convert.ToDouble(a3), Convert.ToDouble(b3)));
                        break;
                    case "/":
                        double? a4 = u.GetDoubleNumber("Unesite vrednost za promenljivu a: ");
                        double? b4 = u.GetDoubleNumber("Unesite vrednost za promenljivu b: ");
                        if ((a4 != null) && (b4 != null))
                            Console.WriteLine("Rezultat deljenja a * b ={0}", AritmetrickeOperacije.Div(Convert.ToDouble(a4), Convert.ToDouble(b4)));
                        break;
                    case "#":
                        int a5 = u.GetIntNumber("Unesite broj elemenata niza (mora da bude ceo broj veci od 2): ");
                        if (a5 > 2) {
                            double[] s = u.GetElementsOffArray(a5);
                            Console.WriteLine("Rezultat sume elemenata niza: {0}", AritmetrickeOperacije.Sum(s));
                        } else Console.WriteLine("Broj elemenata niza mora da bude ceo broj veci od 2!");
                        break;
                    case "<":
                        int a6 = u.GetIntNumber("Unesite broj elemenata niza (mora da bude ceo broj veci od 2): ");
                        if (a6 > 2)
                        {
                            double[] s = u.GetElementsOffArray(a6);
                            Console.WriteLine("Najmanji elemenat niza je: {0}", AritmetrickeOperacije.Min(s));
                        }
                        else Console.WriteLine("Broj elemenata niza mora da bude ceo broj veci od 2!");
                        break;
                    case ">":
                        int a7 = u.GetIntNumber("Unesite broj elemenata niza (mora da bude ceo broj veci od 2): ");
                        if (a7 > 2)
                        {
                            double[] s = u.GetElementsOffArray(a7);
                            Console.WriteLine("Najveci elemenat niza je: {0}", AritmetrickeOperacije.Max(s));
                        }
                        else Console.WriteLine("Broj elemenata niza mora da bude ceo broj veci od 2!");
                        break;
                    case "~":
                        double? a8 = u.GetDoubleNumber("Unesite vrednost za promenljivu a: ");
                        double? b8 = u.GetDoubleNumber("Unesite vrednost za promenljivu b: ");
                        if ((a8 != null) && (b8 != null))
                        {
                            AritmetrickeOperacije.ReplaceValues(ref a8, ref b8);
                            Console.WriteLine("Nakon zamene vrednosti a = {0} ,  b={1}" , a8,b8);
                        }
                        break;
                    default:
                        System.Environment.Exit(1);
                        break;
                }
                Console.ReadKey();
            } while (true);
        }
    }

}
