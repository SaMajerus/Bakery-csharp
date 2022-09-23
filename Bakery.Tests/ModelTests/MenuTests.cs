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

    // [TestMethod]
    // public void DealApplies_CheckCompatabilityWithPastryDeal_False()
    // {
    //   BreadOrder test = new BreadOrder(3);
    //   Assert.AreEqual(true, test.DealApplies());
    // }

  }
}