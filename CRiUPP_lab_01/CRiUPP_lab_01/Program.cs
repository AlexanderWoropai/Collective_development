using System;
using System.Collections.Generic;

namespace CRiUPP_lab_01
{
  class Program
  {
    static void Main(string[] args)
    {
      System.Collections.Generic.Stack<int> s = new System.Collections.Generic.Stack<int>(new int[] { 1,2,3});


      List<int> list = new List<int>();
      LinkedList<int> llist = new LinkedList<int>();

      //int a = list[1];
      //int b = llist.Last.Value;

      Console.WriteLine(s.Contains(2));
      Console.WriteLine(s.Contains(7));
    }
  }
}
