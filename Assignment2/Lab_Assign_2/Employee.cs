using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Assign_2
{
    public abstract class Employee : IPayable, IComparable
    {
        // read-only property that gets employee's first name
        public string FirstName { get; private set; }

        // read-only property that gets employee's last name
        public string LastName { get; private set; }

        internal static int CompareSSN(object obj1, object obj2,bool ascen)
        {
            Employee one = obj1 as Employee;
            Employee two = obj2 as Employee;
            if (ascen)
                return String.Compare(one.GetSsnNumber(), two.GetSsnNumber());
            else
                return String.Compare(two.GetSsnNumber(), one.GetSsnNumber());
        }

        // read-only property that gets employee's social security number
        public string SocialSecurityNumber { get; private set; }

        // three-parameter constructor
        public Employee(string first, string last, string ssn)
        {
            FirstName = first;
            LastName = last;
            SocialSecurityNumber = ssn;
        } // end three-parameter Employee constructor

        // return string representation of Employee object, using properties
        public override string ToString()
        {
            return string.Format("{0} {1}\nsocial security number: {2}",
               FirstName, LastName, SocialSecurityNumber);
        } // end method ToString

        
        public abstract decimal GetPaymentAmount(); //Abstarct method


        public String GetSsnNumber()
        {
            return SocialSecurityNumber;
        }
        //Default impementation of Icamparable to sort Lastname in ascending order
        int IComparable.CompareTo(object C)
        {
            Employee temp = (Employee)C;
            if (!(this.LastName.Equals(temp.LastName)))
            {
                return this.LastName.CompareTo(temp.LastName);
            }
            else 
            {
                return string.Compare(this.SocialSecurityNumber, temp.SocialSecurityNumber);
            }
            
    }

    //IComparer to sort payment amount in descending order
        private class sortPaymentInDescending : IComparer
        {
            public int Compare(object a, object b)
            {
                Employee e1 = (Employee)a;
                Employee e2 = (Employee)b;

                if (e1.GetPaymentAmount() < e2.GetPaymentAmount())
                    return 1;

                if (e1.GetPaymentAmount() > e2.GetPaymentAmount())
                    return -1;

                else
                    return 0;

            }
        } // end abstract class Employee

        public static IComparer sortPaymentDescending()
        {
            return (IComparer)new sortPaymentInDescending();
        }
    }
}