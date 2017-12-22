using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shoestore.Controllers;
using System.Web.Mvc;
using Moq;
using Shoestore.Models;
using System.Linq;

namespace Shoestore.Tests.Controllers
{
    [TestClass]
    public class Table_3Test
    {
        Table_3Controller controller;
        Mock<iTable_3> mock;
        List<Table_3> Table_3;

        [TestInitialize]
        public void TestInitialize()
        {
            mock = new Mock<iTable_3>();

            Table_3 = new List<Table_3>
            {
                    new Table_3 {footsize = 1, Models = "Jordans", city = "Barrie", quantity = 10},
                    new Table_3 {footsize = 2, Models = "Airmax", city = "Toronto", quantity = 15},
                    new Table_3 {footsize = 3, Models = "Sneakers", city = "Brampton", quantity = 10}

            };
            // add store data to the mock object
            mock.Setup(m => m.Table_3).Returns(Shoestore.Models.Table_3.AsQueryable());

            controller = new Table_3Controller(mock.Object);
        }

        [TestMethod]
        public void IndexLoadsValid()


        {
            //StoreController controller = new StoreController();

            ViewResult result = controller.Index() as ViewResult;

            Assert.IsNotNull(result);

        }

        [TestMethod]
        public void IndexShowValidStores()
        {
            var actual = (List<Table_3>)controller.Index().Model;

            CollectionAssert.AreEqual(Table_3, actual);
        }

        [TestMethod]
        public void DetailsValidStore()
        {
            var actual = (Table_3)controller.Details(1).Model;

            Assert.AreEqual(Table_3.ToList()[0], actual);
        }

        [TestMethod]
        public void DetailsInvalidId()
        {
            ViewResult actual = controller.Details(4);

            Assert.AreEqual("Error", actual.ViewName);
        }

        [TestMethod]
        public void DetailsInvalidNoId()
        {
            ViewResult actual = controller.Details(null);

            Assert.AreEqual("Error", actual.ViewName);
        }

        [TestMethod]
        public void DeleteConfirmedNoId()
        {
            ViewResult actual = controller.DeleteConfirmed(null);

            Assert.AreEqual("Error", actual.ViewName);
        }

        [TestMethod]
        public void DeleteConfirmedInvalidId()
        {
            ViewResult actual = controller.DeleteConfirmed(6);

            Assert.AreEqual("Error", actual.ViewName);
        }

        [TestMethod]
        public void DeleteConfirmedValidId()
        {
            ViewResult actual = controller.DeleteConfirmed(1);

            Assert.AreEqual("Index", actual.ViewName);
        }

        private class Mock<T>
        {
            public iTable_3 Object { get; internal set; }

            internal object Setup(Func<object, object> p)
            {
                throw new NotImplementedException();
            }
        }
    }
}
