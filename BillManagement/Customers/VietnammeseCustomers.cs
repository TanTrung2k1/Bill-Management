using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BillManagement.Tools;

namespace BillManagement.Customers
{
    internal class VietnammeseCustomers : Customer
    {
        private int loaiKH { get; set; }
        private int DinhMuc { get; set; }

        public VietnammeseCustomers()
        {
        }
        public VietnammeseCustomers(int id, string name, string address, int kw, double unitPrice, double price, int loaikh, int dinhmuc) : base(id, name, address, kw, unitPrice, price)
        {
            loaiKH = loaikh;
            DinhMuc = dinhmuc;
        }
        public override void Input()
        {
            base.Input();
            loaiKH = Tools.Tools.getInt("Loai khach hang (1. Sinh hoat. -- 2. Kinh doanh. -- 3. San xuat): ", "Vui long nhap lai.");
            DinhMuc = Tools.Tools.getInt("Dinh muc: ", "Vui long nhap lai.");
        }

        public double Money()
        {
            if (Kw <= DinhMuc)
            {
                return UnitPrice * Kw;
            }
            else
            {
                return DinhMuc * UnitPrice + (Kw - DinhMuc) * UnitPrice * 2.5;
            }
        }
        public override string? ToString()
        {
            string temp;
            if (loaiKH == 1)
            {
                temp = "Sinh hoat";
            }
            else if (loaiKH == 2)
            {
                temp = "Kinh doanh";
            }
            else
            {
                temp = "San suat";
            }
            return "Khach hang Viet: " + " | ID: " + base.ToString() + " | Loai: " + temp + " | Dinh muc: " + DinhMuc;
        }
    }
}
