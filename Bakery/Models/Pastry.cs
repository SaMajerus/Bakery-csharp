using System;

/*     Business Logic ('Pastry')     */ 
namespace Bakery
{ 
  /*
  Pricing Deals--
    Bread:  'Buy 2, get 1 free (every 3rd loaf of bread is free.).'  [A single loaf costs $5, two loaves costs $10, and three loaves cost $10.]
    Pastry:  'Buy 1 for $2 or 3 for $5.'  [Four pastries costs $7, five pastries costs $9, and six pastries costs $10.]
  */

  public class Pastry{
    public int Quantity {get; set;} 
    public int PastryPrice {get; set;}

    public PastryOrder(int quantity){
      Quantity = quantity; 
      PastryPrice = 2;  //Price IFF (if and only if) Quantity=1.
    }

    public bool DealApplies(){ 
      int q = Quantity; 
      int pp = PastryPrice; 
      return false;
    }
    
  } 

}
