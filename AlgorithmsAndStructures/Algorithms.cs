using System;

namespace AlgorithmsAndStructures
{
    public static class Algorithms<T> where T : IComparable
    {
        #region Search

        public static int SimpleSeaarch( T[] array, T element)
        {
            for (int index = 0; index < array.Length; index++)
            {
                if (array[index].Equals(element))
                    return index;
            }

            return -1;
        }
        
        public static int BinarySearch( T[] sortedArray, T element ){
            int mid = sortedArray.Length / 2;
            int lo = 0;
            int hi = sortedArray.Length;
            T currentElement = sortedArray[mid];
            int counter = 0;

            while(!currentElement.Equals(element)){
                
                if(currentElement.CompareTo(element) < 0){
                    lo = mid;
                    mid = (hi + lo) / 2;
                }else if(currentElement.CompareTo(element) > 0)
                {
                    hi = mid;
                    mid = (hi + lo) / 2;
                }

                if (counter > Math.Log(sortedArray.Length))
                    return -1;
                
                currentElement = sortedArray[mid];
                counter++;
            }
            return mid;
        }

        #endregion
        
        
    }
}