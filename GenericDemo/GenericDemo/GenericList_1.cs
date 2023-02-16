using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericDemo
{
    internal class ListOfStrings : IEnumerable<string>
    {
        string[] collection = new string[2];
        public int Count { get; private set; }

        internal void Add(string item)
        {
            if (Count == collection.Length)
            {
                string[] temp = new string[collection.Length * 2];
                Array.Copy(collection, temp, collection.Length);
                collection = temp;
            }
            collection[Count++] = item;
        }

        public IEnumerator<string> GetEnumerator()
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

        public string this[int index] //Snippet: Indexer
        {
            get 
            { 
                if (index < 0 || index > Count-1)
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

        public void Sort()
        {
            for (int i = 0; i < Count-1; i++)
            {
                int indexOfMinValue = i;

                for (int j = i+1; j < Count; j++)
                {
                    if (string.Compare(collection[j], collection[indexOfMinValue], true) < 0)
                        indexOfMinValue = j;
                }

                if (indexOfMinValue != i)
                {
                    string temp = collection[i];
                    collection[i] = collection[indexOfMinValue];
                    collection[indexOfMinValue] = temp;
                }
            }
        }
    }
}
