using System;

namespace DIO 
{
  class HoHoHo 
  {
    static void Main(string[] args) 
    {
      int N = int.Parse(Console.ReadLine());
  
      for (int i = 0; i < N; i++) {
        if (i != N - 1) {
          Console.Write("Ho ");
        } else {
          Console.WriteLine("Ho!");
        }
      }
    }
  }
}