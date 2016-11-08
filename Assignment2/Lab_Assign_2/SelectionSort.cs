
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Assign_2
{
    public enum SortType
    {
        Ascending = 0,
        Descending = 1
    }

    public static class SelectionSortSSN
    {


        //public static void SelectionSort(object payableObjects, SortingDelegate sortDelegate, SortType sortOrder) //Sorting SSN in ascending order 
        //{
        //    //SortingDelegate sort = new SortingDelegate(Employee.CompareSSN);
        //    IPayable[] payableArray = payableObjects as IPayable[];
        //    for (int i = 0; i < payableArray.Length; i++)
        //    {
        //        int position = i;
        //        for (int j = i + 1; j < payableArray.Length; j++)
        //        {
        //            if (sortDelegate(payableArray[position], payableArray[j], true) > 0)
        //                position = j;
        //        }                        
        //           if (position != i)
        //            {
        //                IPayable temp = payableArray[i];
        //                payableArray[i] = payableArray[position];
        //                payableArray[position] = temp;
        //            }
        //        }
        //    }
        //}
    }

    