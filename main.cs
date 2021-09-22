using System;

class Program {
  public static void Main (string[] args) {
    int counter=1;
    while(counter < 7)
    {
      Console.Write("Enter Distance Covered By Car ");
      Console.WriteLine(counter);
      int distance = Convert.ToInt32(Console.ReadLine());

      Console.Write("Enter Time Taken By Car ");
      Console.WriteLine(counter);
      int time = Convert.ToInt32(Console.ReadLine());
      counter++;
    }
  }
}