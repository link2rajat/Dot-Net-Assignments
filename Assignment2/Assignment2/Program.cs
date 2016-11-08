using Assignment2;
using System;

/// <summary>
/// Main class, this gets fired at the first time.
/// </summary>
public class PayrollSystemTest
{
    /// <summary>
    /// Define a delegate that points to explicit sort function (SelectionSort())
    /// </summary>
    /// <param name="payableObjects"></param>
    public delegate int SortSSNDelegate(object obj1, object obj2, bool isAscending);
    

    public static void Main(string[] args)
    {
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
           salariedEmployee, salariedEmployee.GetPaymentAmount());
        Console.WriteLine("{0}\nearned: {1:C}\n",
           hourlyEmployee, hourlyEmployee.GetPaymentAmount());
        Console.WriteLine("{0}\nearned: {1:C}\n",
           commissionEmployee, commissionEmployee.GetPaymentAmount());
        Console.WriteLine("{0}\nearned: {1:C}\n",
           basePlusCommissionEmployee,
           basePlusCommissionEmployee.GetPaymentAmount());

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
               "earned {0:C}\n", currentEmployee.GetPaymentAmount());
        } // end foreach

        //get type name of each object in employees array
        for (int j = 0; j < employees.Length; j++)
            Console.WriteLine("Employee {0} is a {1}", j,
               employees[j].GetType());

        Console.WriteLine("-------------------------------------------------");
           
        // create derived class objects
        IPayable[] payableObjects = new IPayable[8];
        payableObjects[0] = new SalariedEmployee("John", "Smith", "111-11-1111", 700M);
        payableObjects[1] = new SalariedEmployee("Antonio", "Smith", "555-55-5555", 800M);
        payableObjects[2] = new SalariedEmployee("Victor", "Smith", "444-44-4444", 600M);
        payableObjects[3] = new HourlyEmployee("Karen", "Price", "222-22-2222", 16.75M, 40M);
        payableObjects[4] = new HourlyEmployee("Ruben", "Zamora", "666-66-6666", 20.00M, 40M);
        payableObjects[5] = new CommissionEmployee("Sue", "Jones", "333-33-3333", 10000M, .06M);
        payableObjects[6] = new BasePlusCommissionEmployee("Bob", "Lewis", "777-77-7777", 5000M, .04M, 300M);
        payableObjects[7] = new BasePlusCommissionEmployee("Lee", "Duarte", "888-88-888", 5000M, .04M, 300M);

        SortSSNDelegate sortDelegate = new SortSSNDelegate(Employee.CompareSSN);  //delegate points to method.
        bool key = true;
        while (key)
        {
            Console.WriteLine(Environment.NewLine + "1.Sort last name in ascending order using IComparable");
            Console.WriteLine("2.Sort pay amount in descending order using IComparer");
            Console.WriteLine("3.Sort by social security number in asc order using selection sort & DELEGATE");
            Console.WriteLine("Press 4 anytime to Exit." + Environment.NewLine);          
            int value = Int32.Parse(Console.ReadLine());
            switch (value)
            {
                case 1: Console.WriteLine("<Sorting Last Name using IComparABLE>");
                    Array.Sort(payableObjects);
                    PrintArrayElements(payableObjects);      
                    break;
                case 2: Console.WriteLine("\n\n<Sort payment amount in desc using ICompaRER>");
                    Array.Sort(payableObjects, new PaymentAmountDesc());
                    PrintArrayElements(payableObjects);
                    break;
                case 3: Console.WriteLine("\n\n<Sort based on SSN in Ascending order>");
                    SelectionSortMethod(payableObjects as object, sortDelegate,true);    // Call method. 'true' for ascending.               
                    PrintArrayElements(payableObjects);
                    break;
                default: key = false;
                    break;
            }
        } // end Main              
    }

    private static void PrintArrayElements(IPayable[] payableObjects)
    {
        foreach (IPayable i in payableObjects)
        {
            Console.WriteLine(i.GetLastName() + "\t" 
                + i.GetSsnNumber() + "\t" + i.GetPaymentAmount());
        }
    }

    /// <summary>
    /// Method to be called for calling for sorting SSN.
    /// </summary>
    /// <param name="payableObjects"></param>
    /// <param name="sortDelegate"></param>
    /// <param name="isAscending"></param>
    public static void SelectionSortMethod(object payableObjects, SortSSNDelegate sortDelegate, bool isAscending)
    {
        IPayable[] payableArray = null;
        if (payableObjects is IPayable[])
            payableArray = payableObjects as IPayable[];       
      
        for (int i = 0; i < payableArray.Length; i++)
        {
            int position = i;
            for (int j = i + 1; j < payableArray.Length; j++)
            {
                if (sortDelegate(payableArray[position], payableArray[j], isAscending) > 0) // call delegate..
                    position = j;
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