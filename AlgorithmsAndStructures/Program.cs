using System;
using System.Collections.Generic;
using System.Net;

namespace AlgorithmsAndStructures
 {
     class Program
     {
         static void Main(string[] args)
         {

             MySingeLinkedList<int> mll = new MySingeLinkedList<int>(new[] {1,2,3,4});

             mll.Remove(3);
             Console.WriteLine(mll.First);
             Console.WriteLine(mll.Contains(3));
             
             
             //might fall here while I'll implement IEnumerable
             foreach (int item in mll)
             {
                 Console.WriteLine(item);
             }
             
             int[] BSarray1 = new[] {1, 2, 3, 4, 4, 5, 13, 31, 34, 54, 77};
             string[] BSarray2 = new[] {"a", "b", "c", "d", "e", "f"};
             int BSToFind1 = 3;
             string BSToFind2 = "c";
             int BSExpected = 2;
             Console.WriteLine(" Binary Search: ");
             Console.WriteLine(Algorithms<int>.BinarySearch(BSarray1, BSToFind1) == BSExpected ? "Passed" : "Failed");
             Console.WriteLine(Algorithms<string>.BinarySearch(BSarray2, BSToFind2) == BSExpected ? "Passed" : "Failed");
  
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