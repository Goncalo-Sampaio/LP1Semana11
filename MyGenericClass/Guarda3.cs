using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyGenericClass
{
    public class Guarda3 <T>
    {
        private T var1;
        private T var2;
        private T var3;
        public Guarda3 (){
            var1 = default;
            var2 = default;
            var3 = default;
        }

        public T GetItem(int i){
            if (i == 0) return var1;
            else if (i == 1) return var2;
            else if (i == 2) return var3;
            else throw new IndexOutOfRangeException();
        }

        public void SetItem(int i , T item){
            if (i == 0) var1 = item;
            else if (i == 1) var2 = item;
            else if (i == 2) var3 = item;
            else throw new IndexOutOfRangeException();
        }
    }
}