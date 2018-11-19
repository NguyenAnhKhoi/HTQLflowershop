using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BUS;
using HTQL;
using DTO;
using System.Data.SqlClient;

namespace UnitTests
{
    [TestClass]
    public class UnitTest1
    {
        LoginBUS lgb;
        ProductBUS proBUS;
        PaycheckBUS payBUS;
        DetailsBUS detBUS;

        [TestInitialize]
        public void initTest()
        {
            lgb = new LoginBUS();
            proBUS = new ProductBUS();
            payBUS = new PaycheckBUS();
            detBUS = new DetailsBUS();
        }

        [TestMethod]
        public void LoginTest1()
        {
            string user = "admin01";
            string pass = "123";
            Account acc = new Account(user, pass);
            bool actual = lgb.Login(acc);
            bool expect = true;
            Assert.AreEqual(expect, actual);
        }

        [TestMethod]
        public void LoginTest2()
        {
            string user = "wrong";
            string pass = "account";
            Account acc = new Account(user, pass);
            bool actual = lgb.Login(acc);
            bool expect = false;
            Assert.AreEqual(expect, actual);
        }

        [TestMethod]
        public void LoginTest3()
        {
            string user = "";
            string pass = "123";
            Account acc = new Account(user, pass);
            bool actual = lgb.Login(acc);
            bool expect = false;
            Assert.AreEqual(expect, actual);
        }

        [TestMethod]
        public void LoginTest4()
        {
            string user = "admin01";
            string pass = "";
            Account acc = new Account(user, pass);
            bool actual = lgb.Login(acc);
            bool expect = false;
            Assert.AreEqual(expect, actual);
        }

        [TestMethod]
        public void LoginTest5()
        {
            string user = "";
            string pass = "";
            Account acc = new Account(user, pass);
            bool actual = lgb.Login(acc);
            bool expect = false;
            Assert.AreEqual(expect, actual);
        }

        [TestMethod]
        public void ProductManTest1()
        {
            string id = "TEST";
            string name = "testFlower";
            float sell = 10000;
            string supId = "LOVEP";
            Product item = new Product(id, name, sell, supId);
            int actual = proBUS.add(item);
            int expect = 1;
            proBUS.del(id);
            Assert.AreEqual(expect, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(SqlException))]
        public void ProductManTest2()
        {
            string id = "TEST";
            string name = "testFlower";
            float sell = 10000;
            string supId = "WRONG";
            Product item = new Product(id, name, sell, supId);
            int actual = proBUS.add(item);
        }

        [TestMethod]
        [ExpectedException(typeof(SqlException))]
        public void ProductManTest3()
        {
            string id = "";
            string name = "testFlower";
            float sell = 10000;
            string supId = "LOVEP";
            Product item = new Product(id, name, sell, supId);
            int actual = proBUS.add(item);
        }

        [TestMethod]
        [ExpectedException(typeof(SqlException))]
        public void ProductManTest4()
        {
            string id = "TEST";
            string name = "testFlower";
            float sell = 10000;
            string supId = "";
            Product item = new Product(id, name, sell, supId);
            int actual = proBUS.add(item);
        }

        [TestMethod]
        [ExpectedException(typeof(SqlException))]
        public void ProductManTest5()
        {
            string id = "";
            string name = "testFlower";
            float sell = 10000;
            string supId = "";
            Product item = new Product(id, name, sell, supId);
            int actual = proBUS.add(item);
        }

        [TestMethod]
        public void ReceiptSendTest1()
        {
            string cusName = "testCustomer";
            string recId = "TEST01";
            float price = 5000;
            string proID = "LASPEC";
            string proName = "Bằng Lăng";
            int amount = 2;
            float cost = price * amount;
            Paycheck pay = new Paycheck(recId, cusName, price);
            Details det = new Details(recId, proID, proName, price, amount, cost);

            int actual1 = payBUS.add(pay);
            int actual2 = detBUS.add(det);
            int expect = 1;

            detBUS.del(recId);
            payBUS.del(recId);

            Assert.AreEqual(expect, actual1);
            Assert.AreEqual(expect, actual2);
        }

        [TestMethod]
        [ExpectedException(typeof(SqlException))]
        public void ReceiptSendTest2()
        {
            string cusName = "testCustomer";
            string recId = "";
            float price = 5000;
            string proID = "LASPEC";
            string proName = "Bằng Lăng";
            int amount = 2;
            float cost = price * amount;
            Paycheck pay = new Paycheck(recId, cusName, price);
            Details det = new Details(recId, proID, proName, price, amount, cost);

            int actual1 = payBUS.add(pay);
            int actual2 = detBUS.add(det);
        }
    }
}
