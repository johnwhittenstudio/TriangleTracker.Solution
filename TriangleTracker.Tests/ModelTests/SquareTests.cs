using Microsoft.VisualStudio.TestTools.UnitTesting;
using TriangleTracker;

namespace TriangleTracker.Tests
{
  [TestClass]
  public class SquareTests
  {
    [TestMethod]
    public void IsSquare_True()
    {
      Square testSquare = new Square();
      Assert.AreEqual(true, testSquare.IsSquare(2, 2, 2, 2));
    }
    [TestMethod]
    public void IsSquare_False()
    {
      Square testSquare = new Square();
      Assert.AreEqual(false, testSquare.IsSquare(4, 3, 4, 3));
    }
  }
}