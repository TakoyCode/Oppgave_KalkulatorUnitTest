using Oppgave_KalkulatorUnitTest.Main;

namespace Oppgave_KalkulatorUnitTest.Test
{
    public class Tests
    {
        [TestCase(1, 5, 6)]
        [TestCase(-5,-6, -11)]
        [TestCase(10,-6, 4)]
        public void TestAddTogether(int number1, int number2, int expSum)
        {
            // arrange
            var calc = new Calculator();

            // act
            var sum = calc.LeggSammen(number1, number2);

            // assert
            Assert.AreEqual(expSum, sum);
        }

        [Test]
        public void TestAddNull()
        {
            // arrange
            var calc = new Calculator();

            // act
            int? sum = calc.LeggSammen(1, null);

            // assert
            Assert.IsNull(sum);
        }

        [TestCase(1, 5, -4)]
        [TestCase(-5, -6, 1)]
        [TestCase(10, -6, 16)]
        public void TestSubtractFrom(int number1, int number2, int expSum)
        {
            // arrange
            var calc = new Calculator();

            // act
            var sum = calc.TrekkFra(number1, number2);

            // assert
            Assert.AreEqual(expSum, sum);
        }

        [Test]
        public void TestSubtractNull()
        {
            // arrange
            var calc = new Calculator();

            // act
            int? sum = calc.TrekkFra(1, null);

            // assert
            Assert.IsNull(sum);
        }

        [TestCase(1, 5, 5)]
        [TestCase(-5, -6, 30)]
        [TestCase(10, -6, -60)]
        public void TestMultiplyTogether(int number1, int number2, int expSum)
        {
            // arrange
            var calc = new Calculator();

            // act
            var sum = calc.Multipliser(number1, number2);

            // assert
            Assert.AreEqual(expSum, sum);
        }

        [Test]
        public void TestMultiplyNull()
        {
            // arrange
            var calc = new Calculator();

            // act
            int? sum1 = calc.Multipliser(1, null);
            int? sum2 = calc.Multipliser(null, 1);
            int? sum3 = calc.Multipliser(null, null);

            // assert
            Assert.IsNull(sum1);
            Assert.IsNull(sum2);
            Assert.IsNull(sum3);
        }

        [TestCase(1, 5, 0.2)]
        [TestCase(10, 5, 2)]
        [TestCase(10, -6, -1.6666666666666667)]
        public void TestDivideTogether(int number1, int number2, double expSum)
        {
            // arrange
            var calc = new Calculator();

            // act
            var sum = calc.Divider(number1, number2);

            // assert
            Assert.AreEqual(expSum, sum);
        }

        [TestCase(5, 0)]
        [TestCase(0, 3)]
        [TestCase(0, 0)]
        public void TestDivideBy0(int number1, int number2)
        {
            // arrange
            var calc = new Calculator();

            // act
            // assert
            Assert.Throws<ArgumentException>(() => calc.Divider(number1, number2));
        }
        [Test]
        public void TestDivideByNull()
        {
            // arrange
            var calc = new Calculator();

            // act
            var result1 = calc.Divider(null, 44);
            var result2 = calc.Divider(53, null);
            var result3 = calc.Divider(null, null);

            // assert
            Assert.IsNull(result1);
            Assert.IsNull(result2);
            Assert.IsNull(result3);
        }
    }
}