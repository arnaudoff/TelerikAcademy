namespace Cars.Tests.JustMock
{
    using System;
    using System.Collections.Generic;

    using Cars.Contracts;
    using Cars.Tests.JustMock.Mocks;
    using Cars.Controllers;
    using Cars.Models;

    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Moq;

    [TestClass]
    public class CarsControllerTests
    {
        private readonly ICarsRepository carsData;
        private CarsController controller;

        public CarsControllerTests()
            //: this(new JustMockCarsRepository())
            : this(new MoqCarsRepository())
        {
        }

        private CarsControllerTests(ICarsRepositoryMock carsDataMock)
        {
            this.carsData = carsDataMock.CarsData;
        }

        [TestInitialize]
        public void CreateController()
        {
            this.controller = new CarsController(this.carsData);
        }

        [TestMethod]
        public void IndexShouldReturnAllCars()
        {
            var model = (ICollection<Car>)this.GetModel(() => this.controller.Index());

            Assert.AreEqual(4, model.Count);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void AddingCarShouldThrowArgumentNullExceptionIfCarIsNull()
        {
            var model = (Car)this.GetModel(() => this.controller.Add(null));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void AddingCarShouldThrowArgumentNullExceptionIfCarMakeIsNull()
        {
            var car = new Car
            {
                Id = 15,
                Make = "",
                Model = "330d",
                Year = 2014
            };

            var model = (Car)this.GetModel(() => this.controller.Add(car));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void AddingCarShouldThrowArgumentNullExceptionIfCarModelIsNull()
        {
            var car = new Car
            {
                Id = 15,
                Make = "BMW",
                Model = "",
                Year = 2014
            };

            var model = (Car)this.GetModel(() => this.controller.Add(car));
        }

        [TestMethod]
        public void AddingCarShouldReturnADetail()
        {
            var car = new Car
            {
                Id = 15,
                Make = "BMW",
                Model = "330d",
                Year = 2014
            };

            var model = (Car)this.GetModel(() => this.controller.Add(car));

            Assert.AreEqual(1, model.Id);
            Assert.AreEqual("Audi", model.Make);
            Assert.AreEqual("A5", model.Model);
            Assert.AreEqual(2005, model.Year);
        }


        [TestMethod]
        public void DetailsShouldReturnFirstCarOfTheListIfInvalidId()
        {
            var details = (Car)this.GetModel(() => this.controller.Details(42));

            Assert.AreEqual(1, details.Id);
            Assert.AreEqual("Audi", details.Make);
            Assert.AreEqual("A5", details.Model);
            Assert.AreEqual(2005, details.Year);
        }

        [TestMethod]
        public void GettingDetailsShouldWorkCorrectly()
        {
            var details = (Car)GetModel(() => this.controller.Details(1));

            Assert.AreEqual(1, details.Id);
            Assert.AreEqual("Audi", details.Make);
            Assert.AreEqual("A5", details.Model);
            Assert.AreEqual(2005, details.Year);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void SortShouldThrowArgumentExceptionWhenEmptyArgumentIsGiven()
        {
            var sortedCars = (ICollection<Car>)this.GetModel(() => this.controller.Sort(string.Empty));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void SortShouldThrowArgumentExceptionWhenInvalidArgumentIsGiven()
        {
            var sortedCars = (ICollection<Car>)this.GetModel(() => this.controller.Sort("id"));
        }

        [TestMethod]
        public void SortByMakeShouldWorkCorrectly()
        {
            var sortedCars = (IList<Car>)this.GetModel(() => this.controller.Sort("make"));

            Assert.AreEqual("Audi", sortedCars[0].Make);
            Assert.AreEqual("BMW", sortedCars[1].Make);
            Assert.AreEqual("BMW", sortedCars[2].Make);
            Assert.AreEqual("Opel", sortedCars[3].Make);
        }

        [TestMethod]
        public void SortByYearShouldWorkCorrectly()
        {
            var sortedCars = (IList<Car>)this.GetModel(() => this.controller.Sort("year"));

            Assert.AreEqual(2010, sortedCars[0].Year);
            Assert.AreEqual(2008, sortedCars[1].Year);
            Assert.AreEqual(2007, sortedCars[2].Year);
            Assert.AreEqual(2005, sortedCars[3].Year);
        }

        [TestMethod]
        public void SearchWithEmptyStringShouldReturnDefaultList()
        {
            var searchCars = (ICollection<Car>)this.GetModel(() => this.controller.Search(string.Empty));

            Assert.AreEqual(2, searchCars.Count);
        }

        [TestMethod]
        public void SearchWithBMWsShouldReturnOnlyBMWs()
        {
            var searchCars = (IList<Car>)this.GetModel(() => this.controller.Search("BMW"));

            Assert.AreEqual(2, searchCars.Count);

            Assert.AreEqual("325i", searchCars[0].Model);
            Assert.AreEqual("330d", searchCars[1].Model);
        }

        private object GetModel(Func<IView> funcView)
        {
            var view = funcView();
            return view.Model;
        }
    }
}
