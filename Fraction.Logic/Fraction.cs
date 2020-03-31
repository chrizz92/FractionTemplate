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
        private int _numerator;
        private int _denominator;
        private int _ggt;
        private bool _isNumeratorSet;
        private bool _isDenominatorSet;
        private bool _validDenominatorIsSet;

        /// <summary>
        /// Zähler belegen
        /// </summary>
        /// <param name="numerator"></param>
        public void SetNumerator(int numerator)
        {
            _numerator = numerator;
            _isNumeratorSet = true;
        }

        /// <summary>
        /// Zähler auslesen
        /// </summary>
        /// <returns>Zähler</returns>
        public int GetNumerator()
        {
            if (_isNumeratorSet && _validDenominatorIsSet)
            {
                Shorten();
            }
            return _numerator;
        }

        /// <summary>
        /// Nenner belegen
        /// </summary>
        /// <param name="denominator"></param>
        public void SetDenominator(int denominator)
        {
            _denominator = denominator;
            _isDenominatorSet = true;

            if (denominator != 0)
            {
                _validDenominatorIsSet = true;
            }
            else
            {
                _validDenominatorIsSet = false;
            }
        }

        /// <summary>
        /// Nenner auslesen
        /// </summary>
        /// <returns>Nenner</returns>
        public int GetDenominator()
        {
            if (_isNumeratorSet && _validDenominatorIsSet)
            {
                Shorten();
            }
            return _denominator;
        }

        /// <summary>
        /// Gekürzte Brüche stimmen bei Zähler und Nenner überein
        /// Ist ein Nenner der beiden Brüche 0 so ist das Ergebnis immer false
        /// </summary>
        /// <param name="other"></param>
        /// <returns></returns>
        public bool IsEqual(Fraction other)
        {
            bool fractionsAreEqual = false;

            if (this._numerator == other.GetNumerator() && this._denominator == other.GetDenominator())
            {
                fractionsAreEqual = true;
            }

            return fractionsAreEqual;
        }

        /// <summary>
        /// Wandelt den Bruch in einen String um
        /// </summary>
        /// <returns></returns>
        public string ConvertToString()
        {
            string stringToReturn;

            if (_isDenominatorSet && !_validDenominatorIsSet)
            {
                stringToReturn = "denominator is set to 0";
            }
            else if (!_validDenominatorIsSet)
            {
                stringToReturn = "denominator is not initialized";
            }
            else
            {
                Shorten();
                stringToReturn = $"{_numerator}/{_denominator}";
            }

            return stringToReturn;
        }

        /// <summary>
        /// Ist die Bruchzahl derzeit gültig?
        /// Eine Bruchzahl ist ungültig, wenn der Nenner 0 ist.
        /// </summary>
        /// <returns></returns>
        public bool IsValid()
        {
            bool valueIsValid = true;

            if (!_isNumeratorSet || !_validDenominatorIsSet)
            {
                valueIsValid = false;
            }

            return valueIsValid;
        }

        public double GetValue()
        {
            double valueToReturn;
            if (_isNumeratorSet && _validDenominatorIsSet)
            {
                valueToReturn = _numerator / ((double)_denominator);
            }
            else if (!_validDenominatorIsSet)
            {
                valueToReturn = Double.MaxValue;
            }
            else
            {
                valueToReturn = Double.MinValue;
            }

            return valueToReturn;
        }

        /// <summary>
        /// Bruch so weit es geht kürzen
        /// </summary>
        private void Shorten()
        {
            _ggt = CalculateGgt(_numerator, _denominator);
            _numerator = _numerator / _ggt;
            _denominator = _denominator / _ggt;
        }

        /// <summary>
        /// GGT von a und b nicht rekursiv gelöst.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns>ggt(a,b)</returns>
        private static int CalculateGgt(int a, int b)
        {
            int temp;

            do
            {
                temp = a % b;
                a = b;
                b = temp;
            } while (temp > 0);

            return a;
        }
    }
}