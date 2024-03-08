using LibraryForLabs;

namespace TestLb10
{
    public class Tests
    {
        [TestFixture]
        public class CarsTests
        {
            [Test]
            public void Cars_Properties()
            {
                // Arrange
                string brand = "sfasfas";
                int releaseYear = 1000;
                string color = "asfasfas";
                int cost = -50000;
                double clearance = 4;
                int idNumber = 40;

                // Act
                Cars car = new Cars(brand, releaseYear, color, cost, clearance, idNumber);

                // Assert
                Assert.AreEqual("Toyota", car.Brand);
                Assert.AreEqual(1980, car.ReleaseYear);
                Assert.AreEqual("white", car.Color);
                Assert.AreEqual(10000, car.Cost);
                Assert.AreEqual(10, car.Clearance);
            }
            [Test]
            public void CarsConstructor_WithValidArguments_InitializesCorrectly()
            {
                // Arrange
                string brand = "Toyota";
                int releaseYear = 2020;
                string color = "White";
                int cost = 50000;
                double clearance = 20;
                int idNumber = 1;

                // Act
                Cars car = new Cars(brand, releaseYear, color, cost, clearance, idNumber);

                // Assert
                Assert.AreEqual(brand, car.Brand);
                Assert.AreEqual(releaseYear, car.ReleaseYear);
                Assert.AreEqual(color, car.Color);
                Assert.AreEqual(cost, car.Cost);
                Assert.AreEqual(clearance, car.Clearance);
            }

            [Test]
            public void CarsEquals_TwoEqualCars_ReturnsTrue()
            {
                // Arrange
                Cars car1 = new Cars("Toyota", 2020, "White", 50000, 20, 1);
                Cars car2 = new Cars("Toyota", 2020, "White", 50000, 20, 1);

                // Act & Assert
                Assert.AreEqual(car1, car2);
            }

            [Test]
            public void CarsEquals_TwoDifferentCars_ReturnsFalse()
            {
                // Arrange
                Cars car1 = new Cars("Toyota", 2020, "White", 50000, 20, 1);
                Cars car2 = new Cars("Honda", 2021, "Black", 60000, 25, 2);

                // Act & Assert
                Assert.AreNotEqual(car1, car2);
            }

            public class OffRoadCarTests
            {
                [Test]
                public void OffRoadCar_Properties()
                {
                    // Arrange
                    string brand = "sfasfas";
                    int releaseYear = 1000;
                    string color = "asfasfas";
                    int cost = -50000;
                    double clearance = 4;
                    bool awd = false;
                    string offRoadType = "sfagasg";
                    int idNumber = 40;

                    // Act
                    OffRoadCar offRoadCar = new OffRoadCar(brand, releaseYear, color, cost, clearance, awd, offRoadType, idNumber);

                    // Assert
                    Assert.AreEqual("Toyota", offRoadCar.Brand);
                    Assert.AreEqual(1980, offRoadCar.ReleaseYear);
                    Assert.AreEqual("white", offRoadCar.Color);
                    Assert.AreEqual(10000, offRoadCar.Cost);
                    Assert.AreEqual(10, offRoadCar.Clearance);
                    Assert.AreEqual(false, awd);
                    Assert.AreEqual("gravel roads", offRoadCar.OffRoadType);
                }
                [Test]
                public void OffRoadCarConstructor_WithValidArguments_InitializesCorrectly()
                {
                    // Arrange
                    string brand = "Toyota";
                    int releaseYear = 2020;
                    string color = "White";
                    int cost = 250000;
                    double clearance = 25;
                    bool awd = true;
                    string offRoadType = "gravel roads";
                    int idNumber = 1;

                    // Act
                    OffRoadCar offRoadCar = new OffRoadCar(brand, releaseYear, color, cost, clearance, awd, offRoadType, idNumber);

                    // Assert
                    Assert.AreEqual(brand, offRoadCar.Brand);
                    Assert.AreEqual(releaseYear, offRoadCar.ReleaseYear);
                    Assert.AreEqual(color, offRoadCar.Color);
                    Assert.AreEqual(cost, offRoadCar.Cost);
                    Assert.AreEqual(clearance, offRoadCar.Clearance);
                    Assert.AreEqual(awd, offRoadCar.Awd);
                    Assert.AreEqual(offRoadType, offRoadCar.OffRoadType);
                }

                [Test]
                public void OffRoadCarEquals_TwoEqualOffRoadCars_ReturnsTrue()
                {
                    // Arrange
                    OffRoadCar offRoadCar1 = new OffRoadCar("Toyota", 2020, "White", 50000, 20, true, "Gravel Roads", 1);
                    OffRoadCar offRoadCar2 = new OffRoadCar("Toyota", 2020, "White", 50000, 20, true, "Gravel Roads", 1);

                    // Act & Assert
                    Assert.AreEqual(offRoadCar1, offRoadCar2);
                }

                [Test]
                public void OffRoadCarEquals_TwoDifferentOffRoadCars_ReturnsFalse()
                {
                    // Arrange
                    OffRoadCar offRoadCar1 = new OffRoadCar("Toyota", 2020, "White", 50000, 20, true, "Gravel Roads", 1);
                    OffRoadCar offRoadCar2 = new OffRoadCar("Honda", 2021, "Black", 60000, 25, false, "Mountain Trails", 2);

                    // Act & Assert
                    Assert.AreNotEqual(offRoadCar1, offRoadCar2);
                }

                [Test]
                public void OffRoadCar_Equals_ReturnsTrueForEqualObjects()
                {
                    // Arrange
                    var car1 = new OffRoadCar("Toyota", 2020, "Black", 50000, 20, true, "gravel roads", 1);
                    var car2 = new OffRoadCar("Toyota", 2020, "Black", 50000, 20, true, "gravel roads", 1);

                    // Act
                    var result = car1.Equals(car2);

                    // Assert
                    Assert.IsTrue(result);
                }

                [Test]
                public void OffRoadCar_Init_InitializesObjectCorrectly()
                {
                    // Arrange
                    var car = new OffRoadCar();

                    // Act
                    car.RandomInit();

                    // Assert
                    Assert.IsNotNull(car.Brand);
                    Assert.IsNotNull(car.ReleaseYear);
                    Assert.IsNotNull(car.Color);
                    Assert.IsNotNull(car.Cost);
                    Assert.IsNotNull(car.Clearance);
                    Assert.IsNotNull(car.Awd);
                    Assert.IsNotNull(car.OffRoadType);
                }

            }

            public class PassengerCarTests
            {
                [Test]
                public void PassengerCarConstructor_WithValidArguments_InitializesCorrectly()
                {
                    // Arrange
                    string brand = "Toyota";
                    int releaseYear = 2020;
                    string color = "White";
                    int cost = 50000;
                    double clearance = 20;
                    int numberOfSeats = 5;
                    int topSpeed = 120;
                    int idNumber = 1;

                    // Act
                    PassengerCar passengerCar = new PassengerCar(brand, releaseYear, color, cost, clearance, numberOfSeats, topSpeed, idNumber);

                    // Assert
                    Assert.AreEqual(brand, passengerCar.Brand);
                    Assert.AreEqual(releaseYear, passengerCar.ReleaseYear);
                    Assert.AreEqual(color, passengerCar.Color);
                    Assert.AreEqual(cost, passengerCar.Cost);
                    Assert.AreEqual(clearance, passengerCar.Clearance);
                    Assert.AreEqual(numberOfSeats, passengerCar.NumberOfSeats);
                    Assert.AreEqual(topSpeed, passengerCar.TopSpeed);
                }

                [Test]
                public void PassengerCar_Properties()
                {
                    // Arrange
                    string brand = "sfasfas";
                    int releaseYear = 1000;
                    string color = "asfasfas";
                    int cost = -50000;
                    double clearance = 4;
                    int numberOfSeats = 5;
                    int topSpeed = 40;
                    int idNumber = 40;

                    // Act
                    PassengerCar passengerCar = new PassengerCar(brand, releaseYear, color, cost, clearance, numberOfSeats, topSpeed, idNumber);

                    // Assert
                    Assert.AreEqual("Toyota", passengerCar.Brand);
                    Assert.AreEqual(1980, passengerCar.ReleaseYear);
                    Assert.AreEqual("white", passengerCar.Color);
                    Assert.AreEqual(10000, passengerCar.Cost);
                    Assert.AreEqual(10, passengerCar.Clearance);
                    Assert.AreEqual(5, passengerCar.NumberOfSeats);
                    Assert.AreEqual(120, passengerCar.TopSpeed);
                }

                [Test]
                public void PassengerCarEquals_TwoEqualPassengerCars_ReturnsTrue()
                {
                    // Arrange
                    PassengerCar passengerCar1 = new PassengerCar("Toyota", 2020, "White", 50000, 20, 5, 120, 1);
                    PassengerCar passengerCar2 = new PassengerCar("Toyota", 2020, "White", 50000, 20, 5, 120, 1);

                    // Act & Assert
                    Assert.AreEqual(passengerCar1, passengerCar2);
                }

                [Test]
                public void PassengerCarEquals_TwoDifferentPassengerCars_ReturnsFalse()
                {
                    // Arrange
                    PassengerCar passengerCar1 = new PassengerCar("Toyota", 2020, "White", 50000, 20, 5, 120, 1);
                    PassengerCar passengerCar2 = new PassengerCar("Honda", 2021, "Black", 60000, 25, 7, 150, 2);

                    // Act & Assert
                    Assert.AreNotEqual(passengerCar1, passengerCar2);
                }

                [Test]
                public void Cars_ShallowCopy_ReturnsShallowCopyOfObject()
                {
                    // Arrange
                    var originalCar = new PassengerCar("Toyota", 2020, "Black", 500000, 20, 1, 200, 100);

                    // Act
                    var copiedCar = originalCar.ShallowCopy() as PassengerCar;

                    // Assert
                    Assert.IsNotNull(copiedCar);
                    Assert.AreNotSame(originalCar, copiedCar);
                    Assert.AreEqual(originalCar, copiedCar);
                    Assert.AreSame(originalCar.id, copiedCar.id);
                }

                [Test]
                public void Cars_Clone_ReturnsDeepCopyOfObject()
                {
                    // Arrange
                    var originalCar = new PassengerCar("Toyota", 2020, "Black", 500000, 20, 1, 200, 100);

                    // Act
                    var clonedCar = originalCar.Clone() as PassengerCar;

                    // Assert
                    Assert.IsNotNull(clonedCar);
                    Assert.AreNotSame(originalCar, clonedCar);
                    Assert.AreEqual(originalCar, clonedCar);
                }

                [Test]
                public void Cars_Equals_ReturnsTrueForEqualObjects()
                {
                    // Arrange
                    var car1 = new PassengerCar("Toyota", 2020, "Black", 500000, 20, 1, 200, 100);
                    var car2 = new PassengerCar("Toyota", 2020, "Black", 500000, 20, 1, 200, 100);

                    // Act
                    var result = car1.Equals(car2);

                    // Assert
                    Assert.IsTrue(result);
                }
                [Test]
                public void PassengerCar_RandomInit_InitializesObjectWithRandomValues()
                {
                    // Arrange
                    var car = new PassengerCar();

                    // Act
                    car.RandomInit();

                    // Assert
                    Assert.IsNotNull(car.Brand);
                    Assert.IsNotNull(car.ReleaseYear);
                    Assert.IsNotNull(car.Color);
                    Assert.IsNotNull(car.Cost);
                    Assert.IsNotNull(car.Clearance);
                    Assert.IsNotNull(car.NumberOfSeats);
                    Assert.IsNotNull(car.TopSpeed);
                }

            }

            public class TruckCarTests
            {
                [Test]
                public void TruckCar_Properties()
                {
                    // Arrange
                    string brand = "sfasfas";
                    int releaseYear = 1000;
                    string color = "asfasfas";
                    int cost = -50000;
                    double clearance = 4;
                    int loadCapacity = -225;
                    int idNumber = 40;

                    // Act
                    TruckCar truckCar = new TruckCar(brand, releaseYear, color, cost, clearance, loadCapacity, idNumber);

                    // Assert
                    Assert.AreEqual("Toyota", truckCar.Brand);
                    Assert.AreEqual(1980, truckCar.ReleaseYear);
                    Assert.AreEqual("white", truckCar.Color);
                    Assert.AreEqual(10000, truckCar.Cost);
                    Assert.AreEqual(10, truckCar.Clearance);
                    Assert.AreEqual(550, truckCar.LoadCapacity);
                }
                [Test]
                public void TruckCarConstructor_WithValidArguments_InitializesCorrectly()
                {
                    // Arrange
                    string brand = "Honda";
                    int releaseYear = 2019;
                    string color = "Red";
                    int cost = 180000;
                    double clearance = 30;
                    int loadCapacity = 1500;
                    int idNumber = 2;

                    // Act
                    TruckCar truckCar = new TruckCar(brand, releaseYear, color, cost, clearance, loadCapacity, idNumber);

                    // Assert
                    Assert.AreEqual(brand, truckCar.Brand);
                    Assert.AreEqual(releaseYear, truckCar.ReleaseYear);
                    Assert.AreEqual(color, truckCar.Color);
                    Assert.AreEqual(cost, truckCar.Cost);
                    Assert.AreEqual(clearance, truckCar.Clearance);
                    Assert.AreEqual(loadCapacity, truckCar.LoadCapacity);
                    Assert.AreEqual(idNumber, truckCar.id.number);
                }

                [Test]
                public void TruckCarEquals_TwoEqualTruckCars_ReturnsTrue()
                {
                    // Arrange
                    TruckCar truckCar1 = new TruckCar("Volvo", 2019, "Red", 80000, 30, 1500, 2);
                    TruckCar truckCar2 = new TruckCar("Volvo", 2019, "Red", 80000, 30, 1500, 2);

                    // Act & Assert
                    Assert.AreEqual(truckCar1, truckCar2);
                }

                [Test]
                public void TruckCarEquals_TwoDifferentTruckCars_ReturnsFalse()
                {
                    // Arrange
                    TruckCar truckCar1 = new TruckCar("Volvo", 2019, "Red", 80000, 30, 1500, 2);
                    TruckCar truckCar2 = new TruckCar("MAN", 2020, "Blue", 90000, 35, 2000, 3);

                    // Act & Assert
                    Assert.AreNotEqual(truckCar1, truckCar2);
                }

                [Test]
                public void TruckCar_Equals_ReturnsTrueForEqualObjects()
                {
                    // Arrange
                    var car1 = new TruckCar("Toyota", 2020, "Black", 50000, 20, 1000, 1);
                    var car2 = new TruckCar("Toyota", 2020, "Black", 50000, 20, 1000, 1);

                    // Act
                    var result = car1.Equals(car2);

                    // Assert
                    Assert.IsTrue(result);
                }

                [Test]
                public void TruckCar_Init_InitializesObjectCorrectly()
                {
                    // Arrange
                    var car = new TruckCar();

                    // Act
                    car.RandomInit();

                    // Assert
                    Assert.IsNotNull(car.Brand);
                    Assert.IsNotNull(car.ReleaseYear);
                    Assert.IsNotNull(car.Color);
                    Assert.IsNotNull(car.Cost);
                    Assert.IsNotNull(car.Clearance);
                    Assert.IsNotNull(car.LoadCapacity);
                }


            }
        }
    }
}
