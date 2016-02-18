using System;
using NFluent;
using NUnit.Framework;

namespace CSharpDiscovery
{
    [TestFixture]
    public class TypesTests
    {
        [Test]
        public void NFluentAndNUnitAreWorking()
        {
            Check.That(true).IsTrue();
        }

        [Test]
        public void anintisnotequaltosameintstringrepresentation()
        {
            string integerasastring = "1";
            int integer = 1;
            Check.That(integerasastring).Not.Equals(integer);
        }

        [Test]
        public void AnIntIsNotEqualToSameIntAsFloat()
        {
            float integerAsAFloat = 1.0F;
            int integer = 1;
            Check.That(integerAsAFloat).Not.Equals(integer);
        }

        [Test]
        public void AnIntIsNotEqualToSameIntAsDouble()
        {
            double integerAsADouble = 1;
            int integer = 1;
            Check.That(integerAsADouble).Not.Equals(integer);
        }

        [Test]
        public void AnIntIsNotEqualToSameIntAsDecimal()
        {
            decimal integerAsADecimal = 1;
            int integer = 1;
            Check.That(integerAsADecimal).Not.Equals(integer);
        }

        [Test]
        public void AnIntIsNotEqualToSameIntAsLong()
        {
            long integerAsLong = 1;
            int integer = 1;
            Check.That(integerAsLong).Not.Equals(integer);
        }

        [Test]
        public void AnIntIsEqualToSameIntAsInt32()
        {
            Int32 integerAsInt32 = 2;
            int integer = 2;
            Check.That(integerAsInt32).Equals(integer);
        }

        [Test]
        public void AFloatCanBeCastedToInteger()
        {
            float single = 1.0F;
            int singleCastedToInteger = (int) single;
            int expectedInteger = 1;

            Check.That(singleCastedToInteger).Equals(expectedInteger);
        }

        [Test]
        public void AnIntCanBeImplicitlyCastedToFloat()
        {
            int integer = 1;
            float singleImplicitlyCastToInteger = (float) integer;
            float expectedSingle = 1.0F;

            Check.That(singleImplicitlyCastToInteger).Equals(expectedSingle);
        }

        [Test]
        public void AStringCanBeParsedToInteger()
        {
            string integerString = "30";
            int integerParsed = int.Parse(integerString);
            int expectedInteger = 30;

            Check.That(integerParsed).Equals(expectedInteger);
        }

        public void ParseFloatStringAsInteger()
        {
            string floatString = "30.0";
            int integer = int.Parse(floatString);
        }

        [Test]
        public void AFloatStringRepresentationCannotBeParsedToInteger()
        {
            // Create a method named ParseFloatStringAsInteger that takes no argument,
            //return void and parse a float string representation "30.0"

            

            Check.That(ParseFloatStringAsInteger).Throws<FormatException>();
        }

        [Test]
        public void TryToParseAStringToInteger()
        {
            string floatString = "30.0";
            int expectedInteger = 0;
            int integerParsed;
            bool tryParseFailed = int.TryParse(floatString, out integerParsed);
            

            // Use int.TryParse, /!\ it uses an "out" argument

            Check.That(integerParsed).Equals(expectedInteger);
            Check.That(tryParseFailed).IsFalse();
        }

        [Test]
        public void UseVarForLessVerbosityButKeepStrongTyping()
        {

            var integerAsAString = "10";
            int integer = 10;
            Check.That(integerAsAString).Not.Equals(integer);
        }

        //[Test]
        //public void NullableIntWithNullValueDoesNotHaveValue()
        //{
        //    // use "int?" to declare a nullable int initialized with null, then try also with Nullable<int>

        //    Check.That(nullableInteger.HasValue).IsFalse();
        //}

        //[Test]
        //public void GettingValueOfANullableIntwithNullValueThrowsAnInvalidOperationException()
        //{
        //    // Create a method named GetNullableIntValue that takes no argument, 
        //    // return void and access a nullable int value (nullableInteger.Value)
        //    Check.That(GetNullableIntValue).Throws<InvalidOperationException>();
        //}

        //[Test]
        //public void NullableIntWithNullValueDoesNotHaveValue()
        //{
        //    // use "int?" to declare a nullable int initialized with 30
            
        //    Check.That(nullableInteger.Value).Equals(30);
        //}
    }
}
