using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HowManyOfThisType
{
    public static class Checker
    {
         public static int HowManyOfType<T>(IEnumerable<object> items){
            int numberOfItems = 0;
            foreach(object item in items){
                if(item is T){
                    numberOfItems++;
                }
            }
            return numberOfItems;
         }
    }
}