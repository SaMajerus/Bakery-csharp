using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery;

namespace Bakery.Tests
{
  [TestClass]
  public class PastryTests
  { 
    [TestMethod]
    public void DealApplies_CheckCompatabilityWithPastryDeal_False()
    {
      Pastry test = new Pastry(2); 
      Assert.AreEqual(false, test.DealApplies()); 
    }


    [TestMethod]
    public void DealApplies_UseBranchingToCheckPastryDealCompatability_True()
    {
      Pastry test2 = new Pastry(3);
      Assert.AreEqual(true, test2.DealApplies()); 
    }


/*
    [TestMethod]
    public void DetermineTotalPrice_UseBranchingToMakeCalculationsBasedOnQuantity_True()
    { 
      Pastry test1 = new Pastry(1); 
      Pastry test2 = new Pastry(2); 
      Pastry test3 = new Pastry(3); 
      Pastry test4 = new Pastry(4);
      Pastry test5 = new Pastry(8); 
      Assert.AreEqual(5, test1.DetermineTotalPrice()); 
      Assert.AreEqual(10, test2.DetermineTotalPrice()); 
      Assert.AreEqual(10, test3.DetermineTotalPrice()); 
      Assert.AreEqual(15, test4.DetermineTotalPrice()); 
      Assert.AreEqual(30, test5.DetermineTotalPrice()); 
    }
*/
  }
}