using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresAndAlgorithms.DataStructures
{
    public class HashTable<T>
    {
        private int InitialSize { get; set; }
        private HashEntry<T>[] Data { get; set; }

        public HashTable(int initialSize=20)
        {
            if(initialSize <=0 )
            {
                throw new ArgumentException("Initial size must be larger than Zero");
            }

            Data= new HashEntry<T>[initialSize];
            InitialSize = initialSize;
        }

        public void Put(string key,T value)
        {
            if (value == null)
            {
                throw new ArgumentNullException("Value is invalid for inclusion");
            }
            else if(string.IsNullOrEmpty(key))
            {
                throw new ArgumentNullException("Key is invalid for inclusion");
            }

            int index = GetIndex(key);

            HashEntry<T> entry = new HashEntry<T>(key, value);

            if(Data[index]==null)
            {
                Data[index]=entry;
            }
            else
            {
                HashEntry<T> entries = Data[index];

                while(entries.Next !=null)
                {
                    entries = entries.Next;
                }
                entries.Next = entry;

            }
        }
        public T Get (string key)
        {
            if (string.IsNullOrEmpty(key))
            {
                throw new ArgumentNullException("Key is invalid for searches");
            }
            int index = GetIndex(key);

            HashEntry<T> entries = Data[index];
            
            if(entries != null)
            {
                while(! entries.Key.Equals(key) && entries.Next !=null)
                {
                    entries = entries.Next;
                }
                return entries.Value;
            }
            return default;

        }
        private int GetIndex(string key)
        {
            int hasCode = key.GetHashCode();
            int index = (hasCode & 0x7fffffff) % InitialSize;
            return index;
        }
    }
}
