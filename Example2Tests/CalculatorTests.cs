using Example2;
using Moq;

namespace Example2Tests
{
    [TestClass]
    public class CalculatorTests
    {
        [TestMethod]
        public void Method1Test()
        {
            //Arrange
            var mock = new Mock<IWrapperStaticDependency>();
            var calculator = new Calculator(4, 5, new Operator(), new Dependency(), mock.Object);

            //Act
            var result = calculator.Method1();

            //Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void Method2Test()
        {
            //Arrange
            var mock = new Mock<IWrapperStaticDependency>();
            var calculator = new Calculator(4, 5, new Operator(), new Dependency(), mock.Object);

            //Act
            var result = calculator.Method2();

            //Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void Method3Test()
        {
            //Arrange
            var mock = new Mock<IWrapperStaticDependency>();
            mock.Setup(m => m.GetDBName()).Returns("MyDb.db");
            var calculator = new Calculator(4, 5, new Operator(), new Dependency(), mock.Object);

            //Act
            var result = calculator.Method3();

            //Assert
            Assert.IsNotNull(result);
        }
    }
}