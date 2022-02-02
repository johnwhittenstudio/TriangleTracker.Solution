using Microsoft.VisualStudio.TestTools.UnitTesting;
using TriangleTracker;

namespace TriangleTracker.Tests
{
  [TestClass]
  public class TriangleTests
  {
    [TestMethod]
    public void IsTriangle_True()
    {
      Triangle testTriangle = new Triangle();
      Assert.AreEqual(true, testTriangle.IsTriangle(4, 4, 5));
    }
    [TestMethod]
    public void IsTriangle_False()
    {
      Triangle testTriangle = new Triangle();
      Assert.AreEqual(false, testTriangle.IsTriangle(3, 9, 22));
    }
    // [TestMethod]
    // public void IsTriangle_False()
    // {
    //   Triangle testTriangle = new Triangle();
    //   Assert.AreEqual(false, testTriangle.IsTriangle(2, 4, 6));
    // }
  }
}