﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace d1
{
    [Serializable]
    public class AllOrder : IOrderService    //所有订单
    {
        public List<Order> order = new List<Order>();

        public AllOrder()
        {

        }

        public void ShowOrder()
        {

            foreach (Order a in this.order)
            {
                Console.WriteLine("订单号 客户 总金额");
                Console.WriteLine("----------------------------");
                Console.WriteLine("{0} {1} {2}", a.Id, a.Customer,a.Money);
                a.showOrderItem();
            }
        }
        public void addOrder()          //增加订单
        {
            try
            {
                Console.WriteLine("请输入订单编号：");
                int id = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("请输入客户名称：");
                string customer = Console.ReadLine();
            //    Console.WriteLine("请输入时间：");
           //     string date = Console.ReadLine();
                Order a = new Order(id, customer);
                Console.WriteLine("输入订单项：");
                bool judge = true;
                bool same = false;
                foreach (Order m in this.order)
                {
                    if (m.Equals(a)) same = true;
                }
                if (same) Console.WriteLine("订单号重复");
                else
                {
                    while (judge && !same)
                    {
                        Console.WriteLine("请输入物品名称：");
                        string name = Console.ReadLine();
                        Console.WriteLine("请输入购买数量：");
                        int number = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("请输入单价：");
                        double price = Convert.ToDouble(Console.ReadLine());
                        a.addOrderItem(name, number, price);
                        Console.WriteLine("是否继续添加订单项,否为1，是为2：");
                        string x = Console.ReadLine();
                        if (x == "1") judge = false;
                        else if (x == "2") continue;
                        else if (x != "1" && x != "2")
                        {
                            Exception e = new Exception();
                            throw e;
                        }
                    }
                    order.Add(a);
                    a.getAllPrice();
                    Console.WriteLine("建立成功");
                    Console.WriteLine("-------------------------");
                }
            }
            catch
            {
                Console.WriteLine("输入错误");
            }

        }
        public void removeOrder()           //删除订单
        {
            try
            {
                Console.WriteLine("输入订单号删除订单或相应明细：");
                int id = Convert.ToInt32(Console.ReadLine());
                int index = 0;
                foreach (Order a in this.order)
                {
                    if (a.Id == id) index = this.order.IndexOf(a);
                }
                Console.WriteLine("输入1删除订单，输入2继续删除订单明细");
                int choose = Convert.ToInt32(Console.ReadLine());
                switch (choose)
                {
                    case 1: this.order.RemoveAt(index); Console.WriteLine("删除成功"); Console.WriteLine("-----------------"); break;
                    case 2: this.order[index].showOrderItem(); this.order[index].RemoveOrderItem(); break;
                    default: Console.WriteLine("输入错误"); break;
                }
            }
            catch
            {
                Console.WriteLine("输入错误");
            }

        }

        public void searchOrder(int i)  //查询订单
        {
            try
            {
                switch (i)
                {
                    case 1:
                        int minNum, maxNum;
                        Console.WriteLine("输入要查询的最小金额：");
                        minNum = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("输入要查询的最大金额：");
                        maxNum = Convert.ToInt32(Console.ReadLine());


                        var query1 = from s1 in order
                                     where maxNum > s1.Money
                                     orderby s1.Money
                                     select s1;
                        var query3 = from s3 in query1
                                     where s3.Money > minNum
                                     orderby s3.Money
                                     select s3;

                        List<Order> a1 = query3.ToList();

                        foreach (Order b1 in a1)
                        {
                            Console.WriteLine("订单号 客户 日期 总金额");
                            Console.WriteLine("----------------------------");
                            Console.WriteLine("{0} {1} {2} {3}", b1.Id, b1.Customer, b1.Date, b1.Money);
                            b1.showOrderItem();
                        }
                        break;
                    case 2:

                        Console.WriteLine("输入客户名称：");
                        string name1 = Console.ReadLine();

                        var query2 = from s2 in order
                                     where s2.Customer == name1
                                     orderby s2.Money
                                     select s2;
                        List<Order> a2 = query2.ToList();

                        foreach (Order b2 in a2)
                        {
                            Console.WriteLine("订单号 客户 日期 总金额");
                            Console.WriteLine("----------------------------");
                            Console.WriteLine("{0} {1} {2} {3}", b2.Id, b2.Customer, b2.Date, b2.Money);
                            b2.showOrderItem();
                        }
                        break;
                    default: Console.WriteLine("输入错误"); break;

                }
            }
            catch
            {
                Console.WriteLine("输入错误");
            }
        }


    }
}
