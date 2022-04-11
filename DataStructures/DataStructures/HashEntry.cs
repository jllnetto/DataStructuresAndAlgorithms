using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresAndAlgorithms.DataStructures
{
    /// <summary>
    /// Basic node for HasTable
    /// </summary>
    /// <typeparam name="T">Type of the HashEntry</typeparam>
    public class HashEntry<T>
    {
        /// <summary>
        /// Identification key
        /// </summary>
        public string Key { get; set; }

        /// <summary>
        /// Data
        /// </summary>
        public T Value { get; set; }

        /// <summary>
        /// Next HashEntry
        /// </summary>
        public HashEntry<T> Next { get; set; }

        /// <summary>
        /// Constructor to set the basic values 
        /// </summary>
        /// <param name="key">Identification key value</param>
        /// <param name="value">Data Value</param>
        public HashEntry(string key, T value)
        {
            Key = key;
            Value = value;
            Next = null;
        }

    }
}
