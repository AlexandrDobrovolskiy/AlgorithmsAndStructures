using System;
using System.Net;

namespace AlgorithmsAndStructures
 {
     class Program
     {
         static void Main(string[] args)
         {
             int[] test = new[] {1, 2, 3, 4, 4, 5, 13, 31, 34, 54, 77};
             Console.WriteLine("Binary Search: ");
               Console.WriteLine(Algorithms<int>.BinarySearch(test,3) == 2 ? "Passed" : "Failed");
  
               string text = "Hello darkness, my old friend, I've come to talk with you again.";
               string subString = "darkness";
               int expectedIndex = 5;
               Console.WriteLine("\n Direct Search: ");
               Console.WriteLine(StringAlgorithms.DirectSearch(text, subString) == expectedIndex ? "Passed" : "Failed");
               Console.WriteLine("\n KMP Search: ");
               Console.WriteLine(StringAlgorithms.KMPSearch(text, subString) == expectedIndex ? "Passed" : "Failed" );
           }
       }
   }