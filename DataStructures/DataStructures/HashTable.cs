using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresAndAlgorithms.DataStructures
{
    /// <summary>
    /// Collection of elements in a Hastable format with utilitie methods to manipulate it.
    /// </summary>
    /// <typeparam name="T">Type of the Hastable</typeparam>
    public class HashTable<T>
    {
        /// <summary>
        /// Inital size of the array
        /// </summary>
        private int InitialSize { get; set; }

        /// <summary>
        /// Array with of HasEntrys that contain the data
        /// </summary>
        private HashEntry<T>[] Data { get; set; }

        /// <summary>
        /// Constructor to set the initial capacity
        /// </summary>
        /// <param name="initialSize">Initial capacity of the array if not defined default value is 20</param>
        /// <exception cref="ArgumentException">Initial size must be positive and more than zero</exception>
        public HashTable(int initialSize=20)
        {
            if(initialSize <=0 )
            {
                throw new ArgumentException("Initial size must be larger than Zero");
            }

            Data= new HashEntry<T>[initialSize];
            InitialSize = initialSize;
        }

        /// <summary>
        /// Incert an value and link it to a key
        /// </summary>
        /// <param name="key">Key to link the value</param>
        /// <param name="value">Value to be incerted</param>
        /// <exception cref="ArgumentNullException">Error is any of the values are null or empty</exception>
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

        /// <summary>
        /// Recover register based on a key
        /// </summary>
        /// <param name="key">Key from the object that you want to recover</param>
        /// <returns>Value of the HashEntry that has the informed key or null if that key dosen't exist</returns>
        /// <exception cref="ArgumentNullException">If the Key is null or empty</exception>
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

        /// <summary>
        ///  Get the index based on the key of a register
        /// </summary>
        /// <param name="key">Key value to get the index of a register</param>
        /// <returns>int Value that is the index for a register key</returns>
        private int GetIndex(string key)
        {
            int hasCode = key.GetHashCode();
            int index = (hasCode & 0x7fffffff) % InitialSize;
            return index;
        }
    }
}
