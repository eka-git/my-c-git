using System;
//WEEK 5
//写一个订单管理的控制台程序，能够实现添加订单、删除订单、修改订单、查询订单
//（按照订单号、商品名称、客户等字段进行查询）功能。
// 提示：主要的类有Order（订单）、OrderItem（订单明细项），OrderService（订单服务），
//订单数据可以保存在OrderService中一个List中。
//在Program里面可以调用OrderService的方法完成各种订单操作。
//要求：
//（1）使用LINQ语言实现各种查询功能，查询结果按照订单总金额排序返回。
//（2）在订单删除、修改失败时，能够产生异常并显示给客户错误信息。
//（3）作业的订单和订单明细类需要重写Equals方法，确保添加的订单不重复，每个订单的订单明细不重复。
//（4）订单、订单明细、客户、货物等类添加ToString方法，用来显示订单信息。
//（5）OrderService提供排序方法对保存的订单进行排序。默认按照订单号排序，也可以使用Lambda表达式进行自定义排序。
namespace d1
{
    class Program
    {
        static void Main(string[] args)
        {

            AllOrder a = new AllOrder();
            bool judge_ = true;
            while (judge_)
            {
                Console.WriteLine("输入1增加订单，输入2删除订单，输入3查询订单，输入4显示所有订单，输入5根据订单号为订单排序,输入6序列化订单，输入7反序列化订单，输入8退出");
                string choose1 = Console.ReadLine();
                switch (choose1)
                {
                    case "1": a.addOrder(); break;
                    case "2": a.removeOrder(); break;
                    case "3": Console.WriteLine("输入1根据订单金额查询订单，输入2根据客户名查询订单"); 
                        int i = Convert.ToInt32(Console.ReadLine()); a.searchOrder(i); break;
                    case "4": a.ShowOrder(); break;
                    case "5": a.order.Sort(); break;
                    case "6": a.export(); break;
                    case "7": a.import(); break;
                    case "8": judge_ = false; break;
                    default: Console.WriteLine("输入错误"); break;
                }
               
            }

              //  Product p1 = new Product("p01", "苹果", 5);
                //Product p2 = new Product("p02", "橙子", 7);
                //Product p3 = new Product("p03", "梨", 4);

            ////生成客户
            //Client c1 = new Client("c01");

            ////生成订单项
            //OrderItem odi1 = new OrderItem("i01", p1, 1);
            //OrderItem odi2 = new OrderItem("i02", p2, 2);
            //OrderItem odi3 = new OrderItem("i03", p3, 3);
            //OrderItem odi4 = new OrderItem("i04", p2, 4);


            ////生成订单项列表
            //List<OrderItem> l1 = new List<OrderItem>();
            //List<OrderItem> l2 = new List<OrderItem>();
            //List<OrderItem> l3 = new List<OrderItem>();


            //l1.Add(odi1);
            //l1.Add(odi2);
            //l2.Add(odi4);
            //l2.Add(odi3);
            //l3.Add(odi1);

            ////生成订单
            //Order od1 = new Order("o01", c1, "address1", l1);
            //Order od2 = new Order("o02", c1, "address2", l2);
            //Order od3 = new Order("o03", c1, "address3", l3);

            //List<Order> orders = new List<Order>();

            ////生成订单服务对象
            //OrderService ods = new OrderService(orders);

            ////添加订单测试
            //Console.WriteLine("【添加订单测试】");
            //try
            //{
            //    ods.AddOrder(od1);
            //    //ods.AddOrder(od1);
            //    ods.AddOrder(od2);
            //    ods.AddOrder(od3);
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine("添加订单失败！原因："+e.Message);
            //}

            //////删除订单测试
            ////Console.WriteLine("【删除订单测试】");
            ////try
            ////{
            ////    ods.DeleteOrder(od2);
            ////    //ods.DeleteOrder(od3);
            ////}catch(Exception e)
            ////{
            ////    Console.WriteLine("删除订单失败！原因：" + e.Message);
            ////}

            ////查询订单测试
            //Console.WriteLine("【查询订单测试】");

            //IEnumerable<Order> q1 = ods.SearchOrder(1, "o02");
            //foreach (Order od in q1) Console.WriteLine(od);

            //IEnumerable<Order> q2 = ods.SearchOrder(2, "橙子");
            //foreach (Order od in q2) Console.WriteLine(od);


            ////排序测试
            //Console.WriteLine("【排序测试】");
            //ods.SortOrder();
            //foreach (Order od in ods.orders) Console.WriteLine(od);
            //ods.SortOrder((a1, a2) => Convert.ToInt32(a1.TotalPrice - a2.TotalPrice));
            //foreach (Order od in ods.orders) Console.WriteLine(od);

            //try
            //{
            //    ods.Export(".orders.xml");
            //    ods.Import(".orders.xml");
            //}
            //catch (System.IO.FileNotFoundException)
            //{
            //    Console.WriteLine("文件路径不存在！");
            //}
        }
        
      
    }
    }

