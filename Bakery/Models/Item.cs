using System; 

namespace Bakery{
  public abstract class Item {
    public int Quantity{ get; set; }
    public int BasePrice { get; set; }   //$5 for 1 Bread, $2 for 1 Pastry.
    
    public Item(int quantity, int price){
      Quantity = quantity; 
      BasePrice = price;
    }

    public bool DealApplies(){ 
      if(Quantity >= 3){
        return true;
      } else {
        return false;
      }
    }

    public abstract int DetermineTotalPrice();

  }

}