using Microsoft.VisualStudio.TestTools.UnitTesting;
using Logic;
using System;

namespace TestLogic
{
    [TestClass]
    public class FractionTests
    {
        [TestMethod()]
        public void GetNumerator_SetNumerator_ShouldReturnSettedValue()
        {
            Fraction fraction = new Fraction();
            fraction.SetNumerator(3);
            Assert.AreEqual(3, fraction.GetNumerator());
        }

        [TestMethod()]
        public void GetDenominator_SetDenominator_ShouldReturnSettedValue()
        {
            Fraction fraction = new Fraction();
            fraction.SetDenominator(3);
            Assert.AreEqual(3, fraction.GetDenominator());
        }

        [TestMethod()]
        public void IsValid_SetOnlyNumerator_ShouldReturnInvalid()
        {
            Fraction fraction = new Fraction();
            fraction.SetNumerator(3);
            Assert.IsFalse(fraction.IsValid());
        }

        [TestMethod()]
        public void IsValid_SetNumeratorAndDenominator_ShouldReturnValid()
        {
            Fraction fraction = new Fraction();
            fraction.SetNumerator(3);
            fraction.SetDenominator(4);
            Assert.IsTrue(fraction.IsValid());
        }

        [TestMethod()]
        public void IsValid_DenominatorTo0_ShouldReturnInvalid()
        {
            Fraction fraction = new Fraction();
            fraction.SetNumerator(3);
            fraction.SetDenominator(4);
            fraction.SetDenominator(0);
            Assert.IsFalse(fraction.IsValid());
        }

        [TestMethod()]
        public void GetNumerator_FractionCannotBeShortened_ShouldReturnOriginalValue()
        {
            Fraction fraction = new Fraction();
            fraction.SetNumerator(8);
            fraction.SetDenominator(19);
            Assert.AreEqual(8, fraction.GetNumerator());
        }

        [TestMethod()]
        public void GetDenominator_FractionCannotBeShortened_ShouldReturnOriginalValue()
        {
            Fraction fraction = new Fraction();
            fraction.SetNumerator(8);
            fraction.SetDenominator(19);
            Assert.AreEqual(19, fraction.GetDenominator());
        }

        [TestMethod()]
        public void GetNumerator_FractionCanBeShortened_ShouldReturnShortenedValue()
        {
            Fraction fraction = new Fraction();
            fraction.SetNumerator(8);
            fraction.SetDenominator(28);
            Assert.AreEqual(2, fraction.GetNumerator());
        }

        [TestMethod()]
        public void GetDenominator_FractionCanBeShortened_ShouldReturnShortenedValue()
        {
            Fraction fraction = new Fraction();
            fraction.SetNumerator(8);
            fraction.SetDenominator(28);
            Assert.AreEqual(7, fraction.GetDenominator());
        }

        [TestMethod()]
        public void GetValue_InvalidDenominator_ShouldReturnMaxValue()
        {
            Fraction fraction = new Fraction();
            fraction.SetNumerator(3);
            Assert.AreEqual(Double.MaxValue, fraction.GetValue(), 0.01);
        }

        [TestMethod()]
        public void GetValue_FractionIsValid_ShouldReturnDoubleValue()
        {
            Fraction fraction = new Fraction();
            fraction.SetNumerator(3);
            fraction.SetDenominator(4);
            Assert.AreEqual(0.75, fraction.GetValue(), 0.01);
        }

        [TestMethod()]
        public void IsEqual_DifferentFractions_ShouldReturnFalse()
        {
            // Ungleiche Brüche
            Fraction fraction = new Fraction();
            Fraction other = new Fraction();
            fraction.SetNumerator(3);
            fraction.SetDenominator(4);
            other.SetNumerator(7);
            other.SetDenominator(5);
            Assert.IsFalse(fraction.IsEqual(other));
        }

        [TestMethod()]
        public void IsEqual_IsEqualAfterNormalize_ShouldReturnTrue()
        {
            // Ungleiche Brüche
            Fraction fraction = new Fraction();
            Fraction other = new Fraction();
            fraction.SetNumerator(3);
            fraction.SetDenominator(4);
            other.SetNumerator(6);
            other.SetDenominator(8);
            Assert.IsTrue(fraction.IsEqual(other));
        }

        [TestMethod()]
        public void IsEqual_InvalidFraction_ShouldReturnFalse()
        {
            // Ungleiche Brüche
            Fraction fraction = new Fraction();
            Fraction other = new Fraction();
            fraction.SetNumerator(3);
            fraction.SetDenominator(1);
            other.SetNumerator(6);
            other.SetDenominator(0);
            Assert.IsFalse(fraction.IsEqual(other));
        }

        [TestMethod()]
        public void ConvertToString_DenominatorNotInitialized_ShouldReturnErrorText()
        {
            Fraction fraction = new Fraction();
            fraction.SetNumerator(3);
            string actual = fraction.ConvertToString();
            string expected = "denominator is not initialized";
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void ConvertToString_DenominatorIs0_ShouldReturnErrorText()
        {
            Fraction fraction = new Fraction();
            fraction.SetNumerator(3);
            fraction.SetDenominator(0);
            string actual = fraction.ConvertToString();
            string expected = "denominator is set to 0";
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void ConvertToString_FractionCanBeShortened_ShouldReturnShortenedText()
        {
            Fraction fraction = new Fraction();
            fraction.SetNumerator(6);
            fraction.SetDenominator(8);
            string actual = fraction.ConvertToString();
            string expected = "3/4";
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void ConvertToString_FractionCannotBeShortened_ShouldReturnCorrectText()
        {
            Fraction fraction = new Fraction();
            fraction.SetNumerator(3);
            fraction.SetDenominator(4);
            string actual = fraction.ConvertToString();
            string expected = "3/4";
            Assert.AreEqual(expected, actual);
        }
    }
}