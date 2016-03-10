using NFluent;
using NUnit.Framework;

namespace CSharpDiscovery
{
    using System.Diagnostics;

    [TestFixture]
    public class ClassesTests
    {
       
        [Test]
        public void CreateACalculatorClassWithADefaultConstructorAndInstanciate()
        {
            Calculator calculator = new Calculator();
            Check.That(calculator).IsNotNull();
        }

        [Test]
        public void AddAnotherConstructorWithAFriendlyNameAndInstanciate()
        {
            // use a public member for Name for now, i.e public string Name;
            Calculator calculator = new Calculator();
            calculator.Name = "Calculator";
            Check.That(calculator.Name).Equals("Calculator");
        }

        [Test]
        public void AddAMethodThatMakeASumOfAnArrayOfDouble()
        {
            var valuesToSum = new[] { 1.3, 1.7 };
            Calculator  resultat = new Calculator();
            double sumOfTheArray = resultat.Sum(valuesToSum);
            // add a method Sum to calculator class
            Check.That(sumOfTheArray).Equals(3.0);
        }

        //[Test]
        //public void AddAMethodOverloadThatMakeASumOfTwoDoubleFromStringRepresentation()
        //{
        //    var sumOfTwoDoubleFromString = "1,0+2";
        //    // add a method with the same name that uses the previous method
        //    // tips : use string.Split
        //    Check.That(onePlusTwo).Equals(3.0);
        //}

        //[Test]
        //public void AddAGetterForNameInsteadOfPublicNameMember()
        //{
        //    Check.That(calculator.Name).Equals("Calculator");
        //}

        //[Test]
        //public void AddASetterForNameAndChangeNameWithIt()
        //{
        //    Check.That(calculator.Name).Equals("Enhanced Calculator");
        //}

        //[Test]
        //public void UseObjectInitilizerWithDefaultConstructor()
        //{
        //    Check.That(calculator.Name).Equals("Calculator");
        //}

        //[Test]
        //public void DefineConstantForPi()
        //{
        //    var sumOfADoubleAndPiConstant = "1,2 + pi";
        //    // define pi constant (as double) and replace pi string with constant value
        //    Check.That(sum).Equals(4.34);
        //}

        //[Test]
        //public void StaticReadonlyMembers()
        //{
        //    var sumOfADoubleAndPiConstant = "1,2 + pi";
        //    // replace pi constant with a static readonly member
        //    Check.That(sum).Equals(4.34);
        //}

        //[Test]
        //public void MakeSumMethodsStaticAsTheyDoNotNeedAnyInstanceSpecific()
        //{
        //    // make sum methods static and call one these to retrieve a sum of double array values
        //    Check.That(sum).Equals(3.0);
        //}

        //[Test]
        //public void AddStaticCalculatorClass()
        //{
        //    // define a static class StaticCalculator that uses Calculator static methods & define static getter for Name
        //    Check.That(staticCalculator.Name).Equals("Static calculator");
        //}
    }
}
