using System;
using System.Reflection;

namespace BootCamp.Chapter1
{
    public static class ArrayOperations
    {
        /// <summary>
        /// Sort the array in ascending order.
        /// If array empty or null- don't do anything.
        /// </summary>
        /// <param name="array">Input array in a random order.</param>
        public static void Sort(int[] array)
        {
            //check if array is null, return if null
            if (array is null)
            {
                return;
            }
            //check if array is empty, return if empty
            if (array.Length == 0)
            {
                return;
            }

            //sort array by values
            Array.Sort(array);
        }

        /// <summary>
        /// Reverse the array elements, first being last and so on.
        /// If array empty or null- don't do anything.
        /// </summary>
        /// <param name="array">Input array in a random order.</param>
        public static void Reverse(int[] array)
        {
            //check if array is null, return if null
            if (array is null)
            {
                return;
            }
            //check if array is empty, return if empty
            if (array.Length == 0)
            {
                return;
            }

            //reverse order of array
            Array.Reverse(array);
        }

        /// <summary>
        /// Remove last element in array.
        /// </summary>
        /// <param name="array">Input array.</param>
        /// <returns>A new array with the last element removed. If an array is empty or null, returns input array.</returns>
        public static int[] RemoveLast(int[] array)
        {
            //check if array is null, return if null
            if (array is null)
            {
                return array;
            }
            //check if array is empty, return if empty
            if (array.Length == 0)
            {
                return array;
            }

            //remove last
            var array2 = new int[array.Length-1];

            for (int i = 0; i< array2.Length; i++)
            {
                array2[i] = array[i];
            }    
            return array2;
        }

        /// <summary>
        /// Remove first element in array.
        /// </summary>
        /// <returns>A new array with the first element removed. If an array is empty or null, returns input array.</returns>
        public static int[] RemoveFirst(int[] array)
        {
            //check if array is null, return if null
            if (array is null)
            {
                return array;
            }
            //check if array is empty, return if empty
            if (array.Length == 0)
            {
                return array;
            }

            //remove first
            var array2 = new int[array.Length - 1];

            for (int i = 0; i < array2.Length; i++)
            {
                array2[i] = array[i+1];
            }
            return array2;
        }

        /// <summary>
        /// Removes array element at given index.
        /// </summary>
        /// <param name="array">Input array.</param>
        /// <param name="index">Index at which array element should be removed.</param>
        /// <returns>A new array with element removed at a given index. If an array is empty or null, returns input array.</returns>
        public static int[] RemoveAt(int[] array, int index)
        {
            //check if array is null, return if null
            if (array is null)
            {
                return array;
            }
            //check if array is empty, return if empty
            if (array.Length == 0)
            {
                return array;
            }
            //check if index is valid for array size
            if (index < 0 || index > array.Length-1)
            {
                return array;
            }
            //remove at index
            var array2 = new int[array.Length - 1];

            for (int i = 0; i < array2.Length; i++)
            {
                if (i >= index)
                {
                    array2[i] = array[i + 1];
                }
                else
                {
                    array2[i] = array[i];
                }
            }
            return array2;
        }

        /// <summary>
        /// Inserts a new array element at the start.
        /// </summary>
        /// <param name="array">Input array.</param>
        /// <param name="number">Number to be added.</param>
        /// <returns>A new array with element added at a given index. If an array is empty or null, returns new array with number in it.</returns>
        public static int[] InsertFirst(int[] array, int number)
        {

            //check if array is null, return if null
            if (array is null)
            {
                var arrayNull = new int[] { number };
                return arrayNull;
            }
           
            //initialize new array
            var array2 = new int[array.Length + 1];
            //add number at start
            array2[0] = number;
            //add rest of array after
            for (int i = 0; i < array2.Length-1; i++)
            {
                
                array2[i+1] = array[i];
            }

            
            return array2;
        }

        /// <summary>
        /// Inserts a new array element at the end.
        /// </summary>
        /// <param name="array">Input array.</param>
        /// <param name="number">Number to be added.</param>
        /// <returns>A new array with element added in the end of array. If an array is empty or null, returns new array with number in it.</returns>
        public static int[] InsertLast(int[] array, int number)
        {
            //check if array is null, return if null
            if (array is null)
            {
                var arrayNull = new int[] { number };
                return arrayNull;
            }
            
            //initialize new array
            var array2 = new int[array.Length + 1];
            //add number at end

            array2[array.Length] = number;
            //add rest of array after
            for (int i = 0; i < array2.Length-1; i++)
            {
                array2[i] = array[i];
            }


            return array2; 
        }

        /// <summary>
        /// Inserts a new array element at the specified index.
        /// </summary>
        /// <param name="array">Input array.</param>
        /// <param name="number">Number to be added.</param>
        /// <param name="index">Index at which array element should be added.</param>
        /// <returns>A new array with element inserted at a given index. If an array is empty or null, returns new array with number in it.</returns>
        public static int[] InsertAt(int[] array, int number, int index)
        {
            //check if array is null, return if null
            if (array is null)
            {
                var arrayNull = new int[] { number };
                return arrayNull;
            }
            //check if array is empty, return if empty
            if (array.Length == 0 && index == 0)
            {
                var array0 = new int[] { number };
                return array0;
            }

            //check if index is valid for array size
            if (index < 0 || index > array.Length)
            {
                return array;
            }
            //initialize new array
            var array2 = new int[array.Length + 1];
            
            bool indexPassed = false;

            //add rest of array after
            for (int i = 0; i < array2.Length; i++)
            {
                if (i == index)
                {
                    array2[i] = number;
                    indexPassed = true;
                    continue;
                }
                if (!indexPassed)
                {
                    array2[i] = array[i];
                }
                if (indexPassed)
                {
                    array2[i] = array[i - 1];
                }
                if (i== index)
                {
                    array2[i] = number;
                    indexPassed = true;
                }
               

               
            }


            return array2;
        }
    }
}
