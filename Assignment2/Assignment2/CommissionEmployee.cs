using System;

namespace Assignment2
{
    /// <summary>
    /// CommissionEmployee class implementation; inherits Employee base class.
    /// </summary>
    public class CommissionEmployee: Employee
    {
        #region members variables/properties
        private decimal grossSales; // gross weekly sales
        private decimal commissionRate; // commission percentage
        public decimal GrossSales
        {
            get
            {
                return grossSales;
            } 
            set
            {
                if (value >= 0)
                    grossSales = value;
                else
                    throw new ArgumentOutOfRangeException("GrossSales", value, "GrossSales must be >= 0");
            } 
        } 

      
        public decimal CommissionRate
        {
            get
            {
                return commissionRate;
            }
            set
            {
                if (value > 0 && value < 1)
                    commissionRate = value;
                else
                    throw new ArgumentOutOfRangeException("CommissionRate", value, "CommissionRate must be > 0 and < 1");
            } 
        }

        #endregion

        /// <summary>
       /// Parameterised Contructor
       /// </summary>
       /// <param name="first"></param>
       /// <param name="last"></param>
       /// <param name="ssn"></param>
       /// <param name="sales"></param>
       /// <param name="rate"></param>
        public CommissionEmployee(string first, string last, string ssn, decimal sales, decimal rate)
            : base(first, last, ssn)
        {
            GrossSales = sales; // validate gross sales via property
            CommissionRate = rate; // validate commission rate via property
        } 

      /// <summary>
      /// Base class function override.
      /// </summary>
      /// <returns></returns>
        public override decimal GetPaymentAmount()
        {
            return CommissionRate * GrossSales;
        }               

      
        /// <summary>
        /// Custom formatted string return.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return string.Format("{0}: {1} {2}: {3:C} {4}: {5:F2}", "commission employee", base.ToString(), "gross sales", GrossSales, "commission rate", CommissionRate);
        } 
    }
}
