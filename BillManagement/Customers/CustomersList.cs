using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BillManagement.Customers
{
    internal class CustomersList
    {
        private Customer[] customer = new Customer[100];
        private int Count, sum1 = 0, sum2 = 0, dem = 0;
        private double sumMoney = 0;

        public CustomersList()
        {
            Count = 1;
            for (int i = 1; i < 100; i++)
            {
                customer[i] = new Customer();
            }
        }
        public void AddCustomer(int temp)
        {
            if (Count > 100)
            {
                Console.WriteLine("Bo nho day.");
            }
            else
            {
                if (temp == 1)
                {
                    customer[Count] = new VietnammeseCustomers();
                    VietnammeseCustomers vietnammeseCustomers = new VietnammeseCustomers();
                    vietnammeseCustomers.Input();
                    vietnammeseCustomers.Id = Count;
                    vietnammeseCustomers.Price = vietnammeseCustomers.Money();
                    customer[Count] = vietnammeseCustomers;
                    sum1 += vietnammeseCustomers.Kw;
                }
                else
                {
                    customer[Count] = new ForeignCustomers();
                    ForeignCustomers foreignCustomers = new ForeignCustomers();
                    foreignCustomers.Input();
                    foreignCustomers.Id = Count;
                    foreignCustomers.Price = foreignCustomers.Money();
                    customer[Count] = foreignCustomers;
                    sum2 += foreignCustomers.Kw;
                    sumMoney += foreignCustomers.Price;
                    dem++;
                }
                Count++;
            }
        }
        public void Display()
        {
            for (int i = 1; i < Count; i++)
            {
                Console.WriteLine(customer[i].ToString());
            }
        }

        public void SumKW()
        {
            Console.WriteLine("Tong so luong (KW) cua khach hang Viet: " + sum1);
            Console.WriteLine("Tong so luong (KW) cua khach hang nuoc ngoai: " + sum2);
        }
        public void Everage()
        {
            Console.WriteLine("Trung binh thanh tien cua khach hang nuoc ngoai: " + (sumMoney / dem));
        }
    }
}
