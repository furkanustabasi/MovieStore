using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MovieStore.DTO;
using MovieStore.Service;

namespace MovieStore.UnitTest
{
    [TestClass]
    public class CustomerUT
    {
        private CustomerService customerService;

        [TestInitialize]
        public void Setup()
        {
            customerService = new CustomerService();
        }

        [TestMethod]
        public void Save()
        {
            CustomerDTO customer = new CustomerDTO
            {
                FirstName = "Batuhan",
                LastName = "Kaya",
                TcNumber = "11111111111",
                MobilePhone = "05553332211",
                CreatedDate = DateTime.Now,
                RecordStatusId = 1,
                CreatedBy = 2
                
            };
            var result = customerService.Add(customer);

            Assert.IsNotNull(result);

        }

        [TestMethod]
        public void Update()
        {
            CustomerDTO customer = new CustomerDTO
            {
                CustomerId = 1,
                FirstName = "ece",
                LastName = "demir",
                TcNumber = "11111122222",
                MobilePhone = "05553335555",
                CreatedDate = DateTime.Now,
                RecordStatusId = 1,
                CreatedBy = 2
            };

            var result = customerService.Update(customer);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void List()
        {
            var result = customerService.List();

            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void Get()
        {
            int id = 1;
            var result = customerService.Get(id);

            Assert.IsNotNull(result);
        }
    }
}
