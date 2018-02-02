using System;

namespace AlgorithmsAndStructures
{
    public static class TestForSingleLinkedList
    {
        private static MySingeLinkedList<int> _simpleType = new MySingeLinkedList<int>(){1,2,3,4,5,6,7,8,9,10};
        private static MySingeLinkedList<IComparable> _objects = new MySingeLinkedList<IComparable>()
        {
            new Box(1,2),
            new Box(3,4),
            new Box(5,6),
            new Box(6,7),
            new Box(7,8)
        };


        public static void Run()
        {
            AddTest();
        }

        public static void AddTest()
        {
            bool passed = false;
            Box smalBox = new Box(1,1);
            Box bigBox = new Box(10,10);
            
            _simpleType.Add(11);
            _simpleType.AddFirst(0);
            _simpleType.Remove(3);
            passed = !_simpleType.Contains(3) 
                         && _simpleType.Count == 11 
                         && _simpleType.First.Value == 0
                         && _simpleType.Last.Value == 11;
            
            _objects.Add(bigBox);
            _objects.AddFirst(smalBox);
            _objects.Remove(smalBox);
            passed = !_objects.Contains(smalBox)
                     && _objects.Count == 6
                     && _objects.Last.Value == bigBox;

            Console.WriteLine(passed ? "Add test Passed" : "Add test Failed");
        }
    }
}