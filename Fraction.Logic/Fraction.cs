using System;

namespace Logic
{
    /// <summary>
    /// Einfache Realisierung der rationalen Zahlen ohne spätere Themen:
    ///     Fehlerbehandlung über Exceptions
    ///     Properties
    ///     Überladen von Operatoren
    ///     Statische Methoden
    ///     Konstruktor
    /// </summary>
    public class Fraction
    {


        /// <summary>
        /// Zähler belegen
        /// </summary>
        /// <param name="numerator"></param>
        public void SetNumerator(int numerator)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Zähler auslesen
        /// </summary>
        /// <returns>Zähler</returns>
        public int GetNumerator()
        {
            throw new NotImplementedException();
        }


        /// <summary>
        /// Nenner belegen
        /// </summary>
        /// <param name="denominator"></param>
        public void SetDenominator(int denominator)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Nenner auslesen
        /// </summary>
        /// <returns>Nenner</returns>
        public int GetDenominator()
        {
            throw new NotImplementedException();
        }


        /// <summary>
        /// Gekürzte Brüche stimmen bei Zähler und Nenner überein
        /// Ist ein Nenner der beiden Brüche 0 so ist das Ergebnis immer false 
        /// </summary>
        /// <param name="other"></param>
        /// <returns></returns>
        public bool IsEqual(Fraction other)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Wandelt den Bruch in einen String um
        /// </summary>
        /// <returns></returns>
        public string ConvertToString()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Ist die Bruchzahl derzeit gültig?
        /// Eine Bruchzahl ist ungültig, wenn der Nenner 0 ist.
        /// </summary>
        /// <returns></returns>
        public bool IsValid()
        {
            throw new NotImplementedException();
        }

        public double GetValue()
        {
            throw new NotImplementedException();
        }


        /// <summary>
        /// Bruch so weit es geht kürzen
        /// </summary>
        private void Shorten()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// GGT von a und b nicht rekursiv gelöst.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns>ggt(a,b)</returns>
        private static int CalculateGgt(int a, int b)
        {
            throw new NotImplementedException();
        }
    }
}
