using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Assign_2
{
    public interface IPayable
    {
        decimal GetPaymentAmount(); // calculate payment; no implementation
    
        String GetSsnNumber();

    } // end interface IPayable
   }
