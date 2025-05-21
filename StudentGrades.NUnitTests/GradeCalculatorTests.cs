using NUnit.Framework;

namespace StudentGrades.NUnitTests
{
    public class GradeCalculatorTests
    {
        private GradeCalculator _calculator { get; set; } = null!;

        [SetUp]
        public void Setup()
        {
            _calculator = new GradeCalculator();
        }

        /*

        [Test]
        public void GetGradeByPercentage_EqualTest()
        {
            //Assign
            var percentage = 99;
            //Act
            var grade = _calculator.GetGradeByPercentage(percentage);   

            //Assert
            Assert.AreEqual("A", grade);
        }

        */

        [TestCase(91)]
        [TestCase(92)]
        [TestCase(97)]
        [TestCase(99)]
        public void GetGradeByPercentage_EqualTest(int percentage)
        { 
            //Act
            var grade = _calculator.GetGradeByPercentage(percentage);

            //Assert
            Assert.AreEqual("A", grade);
        }


        [TestCase(1)]
        [TestCase(45)]
        [TestCase(70)]
        [TestCase(89)]
        public void GetGradeByPercentage_NotEqualTest(int percentage)
        {
            //Act
            var grade = _calculator.GetGradeByPercentage(percentage);

            //Assert
            Assert.AreNotEqual("A", grade);
        }
    }
}