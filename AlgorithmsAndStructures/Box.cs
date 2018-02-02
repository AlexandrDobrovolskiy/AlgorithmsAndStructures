using System;

namespace AlgorithmsAndStructures
{
    public class Box : IComparable
    {
        private int height;
        private int width;
        private int capacity;

        public Box(int height, int width)
        {
            this.height = height;
            this.width = width;
            this.capacity = height * width;
        }

        
        public int CompareTo(object obj)
        {
            Box otherBox = obj as Box;
            return (int) (this.capacity - otherBox.capacity);
        }
    }
}