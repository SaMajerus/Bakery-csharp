using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery;

namespace Bakery.Tests
{
  [TestClass]
  public class MenuTests
  {
    //Bread class tests
    [TestMethod]
    public void DealApplies_CheckCompatabilityWithBreadDeal_False()
    {
      Bread test = new Bread(2);
      Assert.AreEqual(false, test.DealApplies());
    }

    [TestMethod]
    public void DealApplies_UseBranchingToCheckBreadDealCompatability_True()
    {
      Bread test1 = new Bread(1);
      Bread test2 = new Bread(2);
      Bread test3 = new Bread(3);
      Assert.AreEqual(false, test1.DealApplies());
      Assert.AreEqual(false, test2.DealApplies());
      Assert.AreEqual(true, test3.DealApplies());
    }

    [TestMethod]
    public void DetermineTotalPrice_UseBranchingToMakeCalculationsBasedOnQuantity_True()
    { 
      Bread test1 = new Bread(1); 
      Bread test2 = new Bread(2); 
      Bread test3 = new Bread(3); 
      Bread test4 = new Bread(4);
      Bread test5 = new Bread(8); 
      Assert.AreEqual(false, test1.DetermineTotalPrice()); 
      Assert.AreEqual(false, test2.DetermineTotalPrice()); 
      Assert.AreEqual(true, test3.DetermineTotalPrice()); 
      Assert.AreEqual(true, test4.DetermineTotalPrice()); 
      Assert.AreEqual(true, test5.DetermineTotalPrice()); 
    } 

    // [TestMethod]
    // public void DealApplies_CheckCompatabilityWithPastryDeal_False()
    // {
    //   BreadOrder test = new BreadOrder(3);
    //   Assert.AreEqual(true, test.DealApplies());
    // }

  }
}