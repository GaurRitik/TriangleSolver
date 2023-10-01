using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TriangleSolver;
using NUnit.Framework;

namespace TestClass
{
    public class Class1
    {
        [TestFixture]
        public class ValidEquilateralTest
        {
            [Test]
            public void AnalyzeTriangle_Input9and9and9_OutputEquilateralTriangle()
            {
                //Arrange
                int firstSide = 9;
                int secondSide = 9;
                int thirdSide = 9;

                string expected = "Equilateral triangle";

                //Act
                string actual = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

                //Assert
                Assert.AreEqual(expected, actual);
            }
        }
         public class ValidIsoscelesTriangleTest
 {
     [Test]
     public void AnalyzeTriangle_Input9and9and7_OutputIsoscelestriangle()
     {
         //Arrange
         int firstSide = 9;
         int secondSide = 9;
         int thirdSide = 7;

         string expected = "Isosceles triangle";

         //Act
         string actual = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

         //Assert
         Assert.AreEqual(expected, actual);
     }

     [Test]
     public void AnalyzeTriangle_Input9and7and9_OutputIsoscelestriangle()
     {
         //Arrange
         int firstSide= 9;
         int secondSide= 7;
         int thirdSide= 9;

         string expected = "Isosceles triangle";

         //Act
         string actual = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

         //Assert
         Assert.AreEqual(expected, actual);
     }

     [Test]
     public void AnalyzeTriangle_Input7and9and9_OutputIsoscelestriangle()
     {

         //Arrange
         int firstSide = 7;
         int secondSide = 9;
         int thirdSide = 9;

         string expected = "Isosceles triangle";

         //Act
         string actual = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

         //Assert
         Assert.AreEqual(expected, actual);
     }
 }
    }
}
