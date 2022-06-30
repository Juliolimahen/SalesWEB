using System;
using System.Collections.Generic;
using SalesWebMvc.Models.Enums;

namespace SalesWebMvc.Models
{
    public class SalesRecord
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public double amount { get; set; }
        public SaleStatus Status { get; set; }
        public Seller Seller { get; set; }

        public SalesRecord()
        {
        }

        public SalesRecord( DateTime date, double amount, SaleStatus status, Seller seller)
        {
            Date = date;
            this.amount = amount;
            Status = status;
            Seller = seller;
        }
    }
}