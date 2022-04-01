using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresAndAlgorithms.DataStructures
{
    public class HashEntry<T>
    {
        public string Key { get; set; }
        public T Value { get; set; }

        public HashEntry<T> Next { get; set; }

        public HashEntry(string key, T value)
        {
            Key = key;
            Value = value;
            Next = null;
        }

    }
}
