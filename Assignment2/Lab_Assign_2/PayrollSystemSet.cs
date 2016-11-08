using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Assign_2
{
    public delegate int SortingDelegate(object obj1, object obj2, bool ascen); // this is the delegate declaration
    public class PayrollSystemTest
    {
        public static void Main(string[] args)
        {
            // create derived class objects
            SalariedEmployee salariedEmployee =
               new SalariedEmployee("John", "Smith", "111-11-1111", 800.00M);
            HourlyEmployee hourlyEmployee =
               new HourlyEmployee("Karen", "Price",
               "222-22-2222", 16.75M, 40.0M);
            CommissionEmployee commissionEmployee =
               new CommissionEmployee("Sue", "Jones",
               "333-33-3333", 10000.00M, .06M);
            BasePlusCommissionEmployee basePlusCommissionEmployee =
               new BasePlusCommissionEmployee("Bob", "Lewis",
               "444-44-4444", 5000.00M, .04M, 300.00M);
           
            Console.WriteLine("Employees processed individually:\n");

            Console.WriteLine("{0}\nearned: {1:C}\n",
               salariedEmployee, salariedEmployee.GetPaymentAmount()); //Changes
            Console.WriteLine("{0}\nearned: {1:C}\n",
               hourlyEmployee, hourlyEmployee.GetPaymentAmount()); //changes
            Console.WriteLine("{0}\nearned: {1:C}\n",
               commissionEmployee, commissionEmployee.GetPaymentAmount()); //Changes
            Console.WriteLine("{0}\nearned: {1:C}\n",
               basePlusCommissionEmployee,
               basePlusCommissionEmployee.GetPaymentAmount()); //Changes
            // create four-element Employee array
            Employee[] employees = new Employee[4];

            // initialize array with Employees of derived types
            employees[0] = salariedEmployee;
            employees[1] = hourlyEmployee;
            employees[2] = commissionEmployee;
            employees[3] = basePlusCommissionEmployee;

            Console.WriteLine("Employees processed polymorphically:\n");

            // generically process each element in array employees
            foreach (Employee currentEmployee in employees)
            {
                Console.WriteLine(currentEmployee); // invokes ToString

                // determine whether element is a BasePlusCommissionEmployee
                if (currentEmployee is BasePlusCommissionEmployee)
                {
                    // downcast Employee reference to 
                    // BasePlusCommissionEmployee reference
                    BasePlusCommissionEmployee employee =
                       (BasePlusCommissionEmployee)currentEmployee;

                    employee.BaseSalary *= 1.10M;
                    Console.WriteLine(
                       "new base salary with 10% increase is: {0:C}",
                       employee.BaseSalary);
                } // end if

                Console.WriteLine(
                   "earned {0:C}\n", currentEmployee.GetPaymentAmount()); //Changes
            } // end foreach

            // Getting type of each object in employees array
            for (int j = 0; j < employees.Length; j++)
                Console.WriteLine("Employee {0} is a {1}", j,
                   employees[j].GetType());
            IPayable[] payableObjects = new IPayable[8];
            payableObjects[0] = new SalariedEmployee("John", "Smith", "111-11-1111", 700M);
            payableObjects[1] = new SalariedEmployee("Antonio", "Smith", "555-55-5555", 800M);
            payableObjects[2] = new SalariedEmployee("Victor", "Smith", "444-44-4444", 600M);
            payableObjects[3] = new HourlyEmployee("Karen", "Price", "222-22-2222", 16.75M, 40M);
            payableObjects[4] = new HourlyEmployee("Ruben", "Zamora", "666-66-6666", 20.00M, 40M);
            payableObjects[5] = new CommissionEmployee("Sue", "Jones", "333-33-3333", 10000M, .06M);
            payableObjects[6] = new BasePlusCommissionEmployee("Bob", "Lewis", "777-77-7777", 5000M, .04M, 300M);
            payableObjects[7] = new BasePlusCommissionEmployee("Lee", "Duarte", "888-88-888", 5000M, .04M, 300M);

            Console.WriteLine(
           "Invoices and Employees processed polymorphically:\n");
          
            //Instantiating Delegate and calling SelectionSort method
            //through EMployee Class
            SortingDelegate sortDelegate = new SortingDelegate(Employee.CompareSSN); 

            String selection = "";
            while (true)
            {
                displayMenu();
                selection = Console.ReadLine();
                switch (selection)
                {
                    
                    case "1":
                        Console.WriteLine("Sorted by last name, ascending:\n");
                        Array.Sort(payableObjects);
                        printPayable(payableObjects);
                        break;
                    
                    case "2":
                        Console.WriteLine("Sorted by payment amount, descending:\n");
                        Array.Sort(payableObjects, Employee.sortPaymentDescending());
                        printPayable(payableObjects);
                        break;

                    case "3":
                        Console.WriteLine("\n\n<Sort based on SSN in ascending order>");
                        SelectionSortMethod(payableObjects as object, sortDelegate, SortType.Ascending);
                        printPayable(payableObjects);
                       
                        break;

                    case "4":
                        break;
                    default:
                        break;
                }

            }
        } // end Main


        public static void displayMenu()
        { 
            Console.WriteLine("1. Sort last name in ascending order\n" +
                                "2. Sort by pay amount in descending order\n" +
                                "3. Sort SSN in ascending order using delegate\n" +
                                "4. Quit.\n");
        }

        //method to print details of Employee type using IPayable object
        public static void printPayable(IPayable[] payableObjects)
        {
            // generically process each element in array payableObjects
            foreach (var currentPayable in payableObjects)
            {
                Console.WriteLine(currentPayable.ToString() + "\n" + "amount: " + currentPayable.GetPaymentAmount() + "\n");
            } // end foreach
        }

        public static void SelectionSortMethod(object payableObjects, SortingDelegate sortDelegate, SortType sortOrder) //Sorting SSN in ascending order 
        {
            //SortingDelegate sort = new SortingDelegate(Employee.CompareSSN);
            IPayable[] payableArray = payableObjects as IPayable[];
            for (int i = 0; i < payableArray.Length; i++)
            {
                int position = i;
                for (int j = i + 1; j < payableArray.Length; j++)
                {
                    if (SortType.Ascending == sortOrder)
                    {
                        if (sortDelegate(payableArray[position], payableArray[j], true) > 0)
                            position = j;
                    }
                    else if (SortType.Descending == sortOrder)
                    {
                        if (sortDelegate(payableArray[position], payableArray[j], false) < 0)
                            position = j;
                    }
                }
                if (position != i)
                {
                    IPayable temp = payableArray[i];
                    payableArray[i] = payableArray[position];
                    payableArray[position] = temp;
                }
            }
        }
    }


   
} // end class PayrollSystemTest


