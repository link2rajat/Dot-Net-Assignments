﻿using System;
using System.Collections;

namespace Assignment2
{
    /// <summary>
    /// IComparer extra implementation to get multiple sorting methodologies.
    /// </summary>
    public class PaymentAmountDesc: IComparer
    {
        int IComparer.Compare(object x, object y)
        {
            Employee first = x as Employee;
            Employee second = y as Employee;
          
            if (first.GetPaymentAmount() > second.GetPaymentAmount()) return -1;
            else if (first.GetPaymentAmount() < second.GetPaymentAmount()) return 1;
            return 0;
        }
    }
}
