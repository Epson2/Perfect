using System;

class Program {
  public static void Main (string[] args) {
    //Console.WriteLine ("write number: ");
    //var x = Convert.ToInt16(Console.ReadLine());
    
    for (int i = 1; i < 10000; i++){
      Console.WriteLine("write number: ");
      var x = Convert.ToInt16(Console.ReadLine());
      if (isPerfect(i = x)){
        Console.WriteLine("is perfect");
      }
      else {
        Console.WriteLine("not perfect");
      }
    }
    
  }

  public static bool isPerfect(int n){
    int sum = 0;
    for(int i = 1; i < n; ++i){
      if(n % i == 0){
        sum += i;
      }
    }
    return sum == n;
  }
}