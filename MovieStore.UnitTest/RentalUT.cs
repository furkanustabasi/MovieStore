using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MovieStore.Service;
using MovieStore.DTO;

namespace MovieStore.UnitTest
{
    /// <summary>
    /// Summary description for RentalUT
    /// </summary>
    [TestClass]
    public class RentalUT
    {
        private RentalService rentalService;

        [TestInitialize]
        public void SetUp()
        {
            rentalService = new RentalService();
        }

      

        [TestMethod]
        public void Save()
        {
            RentalDTO rental = new RentalDTO
            {
                CustomerId = 1,
                MovieId=1,
                BeginDate=new DateTime(2019,03,15),
                EndDate =new DateTime(2019,03,30),
                TotalPrice=20,
                CreatedDate=DateTime.Now,
                CreatedBy=2,
                RecordStatusId =1

            };

            var result = rentalService.Add(rental);
            Assert.IsNotNull(result);
        }
        [TestMethod]
        public void Update()
        {
            RentalDTO rental = new RentalDTO
            {
                RentalId=1,
                CustomerId = 1,
                MovieId = 1,
                BeginDate = new DateTime(2019, 03, 15),
                EndDate = new DateTime(2019, 03, 30),
                TotalPrice = 15,
                CreatedDate = DateTime.Now,
                CreatedBy = 2,
                RecordStatusId = 2

            };
            var result = rentalService.Update(rental);
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void List()
        {
            var result = rentalService.List();

            Assert.IsNotNull(result);

        }

        [TestMethod]
        public void Get()
        {
            int id = 1;

            var result = rentalService.Get(id);
            Assert.IsNotNull(result);
        }
    }
}
