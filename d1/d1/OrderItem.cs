using System;
using System.Collections.Generic;
using System.Text;

namespace d1
{
    [Serializable]
    public class OrderItem               //订单明细项
    {
        private string name;
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        private int number;
        public int Number
        {
            get
            {
                return number;
            }
            set
            {
                if (value >= 0) number = value;
                else Console.WriteLine("数量不应该小于0");
            }
        }
        private double price;
        public double Price
        {
            get
            {
                return price;
            }
            set
            {
                price = value;
            }
        }

        public OrderItem()//无参构造函数
        {
            this.Name = string.Empty;
            this.Number = 0;
            this.Price = 0;
        }

        public OrderItem(string name, int number, double price)
        {
            this.name = name;
            this.number = number;
            this.price = price;
        }
        public double getPrice()
        {
            return this.number * this.price;
        }

    }

}
