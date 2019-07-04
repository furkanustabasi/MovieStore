using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MovieStore.DTO;
using MovieStore.Service;

namespace MovieStore.UnitTest
{


    [TestClass]
    public class UserUT
    {
        private UserService userService;
        [TestInitialize]
        public void SetUp()
        {
            userService = new UserService();
        }
        [TestMethod]
        public void Save()
        {
            UserDTO user = new UserDTO
            {
                FirstName = "busra",
                LastName = "demirci",               
                CreatedBy = 2

            };
            var result = userService.Add(user);
            Assert.IsNotNull(result);
        }
        [TestMethod]
        public void Update()
        {
            UserDTO user = new UserDTO
            {
                UserId = 3,
                FirstName = "samet",
                LastName = "özbek",
                UserName = "asamet",
                Password = "123",
                LastLoginDate = DateTime.Now,
                RecordStatusId = 1,
                CreatedDate = DateTime.Now,
                CreatedBy = 2
            };
            var result = userService.Update(user);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void List()
        {
            var result = userService.List();

            Assert.IsNotNull(result);
        }
        [TestMethod]
        public void Get()
        {
            var id = 2;
            var result = userService.Get(id);
            Assert.IsNotNull(result);
            
        }
    }
}