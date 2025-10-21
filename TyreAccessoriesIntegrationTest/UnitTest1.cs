using AccessoriesModule;
using CarModule;
using Moq;
using NUnit.Framework;
using System.Collections.Generic;
using TyreModule;

namespace TyreAccessoriesIntegrationTest
{
    public class Tests
    {
        // No setup needed for these specific tests, but keeping the method is good practice.
        [SetUp]
        public void Setup()
        {
        }

        /// <summary>
        /// This test verifies that the Car object is created successfully and its
        /// properties (CarTyres, CarAccessories) are correctly assigned from the constructor.
        /// </summary>
        [Test]
        public void Test_CarCreation_Should_Initialize_Properties()
        {
            // Arrange
            var mockTyre = new Mock<ITyre>();
            var mockAccessories = new Mock<IAccessories>();

            mockTyre.SetupProperty(t => t.manifacturer, "MRF Tyres");
            mockTyre.SetupProperty(t => t.material, "Rubber");

            mockAccessories.SetupProperty(a => a.accessories, new List<AccessoriesEnum> { AccessoriesEnum.RearCamera, AccessoriesEnum.Carjack });

            // Act
            var lamborgini = new Car(mockTyre.Object, mockAccessories.Object);

            // Assert
            Assert.That(lamborgini, Is.Not.Null);
            Assert.That(lamborgini.CarTyres, Is.Not.Null);
            Assert.That(lamborgini.CarAccessories, Is.Not.Null);
            Assert.That(lamborgini.CarTyres, Is.SameAs(mockTyre.Object));
            Assert.That(lamborgini.CarAccessories, Is.SameAs(mockAccessories.Object));
        }

        /// <summary>
        /// This test verifies that calling GetTyreCertification() on the car's tyre property
        /// correctly invokes the underlying method on the ITyre dependency.
        /// </summary>
        [Test]
        public void Test_Car_Should_Call_GetCertification()
        {
            // Arrange
            var mockTyre = new Mock<ITyre>();
            var mockAccessories = new Mock<IAccessories>();

            // Setup the method we want to verify.
            mockTyre.Setup(t => t.GetTyreCertification()).Returns("Status of Registration");

            var lamborgini = new Car(mockTyre.Object, mockAccessories.Object);

            // Act
            // We must explicitly call the method for the verification to pass.
            string result = lamborgini.CarTyres.GetTyreCertification();

            // Assert
            Assert.That(result, Is.EqualTo("Status of Registration")); // Optional: Assert the return value.
            // Now, we verify that the mocked method was called exactly one time.
            mockTyre.Verify(t => t.GetTyreCertification(), Times.Once);
        }

        /// <summary>
        /// This test verifies that calling service() on the car's accessories property
        /// correctly invokes the underlying method on the IAccessories dependency.
        /// It also shows how to verify a method was NOT called.
        /// </summary>
        [Test]
        public void Test_Car_Should_Call_Service_But_Not_Purchase()
        {
            // Arrange
            var mockTyre = new Mock<ITyre>();
            var mockAccessories = new Mock<IAccessories>();

            // Setup the methods we are interested in.
            mockAccessories.Setup(a => a.service()).Returns("Service Completed");
            mockAccessories.Setup(a => a.purchase()).Returns("Purchase Made");

            var lamborgini = new Car(mockTyre.Object, mockAccessories.Object);

            // Act
            // Explicitly call the 'service' method. Note that we are NOT calling 'purchase'.
            string result = lamborgini.CarAccessories.service();

            // Assert
            Assert.That(result, Is.EqualTo("Service Completed")); // Optional: Assert the return value.

            // Verify that the mocked 'service()' method was called exactly one time.
            mockAccessories.Verify(a => a.service(), Times.Once);

            // Verify that the mocked 'purchase()' method was never called.
            mockAccessories.Verify(a => a.purchase(), Times.Never);
        }
    }
}
