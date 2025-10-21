using Microsoft.VisualStudio.TestPlatform.TestHost;
using EngineModule;
using Moq;
using CarModule;

namespace IntegrationTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test_CarCreation()
        {
            Mock<IEngine> mockEngine = new Mock<IEngine>();
            mockEngine.SetupProperty(e => e.Has8Pistons, true);
            mockEngine.SetupProperty(e => e.HorsePower, 500);
            mockEngine.SetupProperty(e => e.Manufacturer, "Mockmani");
            mockEngine.SetupProperty(e => e.TypeOfEngine, EngineType.Petrol);

            Car Lamborgini = new Car(mockEngine.Object);

            Assert.That(Lamborgini, Is.Not.Null);
            Assert.That(mockEngine.Object, Is.Not.Null);
            Assert.That(Lamborgini.CarEngine,Is.SameAs(mockEngine.Object));
        }
        [Test]
        public void Test_Car_Should_Call_RegisterThroughApi()
        {
            Mock<IEngine> mockEngine = new Mock<IEngine>();
            mockEngine.SetupProperty(e => e.Has8Pistons, true);
            mockEngine.SetupProperty(e => e.HorsePower, 500);
            mockEngine.SetupProperty(e => e.Manufacturer, "Mockmani");
            mockEngine.SetupProperty(e => e.TypeOfEngine, EngineType.Petrol);
            mockEngine.Setup(e => e.RegisterThroughApi()).Returns("Status of Registration");

            Car Lamborgini = new Car(mockEngine.Object);
            Lamborgini.CarEngine.RegisterThroughApi();

            Assert.That(Lamborgini, Is.Not.Null);
            Assert.That(mockEngine.Object, Is.Not.Null);
            Assert.That(Lamborgini.CarEngine, Is.SameAs(mockEngine.Object));
            mockEngine.Verify(e=>e.RegisterThroughApi(), Times.Once);
        }
    }
}