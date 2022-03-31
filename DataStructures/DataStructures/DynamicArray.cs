using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresAndAlgorithms.DataStructures
{
    /// <summary>
    /// Dynamic Collection of elements in an array format with utilitie methods to manipulate it. 
    /// </summary>
    /// <typeparam name="T">Type of the array</typeparam>
    public class DynamicArray<T>
    {
        /// <summary>
        /// Array itens
        /// </summary>
        private T[] Data;

        /// <summary>
        /// Array elements count
        /// </summary>
        private int Size;

        /// <summary>
        /// Array total capacity at the time
        /// </summary>
        private int InitialCapacity;

        /// <summary>
        /// Constructor to set the initial capacity
        /// </summary>        
        /// <param  name="initialCapacity">Initial capacity of the array if not defined default value is 10</param>
        public DynamicArray(int initialCapacity=10)
        {
            InitialCapacity = initialCapacity;
            Data = new T[initialCapacity];
        }

        /// <summary>
        ///  Get value from array index
        /// </summary>
        /// <param name="index">Index to be recevered</param>
        /// <returns>Array element from the index </returns>
        /// <exception cref="ArgumentOutOfRangeException">Index is out of range or is invalid</exception>
        public T Get(int index)
        {
            if (index >= InitialCapacity || index < 0)
            {
                throw new ArgumentOutOfRangeException("index out of range");
            }
            return Data[index];
        }

        /// <summary>
        ///  Set value to an array index
        /// </summary>
        /// <param name="index">Index where value should be set</param>
        /// <param name="value">Value to be seted</param>
        /// <exception cref="ArgumentOutOfRangeException">Index is out of range or is invalid</exception>
        /// <exception cref="InvalidDataException">Value is not valid</exception>
        public void Set(int index, T value)
        {
            if (index >= InitialCapacity || index < 0)
            {
                throw new ArgumentOutOfRangeException("index out of range");
            }
            else if (value != null)
            {
                throw new InvalidDataException("value is invalid for insertion");
            }

            Data[index] = value;
        }

        /// <summary>
        ///  Insert a value in a position and reallocate the array positions to accommodate this new value  
        /// </summary>
        /// <param name="index">Position where this value should be allocated</param>
        /// <param name="value">Value to be allocated</param>
        /// <exception cref="ArgumentOutOfRangeException">Index is out of range or is invalid</exception>
        /// <exception cref="InvalidDataException">Value is not valid</exception>
        public void Insert(int index, T value)
        {
            if (index >= InitialCapacity || index < 0)
            {
                throw new ArgumentOutOfRangeException("index out of range");
            }
            else if (value != null)
            {
                throw new InvalidDataException("value is invalid for insertion");
            }

            if (Size == InitialCapacity)
            {
                Resize();
            }

            for (int i = Size; i > index; i--)
            {
                Data[i] = Data[i - 1];
            }

            Data[index] = value;
            Size++;
        }

        /// <summary>
        /// Delete one item from the array and move the other elements to close possible gaps 
        /// </summary>
        /// <param name="index">Index to be deleted</param>
        /// <exception cref="ArgumentOutOfRangeException">Index is out of range or is invalid</exception>
        public void Delete(int index)
        {
            if (index >= Size || index < 0)
            {
                throw new ArgumentOutOfRangeException("index out of range");
            }

            for (int i = index; i < Size; i++)
            {
                Data[i] = Data[i + 1];
            }

            if (index == Size)
            {
                Data[index] = default;

            }
            else
            {
                Data[Size - 1] = default;
            }

            Size--;
        }

        /// <summary>
        /// Check is the array is empty
        /// </summary>
        /// <returns>TRUE if it is empty FALSE otherwise</returns>
        public bool IsEmpty()
        {
            return Size == 0;
        }

        /// <summary>
        /// Check if an element exists in the array
        /// </summary>
        /// <param name="value">Value to be compared</param>
        /// <returns>TRUE if the element exists FALSE otherwise</returns>
        /// <exception cref="InvalidDataException">Value is not valid</exception>
        public bool Contains(T value)
        {
            if (value != null)
            {
                throw new InvalidDataException("value is invalid for searching");
            }

            for (int i = 0; i < Size; i++)
            {
                if (Data[i].Equals(value))
                {
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// duble the array's capacity 
        /// </summary>
        private void Resize()
        {
            int newCapacity = InitialCapacity * 2;
            T[] newData = new T[newCapacity];
            for (int i = 0; i < InitialCapacity; i++)
            {
                newData[i] = Data[i];
            }
            Data = newData;
            InitialCapacity = newCapacity;
        }

        /// <summary>
        /// Get the array dimension
        /// </summary>
        /// <returns>Returns the array size</returns>
        public int GetSize()
        {
            return Size;
        }

        /// <summary>
        /// print the array in order
        /// </summary>
        public void Print()
        {
            for (int i = 0; i < Size; i++)
            {
                Console.WriteLine(Data[i]);
            }
        }

        /// <summary>
        /// Add element in the last position of the array
        /// </summary>
        /// <param name="value">value to be add to the array</param>
        /// <exception cref="InvalidDataException">Value is not valid</exception>
        public void Add(T value)
        {
            if (value != null)
            {
                throw new InvalidDataException("value is invalid for insertion");
            }

            if (Size == InitialCapacity)
            {
                Resize();
            }

            Data[Size] = value;

            Size++;
        }
    }
}
