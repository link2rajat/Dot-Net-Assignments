using System;
using System.ComponentModel;

namespace Assignment2
{
    public abstract class Employee : IPayable, IComparable,INotifyPropertyChanged
    {        
        #region member variables

        private decimal paymentAmount = 0;

        public decimal PaymentAmount
        {
            get { return paymentAmount; }
            set { paymentAmount = value; RaisePropertyChanged("PaymentAmount"); }
        }


        // read-only property that gets employee's first name   
        public string FirstName 
        { 
            get; private set; 
        }

        // read-only property that gets employee's last name
        public string LastName 
        { 
            get; private set; 
        }

        // read-only property that gets employee's social security number
        public string SocialSecurityNumber 
        { 
            get; private set; 
        }
        #endregion

        /// <summary>
        /// Parameterised Contructor
        /// </summary>
        /// <param name="first"></param>
        /// <param name="last"></param>
        /// <param name="ssn"></param>
        public Employee(string first, string last, string ssn)
        {            
            FirstName = first;
            LastName = last;
            SocialSecurityNumber = ssn;
        }

        /// <summary>
        /// Custom string return
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return string.Format("{0} {1} social security number: {2}", FirstName, LastName, SocialSecurityNumber);
        }

        /// <summary>
        /// Get function to obtain last name
        /// </summary>
        /// <returns></returns>
        public String GetLastName()
        {
            return LastName;
        }

        /// <summary>
        /// Get function to obtain SocialSecurityNumber
        /// </summary>
        /// <returns></returns>
        public String GetSsnNumber()
        {            
            return SocialSecurityNumber;
        }
        public abstract decimal GetPaymentAmount();
        public event PropertyChangedEventHandler PropertyChanged;
        public void RaisePropertyChanged(string propertyName)    //don't set to private.
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }

        /// <summary>
        /// IComparable implementation. Important.
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public int CompareTo(object obj)
        {
            Employee e = (Employee)obj;
            if (String.Compare(this.LastName, e.LastName) == 0)
                return String.Compare(this.SocialSecurityNumber, e.SocialSecurityNumber);
            else
                return String.Compare(this.LastName, e.LastName);
        }


        internal static int CompareSSN(object obj1, object obj2, bool isAscending)
        {
            Employee first = obj1 as Employee;
            Employee second = obj2 as Employee;
            if (isAscending)
                return String.Compare(first.GetSsnNumber(), second.GetSsnNumber());               
            else
                return String.Compare(second.GetSsnNumber(), first.GetSsnNumber());
        }
    }
}

