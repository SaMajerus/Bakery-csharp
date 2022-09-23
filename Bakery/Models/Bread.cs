using System;

/*     Business Logic ('Bread')     */ 
namespace Bakery
{ 
  /*
  Pricing Deals--
    Bread:  'Buy 2, get 1 free (every 3rd loaf of bread is free.).'  [A single loaf costs $5, two loaves costs $10, and three loaves cost $10.]
    Pastry:  'Buy 1 for $2 or 3 for $5.'  [Four pastries costs $7, five pastries costs $9, and six pastries costs $10.]
  */

  public class Bread{
    public int Quantity {get; set;} 
    public int BreadPrice {get; set;}

    public Bread(int quantity){
      Quantity = quantity; 
      BreadPrice = 5;  //Price IFF (if and only if) Quantity=1.
    }

    public bool DealApplies(){
      int q = Quantity; 
      int bp = BreadPrice; 
      return false;
    }
    
  }

}
