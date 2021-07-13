
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TriangleTracker;


namespace TriangleTracker.Tests
{
  [TestClass]
  public class TriangleTests
  { 
  [TestMethod]
public void CheckTri_ChecksTypeOfTriangle_Isoceles()
{
  Triangle testTriangle = new Triangle(3,3,5);
  Assert.AreEqual("Isosceles", testTriangle.CheckTri());
}


}
}
