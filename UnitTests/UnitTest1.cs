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
        SupplierBUS supBUS;
        EmployeeBUS empBUS;

        [TestInitialize]
        public void initTest()
        {
            lgb = new LoginBUS();
            proBUS = new ProductBUS();
            payBUS = new PaycheckBUS();
            detBUS = new DetailsBUS();
            supBUS = new SupplierBUS();
            empBUS = new EmployeeBUS();
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
            proBUS.del(id);
        }

        [TestMethod]
        public void SupplierManTest1()
        {
            string id = "TESTSUPPLIER";
            string name = "testSupplier";
            string address = "testAddress";
            int phone = 11111111;
            string web = "www.testwebsite.com";
            Supplier test = new Supplier(id, name, phone, address, web);
            int actual = supBUS.add(test);
            int expect = 1;
            supBUS.del(id);
            Assert.AreEqual(expect, actual);
        }

        [TestMethod]
        public void EmployeeManTest1()
        {
            string id = "TESTEM";
            string name = "testEmployee";
            string acc = "testAccount";
            string pass = "test";
            int pri = 0;
            Employee test = new Employee(id, name, acc, pass, pri);
            int actual = empBUS.add(test);
            int expect = 1;
            empBUS.del(id);
            Assert.AreEqual(expect, actual);
        }

        [TestMethod]
        public void OrderManTest1()
        {
            string id = "TEST";
            string day = DateTime.Today.ToString();
            string name = "testCustomer";
            float cost = 1;
            string empId = "E001";
            Paycheck test = new Paycheck(id, name, cost, day, empId);
            int actual = payBUS.addFull(test);
            int expect = 1;
            payBUS.del(id);
            Assert.AreEqual(expect, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(SqlException))]
        public void OrderManTest2()
        {
            string id = "TEST";
            string day = DateTime.Today.ToString();
            string name = "testCustomer";
            float cost = 1;
            string empId = "WRONG";
            Paycheck test = new Paycheck(id, name, cost, day, empId);
            int actual = payBUS.addFull(test);
            payBUS.del(id);
        }

        [TestMethod]
        [ExpectedException(typeof(SqlException))]
        public void OrderManTest3()
        {
            string id = "TEST";
            string day = "WRONG";
            string name = "testCustomer";
            float cost = 1;
            string empId = "E001";
            Paycheck test = new Paycheck(id, name, cost, day, empId);
            int actual = payBUS.addFull(test);
            payBUS.del(id);
        }

        [TestMethod]
        public void DetailManTest1()
        {
            string detId = "HD01";
            string proId = "JACA";
            string name = "test";
            float price = 1;
            int amount = 1;
            float cost = 1;
            Details test = new Details(detId, proId, name, price, amount, cost);
            int actual = detBUS.add(test);
            int expect = 1;
            detBUS.del(proId);
            Assert.AreEqual(expect, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(SqlException))]
        public void DetailManTest2()
        {
            string detId = "WRONG";
            string proId = "JACA";
            string name = "test";
            float price = 1;
            int amount = 1;
            float cost = 1;
            Details test = new Details(detId, proId, name, price, amount, cost);
            int actual = detBUS.add(test);
            detBUS.del(proId);
        }

        [TestMethod]
        [ExpectedException(typeof(SqlException))]
        public void DetailManTest3()
        {
            string detId = "HD01";
            string proId = "WRONG";
            string name = "test";
            float price = 1;
            int amount = 1;
            float cost = 1;
            Details test = new Details(detId, proId, name, price, amount, cost);
            int actual = detBUS.add(test);
            detBUS.del(proId);
        }
    }
}
