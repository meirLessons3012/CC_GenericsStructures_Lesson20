using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CC_GenericsStructures_Lesson20
{
    internal class MyEnumerator<T> : IEnumerator<T>
    {
        private List<T> MyList { get; set; }
        private int counter;
        public MyEnumerator(List<T> items)
        {
            MyList = items.Select(item => item).ToList();
        }
        public object Current => MyList[counter];

        T IEnumerator<T>.Current => MyList[counter];

        public bool MoveNext()
        {
            if (counter < MyList.Count-1)
            {
                counter++;
                return true;
            }
            return false;
        }

        public void Reset()
        {
            counter = 0;
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
