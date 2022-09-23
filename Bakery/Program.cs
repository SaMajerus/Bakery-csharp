using System;
//using System.Collections.Generic;
using Bakery;

/*     Console-UI Logic     */ 
namespace Bakery
{
  public class Program
  {
    public static void Main()
    {
      int qtyBread = 0; 
      int qtyPastry = 0; 

      Console.WriteLine("Welcome to our Bakery!"); 
      Console.WriteLine("Baseline Prices:  ");
      Console.WriteLine("1 Loaf of Bread - $5");
      Console.Write("1 Pastry - $2 \n\n");
      Console.WriteLine("'Buy 2, Get 1 Free' Deals!--  "); 
      Console.WriteLine("Buy 2 Loaves of Bread, Get 1 Free! - $10"); 
      Console.Write("Buy 2 Pastries, Get 1 Free! - $5 \n\n\n"); 

      Console.WriteLine("How many Loaves of Bread do you want?");
      qtyBread = int.Parse(Console.ReadLine());
      Console.WriteLine("Okay... and how many Pastries?");
      qtyPastry = int.Parse(Console.ReadLine()); 
      Console.WriteLine("\n"); 
      Console.WriteLine("Alright! Thank you for your purchase!");
      
      Bread breadOrder = new Bread(qtyBread); 
      Pastry pastryOrder = new Pastry(qtyPastry); 
      int breadTotalPrice = breadOrder.DetermineTotalPrice();
      int pastryTotalPrice = breadOrder.DetermineTotalPrice();

      Console.WriteLine("Your Receipt-- ");
      if(qtyBread==1){
        Console.WriteLine(qtyBread + "Bread Loaf =  $" + breadTotalPrice);  
      } else {
        Console.WriteLine(qtyBread + "Bread Loaves =  $" + breadTotalPrice);
      }

      if(qtyPastry==1){
        Console.WriteLine(qtyPastry + "Pastry =  $" + pastryTotalPrice);  
      } else { 
        Console.WriteLine(qtyPastry + "Pastries =  $" + pastryTotalPrice);
      } 
      Console.WriteLine("Grand Total:  $" + (breadTotalPrice + pastryTotalPrice));
      Console.Write("\n\nGood Day!");
    }
  }
}