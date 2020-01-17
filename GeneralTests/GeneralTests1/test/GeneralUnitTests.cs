using GeneralUnitTests.classes;
using NUnit.Framework;

namespace GeneralUnitTests
{
    public class Tests: OperationSuccessCalculator
    {

        [Test]
        public void TestSuccesfulAttack()
        {
            var calculator = new OperationSuccessCalculator();

            Assert.True(calculator.IsAttackSuccesful(3, 4));
        }

        [Test]
        public void TestAttackWithZeroCoordinates()
        {
            var calculator = new OperationSuccessCalculator();

            Assert.False(calculator.IsAttackSuccesful(0, 0));
        }

        [Test]
        public void TestAttackWithNegativeCoordinates()
        {
            var calculator = new OperationSuccessCalculator();

            Assert.False(calculator.IsAttackSuccesful(-1, -1));
        }

        [Test]
        public void TestAttackWithOutOfBoardCoordinates()
        {
            var calculator = new OperationSuccessCalculator();

            Assert.False(calculator.IsAttackSuccesful(201, 301));
        }

        [Test]
        public void TestSuccesfulDefence()
        {
            var calculator = new OperationSuccessCalculator();

            Assert.True(calculator.IsDefenceSuccesful(3, 3));
        }

        [Test]
        public void TestDefencekWithZeroCoordinates()
        {
            var calculator = new OperationSuccessCalculator();

            Assert.False(calculator.IsAttackSuccesful(0, 0));
        }

        [Test]
        public void TestDefenceWithNegativeCoordinates()
        {
            var calculator = new OperationSuccessCalculator();

            Assert.False(calculator.IsAttackSuccesful(-1, -1));
        }

        [Test]
        public void TestDefencekWithOutOfBoardCoordinates()
        {
            var calculator = new OperationSuccessCalculator();

            Assert.False(calculator.IsAttackSuccesful(201, 301));
        }
    }
}