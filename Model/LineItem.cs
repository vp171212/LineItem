using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineItemList.Model
{
    internal class LineItem
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }
        public double UnitPrice { get; set; }
        public double ItemCost { get { return UnitPrice*Quantity; } }

       
        public LineItem (int id,string name,int quantity,double unitPrice)
        { 
            Id = id;
            Name = name; 
            Quantity = quantity;
            UnitPrice = unitPrice;
        }

        public override string ToString()
        {
            return $"{Name} {UnitPrice} X {Quantity} = {ItemCost}";
        }
    }
}
