using System;
using BillManagement.Tools;
using BillManagement.Customers;
namespace BillManagement

{
    class Program
    {
        static void Main(string[] args)
        {
            CustomersList customersList = new CustomersList();
            int choice;
            do
            {
                Console.WriteLine("=================================");
                Console.WriteLine("=====Bill Management=====");
                Console.WriteLine("1. Them khach hang Viet.");
                Console.WriteLine("2. Them khach hang Nuoc ngoai.");
                Console.WriteLine("3. Hien thi danh sach khach hang.");
                Console.WriteLine("4. Xem tong (KW) cua cac khach hang.");
                Console.WriteLine("5. Xem trung binh thanh tien cua khach hang nuoc ngoai.");
                Console.WriteLine("6. Thoat.");

                choice = Tools.Tools.getInt("Nhap lua chon cua ban: ", "Vui long nhap lai.");

                Console.WriteLine("=================================");

                switch (choice)
                {
                    case 1:

                        customersList.AddCustomer(1);
                        Console.WriteLine("Them thanh cong");
                        break;
                    case 2:
                        customersList.AddCustomer(2);
                        Console.WriteLine("Them thanh cong");
                        break;
                    case 3:

                        customersList.Display();
                        break;
                    case 4:
                        customersList.SumKW();
                        break;
                    case 5:
                        customersList.Everage();
                        break;
                    case 6:
                        Console.WriteLine("========Goodbye========");
                        break;
                }

            } while (choice > 0 && choice < 6);
        }
    }
}