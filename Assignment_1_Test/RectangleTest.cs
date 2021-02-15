using NUnit.Framework;
using Assignment_1;

namespace Assignment_1_Test
{
    public class RectangleTest
    {
        Rectangle rect;

        [SetUp]
        public void Setup()
        {
            rect = new Rectangle();
        }

        [Test]
        // Test #1.1
        // Test Description: Get length
        // Method of Execution: Automated
        // Input: 
        // Expected Output: 1
        public void TestGetLength_result1()
        {
            //Arrange
            int expectedLength = 1;

            //Act
            double result = rect.GetLength();

            //Assert
            Assert.AreEqual(expectedLength, result, 1);
        }

        [Test]
        // Test #1.2
        // Test Description: Get length
        // Method of Execution: Automated
        // Input: 
        // Expected Output: 10
        public void TestGetLength_result10()
        {
            //Arrange
            int expectedLength = 10;

            //Act
            double result = rect.GetLength();

            //Assert
            Assert.AreEqual(expectedLength, result, 1);
        }

        [TestCase(10)]
        // Test #2.1
        // Test Description: Set Length
        // Method of Execution: Automated
        // Input: 10
        // Expected Output: 10
        public void TestSetLength_input10(int l)
        {
            //Arrange
            int length = l;

            //Act
            rect.SetLength(length);
            int result = rect.GetLength();

            //Assert
            Assert.AreEqual(10, result, 1);
        }

        [TestCase(9999)]
        // Test #2.2
        // Test Description: Set Length
        // Method of Execution: Automated
        // Input: 9999
        // Expected Output: 9999
        public void TestSetLength_input9999(int l)
        {
            //Arrange
            int length = l;

            //Act
            rect.SetLength(length);
            int result = rect.GetLength();

            //Assert
            Assert.AreEqual(9999, result, 1);
        }

        [Test]
        // Test #3.1
        // Test Description: Get width
        // Method of Execution: Automated
        // Input: 
        // Expected Output: 1
        public void TestGetWidth_result1()
        {
            //Arrange
            int expectedWidth = 1;

            //Act
            double result = rect.GetWidth();

            //Assert
            Assert.AreEqual(expectedWidth, result, 1);
        }

        [Test]
        // Test #3.2
        // Test Description: Get width
        // Method of Execution: Automated
        // Input: 
        // Expected Output: 10
        public void TestGetWidth_result10()
        {
            //Arrange
            int expectedWidth = 10;

            //Act
            double result = rect.GetWidth();

            //Assert
            Assert.AreEqual(expectedWidth, result, 1);
        }

        [TestCase(10)]
        // Test #4.1
        // Test Description: Set Width
        // Method of Execution: Automated
        // Input: 10
        // Expected Output: 10
        public void TestSetWidth_input10(int w)
        {
            //Arrange
            int width = w;

            //Act
            rect.SetWidth(width);
            int result = rect.GetWidth();

            //Assert
            Assert.AreEqual(10, result, 1);
        }

        [TestCase(9999)]
        // Test #4.2
        // Test Description: Set Width
        // Method of Execution: Automated
        // Input: 9999
        // Expected Output: 9999
        public void TestSetWidth_input9999(int w)
        {
            //Arrange
            int width = w;

            //Act
            rect.SetWidth(width);
            int result = rect.GetWidth();

            //Assert
            Assert.AreEqual(9999, result, 1);
        }

        [Test]
        // Test #5.1
        // Test Description: Get Perimeter
        // Method of Execution: Automated
        // Input: length=20, width=30
        // Expected Output: 100
        public void TestGetPerimeter_input20And30_result100()
        {
            //Arrange
            rect.SetLength(20);
            rect.SetWidth(30);
            int expectedPerimeter = 100;

            //Act
            double result = rect.GetPerimeter();

            //Assert
            Assert.AreEqual(expectedPerimeter, result, 1);
        }

        [Test]
        // Test #5.2
        // Test Description: Get Perimeter
        // Method of Execution: Automated
        // Input: length=9999, width=9999
        // Expected Output: 39996
        public void TestGetPerimeter_input9999And9999_result39996()
        {
            //Arrange
            rect.SetLength(9999);
            rect.SetWidth(9999);
            int expectedPerimeter = 39996;

            //Act
            double result = rect.GetPerimeter();

            //Assert
            Assert.AreEqual(expectedPerimeter, result, 1);
        }

        [Test]
        // Test #6.1
        // Test Description: Get Area
        // Method of Execution: Automated
        // Input: length=20, width=30
        // Expected Output: 600
        public void TestGetArea_input20And30_result600()
        {
            //Arrange
            rect.SetLength(20);
            rect.SetWidth(30);
            int expectedArea = 600;

            //Act
            double result = rect.GetArea();

            //Assert
            Assert.AreEqual(expectedArea, result, 1);
        }

        [Test]
        // Test #6.2
        // Test Description: Get Area
        // Method of Execution: Automated
        // Input: length=9999, width=9999
        // Expected Output: 99980001
        public void TestGetArea_input9999And9999_result99980001()
        {
            //Arrange
            rect.SetLength(9999);
            rect.SetWidth(9999);
            int expectedArea = 99980001;

            //Act
            double result = rect.GetArea();

            //Assert
            Assert.AreEqual(expectedArea, result, 1);
        }
    }
}