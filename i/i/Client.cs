using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace i
{
    class Client
    {
      /** static void Main(string[] args)
        {

            #region //示例（订单明细）条目，四个测试条目
            //OrderDetails od1 = new OrderDetails
            //{
            //    Brand = Products.Apple,
            //    ProductsNum = 2,
            //    Price=8800,
            //};
            //OrderDetails od2 = new OrderDetails
            //{
            //    Brand = Products.HUAWEI,
            //    ProductsNum = 1,
            //    Price=3200,
            //};
            //OrderDetails od3 = new OrderDetails
            //{
            //    Brand = Products.OPPO,
            //    ProductsNum = 3,
            //    Price=3500,
            //};
            //OrderDetails od4 = new OrderDetails
            //{
            //    Brand = Products.SAMSUNG,
            //    ProductsNum = 2,
            //    Price=3800,
            //};
            #endregion

            #region //示例订单

            List<OrderDetail> od1 = new List<OrderDetail>() {
                 new OrderDetail(Products.Apple, 3, 8800),
           new OrderDetail(Products.HUAWEI, 2, 2800),
        };
            List<OrderDetail> od2 = new List<OrderDetail>() {
               new OrderDetail(Products.OPPO, 1, 3200),
            new OrderDetail(Products.SAMSUNG, 4, 4800),
        };

            List<OrderDetail> od3 = new List<OrderDetail>() {
             new OrderDetail(Products.vivo, 1, 3000),
        };
            List<OrderDetail> od4 = new List<OrderDetail>() {
            new OrderDetail(Products.XIAOMI, 10, 2500)
        };
            Order order1 = new Order("Bob", "+86-10-87654321", od1);

            Order order2 = new Order("Tom", "+86-10-87654321", od2);

            Order order3 = new Order("Alice", "+86-10-87654321", od3);

            Order order4 = new Order("Alex", "+86-10-87654321", od4);

            #endregion

            //订单服务,添加了两个订单
            // OrderService.orders = new List<Order>();
            OrderService orderService = new OrderService();
            orderService.AddOrder(order1);
            orderService.AddOrder(order2);
            orderService.AddOrder(order3);
            orderService.AddOrder(order4);

            //orderService.Export(@"D:\orderService.xml");
            orderService.xslT("D:\\orderService");
            // OrderService os= OrderService.Import(@"D:\orderService.xml");
            //try
            //{
            //    orderService.FindOrderByOrderNum("20181004001");


            //    orderService.FindOrderByClientName("Tom");

            //    orderService.FindOrderByProductBrand(Products.SAMSUNG);

            //    orderService.FindLargeOrder();
            //}
            //catch (DataException e)
            //{
            //    Console.WriteLine(e.Message);
            //}
        }*/
    }
}
