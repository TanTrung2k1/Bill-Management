using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BillManagement.Tools;

namespace BillManagement.Customers
{
    internal class ForeignCustomers : Customer
    {
        public string Quoctich { get; set; }

        public ForeignCustomers()
        {
        }
        public ForeignCustomers(int id, string name, string address, int kw, double unitPrice, double price, string quoctich) : base(id, name, address, kw, unitPrice, price)
        {
            Quoctich = quoctich;
        }
        public override void Input()
        {
            base.Input();
            Quoctich = Tools.Tools.getString("Nhap quoc tich: ", "Vui long nhap lai.");
        }
        public double Money()
        {
            return Kw * UnitPrice;
        }
        public override string? ToString()
        {
            return "Khach hang nuoc ngoai: " + " | ID: " + base.ToString() + " | Quoc tich: " + Quoctich;
        }
    }
}
