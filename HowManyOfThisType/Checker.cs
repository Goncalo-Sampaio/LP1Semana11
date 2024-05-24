using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HowManyOfThisType
{
    /// <summary>
    /// Class used to check if the items are of a certain type
    /// </summary>
    public static class Checker
    {
        //Method that takes an enumerable and checks each element to see
        //if the element is of the provided type
        public static int HowManyOfType<T>(IEnumerable<object> items)
        {
            int numberOfItems = 0;
            foreach (object item in items)
            {
                if (item is T)
                {
                    numberOfItems++;
                }
            }
            return numberOfItems;
        }
    }
}