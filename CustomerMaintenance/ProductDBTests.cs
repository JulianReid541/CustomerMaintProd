using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace CustomerMaintenance
{
    [TestFixture]
    public class ProductDBTests
    {
        [Test]
        public void TestGetProduct()
        {
            Product p = ProductDB.GetProduct("ZZZZ      ");

            Assert.AreEqual("ZZZZ      ", p.ProductCode);
           // Assert.AreEqual(6937, p.OnHandQuantity);
            //Assert.AreEqual("Murach's JavaScript (2nd Edition)", p.Description);
        }

        [Test]
        public void TestInsertProduct()
        {
            Product nP = new Product();
            nP.ProductCode = "ZZZZ";
            nP.Description = "Test Product";
            nP.UnitPrice = 99.99M;
            nP.OnHandQuantity = 2;        

            ProductDB.AddProduct(nP);           
        }
    }
}
