using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UtilityLibraries;

namespace StringLibraryTest
{
    [TestClass]
    public class TestStringLibrary
    {
        [TestMethod]
        public void TestStartsWithUpper()
        {

            //Tests are expected to return true
            string[] words = {"Alphabet", "Zebra", "ABC", "Αθήνα", "Москва"};

            foreach (var word in words)
            {
                bool result = word.StartsWithUpper();
                Assert.IsTrue(result,
                    String.Format("Expected for '{0}': true; Actual: {1}",word, result));
            }
        }

        [TestMethod]
        public void TestDoesNotStartWithUpper()
        {
            string[] words = { "alphabet", "zebra", "abc", "αυτοκινητοβιομηχανία", "государство", "1234", ".", ";", " " };

            foreach (var word in words)
            {
                bool result = word.StartsWithUpper();
                Assert.IsFalse(result,String.Format("Expected for '{0}': false; Actual: {1}",word, result));
            }

        }

        [TestMethod]
        public void DirectCallWithNullOrEmpty()
        {
            string[] words = {string.Empty, null};

            foreach (var word in words)
            {
                bool result = word.StartsWithUpper();
                Assert.IsFalse(result, String.Format("Expected for '{0}': false; Actual: {1}",word == null ? "<null>" : word, result));

            }


        }
    }
}
