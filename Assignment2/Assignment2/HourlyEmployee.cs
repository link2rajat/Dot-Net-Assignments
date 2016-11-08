using System;

namespace Assignment2
{
    public class HourlyEmployee : Employee
    {
        #region data members
        private decimal wage; // wage per hour
        private decimal hours; // hours worked for the week

        // property that gets and sets hourly employee's wage
        public decimal Wage
        {
            get
            {
                return wage;
            }
            set
            {
                if (value >= 0) // validation logic
                    wage = value;
                else
                    throw new ArgumentOutOfRangeException("Wage", value, "Wage must be >= 0");
            }
        }

        // property that gets and sets hourly employee's hours
        public decimal Hours
        {
            get
            {
                return hours;
            }
            set
            {
                if (value >= 0 && value <= 168) // validation logic
                    hours = value;
                else
                    throw new ArgumentOutOfRangeException("Hours", value, "Hours must be >= 0 and <= 168");
            }
        }
        #endregion

       /// <summary>
       /// Parameterised contructor
       /// </summary>
       /// <param name="first"></param>
       /// <param name="last"></param>
       /// <param name="ssn"></param>
       /// <param name="hourlyWage"></param>
       /// <param name="hoursWorked"></param>
        public HourlyEmployee(string first, string last, string ssn, decimal hourlyWage, decimal hoursWorked)
            : base(first, last, ssn)
        {
            Wage = hourlyWage; // validate hourly wage via property
            Hours = hoursWorked; // validate hours worked via property
        }              

        /// <summary>
        /// Calculate GetPaymentAmount; override Employee’s abstract method Earnings
        /// </summary>
        /// <returns></returns>
        public override decimal GetPaymentAmount()
        {
            if (Hours <= 40) // no overtime                          
                return Wage * Hours;
            else
                return (40 * Wage) + ((Hours - 40) * Wage * 1.5M);
        }                                     

        /// <summary>
        /// Return string representation of HourlyEmployee object
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return string.Format("hourly employee: {0} {1}: {2:C}; {3}: {4:F2}", base.ToString(), "hourly wage", Wage, "hours worked", Hours);
        }  
    }
}
