using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericDemo
{
    internal class GenericList<AnyType> : IEnumerable<AnyType>
    {
        AnyType[] collection = new AnyType[2];
        public int Count { get; private set; }

        internal void Add(AnyType item)
        {
            if (Count == collection.Length)
            {
                AnyType[] temp = new AnyType[collection.Length * 2];
                Array.Copy(collection, temp, collection.Length);
                collection = temp;
            }
            collection[Count++] = item;
        }

        public IEnumerator<AnyType> GetEnumerator()
        {
            for (int i = 0; i < Count; i++)
            {
                yield return collection[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            for (int i = 0; i < Count; i++)
            {
                yield return collection[i];
            }
        }

        public AnyType this[int index] //Snippet: Indexer
        {
            get
            {
                if (index < 0 || index > Count - 1)
                    throw new IndexOutOfRangeException();

                return collection[index];
            }
            set
            {
                if (index < 0 || index > Count - 1)
                    throw new IndexOutOfRangeException();
                collection[index] = value;
            }
        }

        public void Sort(Func<AnyType, AnyType, bool> isLessThan)
        {
            for (int i = 0; i < Count - 1; i++)
            {
                int indexOfMinValue = i;

                for (int j = i + 1; j < Count; j++)
                {
                    if (isLessThan(collection[j], collection[indexOfMinValue]))
                        indexOfMinValue = j;
                }

                if (indexOfMinValue != i)
                {
                    AnyType temp = collection[i];
                    collection[i] = collection[indexOfMinValue];
                    collection[indexOfMinValue] = temp;
                }
            }
        }
    }
}
