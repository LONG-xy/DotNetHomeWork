
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    namespace OrderManagement
    {
        public class OrderItem
        {

            public uint Index { get; set; }

            public String CommodityName { get; set; }

            public uint Quantity { get; set; }

            public double Price { get; set; }

            public OrderItem() { }

            public OrderItem(uint index, String commodityName, double price, uint quantity)
            {
                this.Index = index;
                this.CommodityName = commodityName;
                this.Price = price;
                this.Quantity = quantity;
            }

            public double TotalPrice
            {
                get => Price * Quantity;
            }

            public override string ToString()
            {
                return $"[{Index}号订单,商品:{CommodityName},重量:{Quantity},总价:{TotalPrice}]";
            }

            public override bool Equals(object obj)
            {
                var item = obj as OrderItem;
                return item != null &&
                       CommodityName == item.CommodityName;
            }

            public override int GetHashCode()
            {
                var hashCode = -2127770830;
                hashCode = hashCode * -1521134295 + Index.GetHashCode();
                hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(CommodityName);
                hashCode = hashCode * -1521134295 + Quantity.GetHashCode();
                return hashCode;
            }
        }
    }
