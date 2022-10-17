using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BillManagement.Tools;

namespace BillManagement.Customers
{
    internal class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string Address { get; set; }

        public int Kw { get; set; }

        public double UnitPrice { get; set; }
        public double Price { get; set; }

        public Customer()
        {
        }

        public Customer(int id, string name, string address, int kw, double unitPrice, double price)
        {
            Id = id;
            Name = name;
            Address = address;
            Kw = kw;
            UnitPrice = unitPrice;
            Price = price;
        }


        public virtual void Input()
        {
            Name = Tools.Tools.getString("Nhap ten khach hang: ", "Vui long nhap lai.");          
            Address = Tools.Tools.getString("Nhap dia chi khach hang: ", "Vui long nhap lai.");            
            Kw = Tools.Tools.getInt("Nhap so (KW): ", "Vui long nhap lai.");            
            UnitPrice = Tools.Tools.getDouble("Nhap don gia: ", "Vui long nhap lai.");
        }

        public override string? ToString()
        {
            return this.Id + " | Ten: " + this.Name + " | Dia chi: " + this.Address + " | So KW: " + this.Kw + " | Don gia: " + this.UnitPrice;
        }


    }
}
