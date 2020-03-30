using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _01_TypesAndVariables
{
    [TestClass]
    public class ReferenceTypeExamples
    {
        [TestMethod]
        public void Strings()
        {
            string thisIsDeclaration;
            string declared;
            declared = "This is initialized.";
            string declarationAndInitialization = "This is declaring and initializing.";// dec and init on same line

            string firstName = "Amanda";
            string lastName = "Knight";
            string concatenatedFullName = firstName + " " + lastName + ".";

            string compositeFullName = string.Format("{0} {1}", firstName, lastName);

            string interpolatedFullName = ($"Hello {firstName} {lastName}. Whatever I wanted. {firstName}");

            Console.WriteLine(firstName);
            Console.WriteLine(lastName);
            Console.WriteLine(concatenatedFullName);
            Console.WriteLine(compositeFullName);
            Console.WriteLine(interpolatedFullName);
        }
        //pull new code from amandas github, just in case
        [TestMethod]
        public void Collections()
        {
        }

        [TestMethod]
        public void Classes()
        {
        }
    }
}