using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery;

namespace Bakery.Tests
{
  [TestClass]
  public class MenuTests
  {
    [TestMethod]
    public void DealApplies_CheckCompatabilityWithBreadDeal_False()
    {
      Bread test = new Bread(3);
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

    // [TestMethod]
    // public void DealApplies_CheckCompatabilityWithPastryDeal_False()
    // {
    //   BreadOrder test = new BreadOrder(3);
    //   Assert.AreEqual(true, test.DealApplies());
    // }

  }
}