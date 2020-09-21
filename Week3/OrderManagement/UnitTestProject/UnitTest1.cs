using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OrderManagement;
using System.IO;
using System.Linq;


namespace UnitTestProject
{
    [TestClass()]
    public class OrderServiceTests
    {
        OrderService service = new OrderService();
        OrderItem sunglasses = new OrderItem(1, "墨镜", 299, 1);
        OrderItem chips = new OrderItem(2, "薯条", 12.3, 3);
        OrderItem exerciseBook = new OrderItem(3, "练习册", 5, 10);



        [TestInitialize()]
        public void init()
        {
            Order order1 = new Order(1, "Customer1", new List<OrderItem> { sunglasses, chips, exerciseBook });
            Order order2 = new Order(2, "Customer2", new List<OrderItem> { exerciseBook, chips });
            Order order3 = new Order(3, "Customer2", new List<OrderItem> { sunglasses });
            service = new OrderService();
            service.AddOrder(order1);
            service.AddOrder(order2);
            service.AddOrder(order3);
        }


        [TestMethod()]
        public void AddOrderTest()
        {
            Order order4 = new Order(4, "Customer2", new List<OrderItem> { chips });
            service.AddOrder(order4);
            Assert.AreEqual(4, service.Orders.Count);
            CollectionAssert.Contains(service.Orders, order4);
        }


        [TestMethod()]
        [ExpectedException(typeof(ApplicationException))]
        public void AddOrderTest2()
        {
            Order order4 = new Order(3, "Customer2", new List<OrderItem> { chips });
            service.AddOrder(order4);
        }


        [TestMethod()]
        public void RemoveOrderTest()
        {
            service.RemoveOrder(3);
            Assert.AreEqual(2, service.Orders.Count);
            service.RemoveOrder(100);
            Assert.AreEqual(2, service.Orders.Count);
        }

        [TestMethod()]
        public void UpdateOrderTest()
        {
            Order order3 = new Order(3, "Customer5", new List<OrderItem> { chips });
            service.UpdateOrder(order3);
            Assert.AreEqual(3, service.Orders.Count);
            Order o = service.GetOrder(3);
            Assert.AreEqual("Customer5", o.Customer);
        }


        [TestMethod()]
        public void QueryOrderByIdTest()
        {
            Order order2 = new Order(2, "Customer2", new List<OrderItem> { sunglasses, chips });
            Order o = service.GetOrder(2);
            Assert.IsNotNull(o);
            Assert.AreEqual(order2, o);
            o = service.GetOrder(4);
            Assert.IsNull(o);
        }

        [TestMethod()]
        public void QueryOrdersByGoodsNameTest()
        {
            Assert.AreEqual(2, service.QueryOrdersByGoodsName("薯片").Count);
            Assert.AreEqual(2, service.QueryOrdersByGoodsName("墨镜").Count);
            Assert.AreEqual(3, service.QueryOrdersByGoodsName("练习册").Count);
            Assert.AreEqual(0, service.QueryOrdersByGoodsName("薯片").Count);
        }

        [TestMethod()]
        public void QueryOrdersByCustomerNameTest()
        {
            Assert.AreEqual(1, service.QueryOrdersByCustomerName("Customer1").Count);
            Assert.AreEqual(2, service.QueryOrdersByCustomerName("Customer2").Count);
            Assert.AreEqual(0, service.QueryOrdersByCustomerName("Customer3").Count);
        }

        [TestMethod()]
        public void ExportTest()
        {
            String file = "temp.xml";
            service.Export(file);
            Assert.IsTrue(File.Exists(file));
            List<String> expectLines = File.ReadLines("expectedOrders.xml").ToList();
            List<String> outputLines = File.ReadLines(file).ToList();
            Assert.AreEqual(expectLines.Count, outputLines.Count);
            for (int i = 0; i < expectLines.Count; i++)
            {
                Assert.AreEqual(expectLines[i].Trim(), outputLines[i].Trim());
            }

        }

        [TestMethod()]
        public void ImportTest1()
        {
            OrderService os = new OrderService();
            os.Import("./expectedOrders.xml");
            Assert.AreEqual(3, os.Orders.Count);

            os.Import("./newOrders.xml");
            Assert.AreEqual(5, os.Orders.Count);
        }


        [TestMethod()]
        [ExpectedException(typeof(FileNotFoundException))]
        public void ImportTest3()
        {
            OrderService os = new OrderService();
            os.Import("./ordersNotExist.xml");
        }

        [TestMethod()]
        [ExpectedException(typeof(InvalidOperationException))]
        public void ImportTest4()
        {
            OrderService os = new OrderService();
            os.Import("./ordersErrorContain.xml");
        }

    }
}
