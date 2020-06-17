using System;

class MainClass {
  public static void Main (string[] args) {
        /* Read the name of the item?
    Read the quantity of the item?
    Read the unit price of the item?
    Multiply the quanitity of the item by the unit price of the item*/

    Console.WriteLine("What is the item's name?");
    var e = Console.ReadLine();

    Console.WriteLine("Enter the quantity of the item?");
    var y = Console.ReadLine();

    Console.WriteLine("What is the unit price?");
    var x = Console.ReadLine();

    int y1 = Convert.ToInt32(y);

    int x1 = Convert.ToInt32(x);

    Console.WriteLine ("The total price of " + (e) + " is $" + (y1*x1));
  }
}