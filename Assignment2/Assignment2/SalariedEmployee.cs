using System;

namespace Assignment2
{
    /// <summary>
    /// Salaried Employee derived class. Implements Employee as the base class.
    /// </summary>
    public class SalariedEmployee : Employee
    {
        #region data members
        private decimal weeklySalary;
        public decimal WeeklySalary
        {
            get
            {
                return weeklySalary;
            }
            set
            {
                if (value >= 0) // validation logic
                    weeklySalary = value;
                else
                    throw new ArgumentOutOfRangeException("WeeklySalary", value, "WeeklySalary must be >= 0");
            }
        }
        #endregion

        /// <summary>
        /// Parameterised constructor.
        /// </summary>
        /// <param name="first"></param>
        /// <param name="last"></param>
        /// <param name="ssn"></param>
        /// <param name="salary"></param>
        public SalariedEmployee(string first, string last, string ssn, decimal salary)
            : base(first, last, ssn)
        {
            WeeklySalary = salary; 
        }       
        
        /// <summary>
        /// Calculate earnings; override abstract method Earnings in Employee
        /// </summary>
        /// <returns></returns>
        public override decimal GetPaymentAmount()
        {
            return WeeklySalary;
        }        

       /// <summary>
       /// Return string representation of SalariedEmployee object
       /// </summary>
       /// <returns></returns>
        public override string ToString()
        {
            return string.Format("salaried employee: {0}\n{1}: {2:C}", base.ToString(), "weekly salary", WeeklySalary);
        } 
    }
}
