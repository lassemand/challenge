using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;

namespace StolenTests
{
    [TestClass]
    public class NumberHelper_Should
    {
        // There is an error on the website. On the website you state that as n is 1 the returned value is not a set. 
        // I assume it is a precondition that you can not call FindClosestNumber with an n greater than the size of the list. Otherwise it is unspecified what the behaviour is
        private readonly NumberHelper _sut;

        public NumberHelper_Should()
        {
            _sut = new NumberHelper();
        }
        
        [TestMethod]
        public void Return_Same_Value_When_FindClosestNumbers_Is_Called_With_Needle_Equivalent_To_An_Element_In_Haystack()
        {
            var haystack = new List<int> { 1, 2, 3 };

            var results = _sut.FindClosestNumbers(3, haystack, 1).ToList();

            Assert.Equals(results.ElementAt(0), 3);
        }

        [TestMethod]
        public void Return_Highest_Value_When_FindClosestNumbers_Is_Called_With_Needle_Higher_Than_Highest_Element()
        {
            var haystack = new List<int> { 1, 2, 3 };

            var results = _sut.FindClosestNumbers(4, haystack, 1).ToList();

            Assert.Equals(results.ElementAt(0), 3);
        }
        [TestMethod]
        public void Return_Lowest_Value_When_FindClosestNumbers_Is_Called_With_Needle_Lower_Than_Lowest_Element()
        {
            var haystack = new List<int> { 1, 2, 3 };

            var results = _sut.FindClosestNumbers(-1, haystack, 1).ToList();

            Assert.Equals(results.ElementAt(0), 1);
        }
        [TestMethod]
        public void Return_Lowest_Element_First_When_FindClosestNumbers_Is_Called_With_Needle_In_Between_Elements()
        {
            var haystack = new List<int> { 1, 3, 4 };

            var results = _sut.FindClosestNumbers(0, haystack, 2).ToList();

            Assert.Equals(results.ElementAt(0), 1);
            Assert.Equals(results.ElementAt(1), 3);
        }
        [TestMethod]
        public void Return_Empty_List_When_FindClosestNumbers_Is_Called_When_n_Is_Zero()
        {
            var haystack = new List<int> { 1, 3, 4 };

            var results = _sut.FindClosestNumbers(0, haystack, 0).ToList();

            Assert.Equals(results.Count, 0);
        }
    }
}
