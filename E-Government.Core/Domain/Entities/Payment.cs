﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Government.Core.Domain.Entities
{
    public class Payment
    {
        public int Id { get; set; }
        public DateTime PaymentDate { get; set; } // تاريخ الدفع
        public decimal Amount { get; set; } // المبلغ المدفوع
        public string TransactionId { get; set; } // رقم المعاملة

        // علاقته بالفاتورة
        public int ? BillId { get; set; }
        public Bill Bill { get; set; }

        // علاقته بالزبون
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
    }
}
