﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using fitness_app.BL.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fitness_app.BL.Controller.Tests
{
    [TestClass()]
    public class UserControllerTests
    {
 

        //[TestMethod()] 
        //public void GetUsersDataTest()
        //{
        //    var userName = Guid.NewGuid().ToString();
        //}

        [TestMethod()]
        public void SetNewUserDataTest()
        {
            // Arrange

            var userName = Guid.NewGuid().ToString();
            var birthdate = DateTime.Now.AddYears(-18);
            var weight = 90;
            var height = 188;
            var gender = "man";
            var conroller = new UserController(userName);

            // Act

            conroller.SetNewUserData(gender, birthdate, weight, height);
            var controller2 = new UserController(userName);

            // Assert 

            Assert.AreEqual(userName, controller2.CurrentUser.Name);
            Assert.AreEqual(birthdate, controller2.CurrentUser.BirthDate);
            Assert.AreEqual(weight, controller2.CurrentUser.Weight);
            Assert.AreEqual(height, controller2.CurrentUser.Height);
            Assert.AreEqual(gender, controller2.CurrentUser.Gender.Name); 
        } 

        [TestMethod()]
        public void SaveTest()
        {
            // Arrange
            var userName = Guid.NewGuid().ToString();

            // Act
            var controller = new UserController(userName);

            // Assert
            Assert.AreEqual(userName, controller.CurrentUser.Name);
        }
    }
}