using System;
using Logic;

namespace ConsoleApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string equal = "";
            Fraction fractionOne = new Fraction();
            Fraction fractionTwo = new Fraction();
            Console.WriteLine("Brüche vereinfachen&vergleichen");
            Console.WriteLine("===============================");
            Console.Write("Bitte ersten Zähler eingeben: ");
            fractionOne.SetNumerator(Convert.ToInt32(Console.ReadLine()));
            Console.Write("Bitte ersten Nenner eingeben: ");
            fractionOne.SetDenominator(Convert.ToInt32(Console.ReadLine()));
            Console.WriteLine("===============================");
            Console.WriteLine("gekürzter Bruch:  {0}", fractionOne.ConvertToString());
            Console.WriteLine("numerischer Wert: {0:F11}", fractionOne.GetValue());
            Console.WriteLine("===============================");
            Console.Write("Bitte zweiten Zähler eingeben: ");
            fractionTwo.SetNumerator(Convert.ToInt32(Console.ReadLine()));
            Console.Write("Bitte zweiten Nenner eingeben: ");
            fractionTwo.SetDenominator(Convert.ToInt32(Console.ReadLine()));
            Console.WriteLine("===============================");
            Console.WriteLine("gekürzter Bruch:  {0}", fractionTwo.ConvertToString());
            Console.WriteLine("numerischer Wert: {0:F11}", fractionTwo.GetValue());
            if (fractionOne.IsEqual(fractionTwo))
            {
                equal = "ja";
            }
            else
            {
                equal = "nein";
            }
            Console.WriteLine("Gleichwertig?:    {0}", equal);
            Console.WriteLine("===============================");
        }
    }
}