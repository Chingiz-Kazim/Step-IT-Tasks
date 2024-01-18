using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormPRJ
{
    public class Order : Product
    {
        public string? clientName { get; set; }

        public int CountProduct { get; set; }

        public string? NameProduct { get; set; }

        public DateTime dateTime { get; set; }

        public Order()
        {

        }

        public Order(string? client, int countProduct, string? nameProduct, DateTime dateTime)
        {
            clientName = client;
            CountProduct = countProduct;
            NameProduct = nameProduct;
            this.dateTime = dateTime;
        }
    }
}
