using System;

namespace Assignment2
{
    /// <summary>
    /// Derived class inherits CommissionEmployee
    /// </summary>
    public class BasePlusCommissionEmployee : CommissionEmployee
    {
        #region menber variables
        private decimal baseSalary; // base salary per week
        public decimal BaseSalary
        {
            get
            {
                return baseSalary;
            }
            set
            {
                if (value >= 0)
                    baseSalary = value;
                else
                    throw new ArgumentOutOfRangeException("BaseSalary", value, "BaseSalary must be >= 0");
            }
        }
        #endregion

        /// <summary>
        /// Parameterised contructor
        /// </summary>
        /// <param name="first"></param>
        /// <param name="last"></param>
        /// <param name="ssn"></param>
        /// <param name="sales"></param>
        /// <param name="rate"></param>
        /// <param name="salary"></param>
        public BasePlusCommissionEmployee(string first, string last, string ssn, decimal sales, decimal rate, decimal salary)
            : base(first, last, ssn, sales, rate)
        {
            BaseSalary = salary; GetPaymentAmount();
        }    
      
        /// <summary>
        /// Explicit implementation of base class function
        /// </summary>
        /// <returns></returns>
        public override decimal GetPaymentAmount()
        {
            PaymentAmount = (BaseSalary + base.GetPaymentAmount());
            return PaymentAmount;
        }                

       /// <summary>
       /// Custom return of string.
       /// </summary>
       /// <returns></returns>
        public override string ToString()
        {
            return string.Format("base-salaried {0}; base salary: {1:C}", base.ToString(), BaseSalary);
        } 
    }
}
