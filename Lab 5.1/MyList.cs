using System.Collections;
using System.Collections.Generic;

namespace Lab_5_1 
{
    class MyList<T>
    {
        private T[] myList;

        public T this[int index]
        {
            get { return myList[index]; }
            set { myList[index] = value; }
        }

        public MyList()
        {
            this.myList = new T[1];
        }

        public MyList(int count)
        {
            this.myList = new T[count];
        }

        public void Add(T item)
        {
            T[] extendedList = new T[myList.Length + 1];
            extendedList[extendedList.Length - 1] = item;
            myList = extendedList;
        }

        public int Capacity
        {
            get { return myList.Length; }

        }

        public int Count
        {
            get { return myList.Length; }
        }
    }
}
