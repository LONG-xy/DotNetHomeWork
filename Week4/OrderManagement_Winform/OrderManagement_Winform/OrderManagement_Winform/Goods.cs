using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManagement_Winform
{
    class Good
    {
        public string name { get; set; }
        public double price { get; set; }
    }

    class Goods
    {
        public List<Good> GoodsList = new List<Good>();

        public Goods()
        {
            InitializeGoods();
        }

        public void InitializeGoods()
        {
            GoodsList.Add(new Good() { name = "苹果", price = 12.5});
            GoodsList.Add(new Good() { name = "香蕉", price = 5.5 });
            GoodsList.Add(new Good() { name = "红葡萄", price = 28.6 });
            GoodsList.Add(new Good() { name = "橙子", price = 23.7 });
            GoodsList.Add(new Good() { name = "百香果", price = 2.9 });
        }

        public bool GoodExists(string goodname)
        {
            foreach (var g in GoodsList)
            {
                if (g.name == goodname)
                {
                    return true;
                }
            }
            return false;
        }

        public double GetPrice(string goodname)
        {
            foreach (var g in GoodsList)
            {
                if (g.name == goodname)
                {
                    return g.price;
                }
            }
            return 0;
        }
    }

    public class GoodNotExistsException : ApplicationException
    {
        public GoodNotExistsException(string message) : base(message)
        {
        }
    }
}