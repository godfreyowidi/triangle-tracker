
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

[TestMethod]
public void CheckTri_CheckTypeTriangle_Equilateral()
{
  Triangle testTriangle = new Triangle(2, 2, 2);
  Assert.AreEqual("Equilateral", testTriangle.CheckTri());
}
[TestMethod]
public void CheckTri_CheckTypeTriangle_Scalene()
{
  Triangle testTriangle = new Triangle(2, 3, 4);
  Assert.AreEqual("Scalene", testTriangle.CheckTri());
}
}
}
