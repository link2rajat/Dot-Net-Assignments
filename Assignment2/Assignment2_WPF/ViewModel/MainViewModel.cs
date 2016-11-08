using Assignment2;
using Assignment2_WPF.Commands;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Assignment2_WPF.ViewModel
{
    public enum SortingOrder
    {
        [Description("Ascending")]
        Ascending = 1,
        [Description("Descending")]
        Descending = 2
    }
    public class MainViewModel:INotifyPropertyChanged
    {
        #region data members/properties        
        private ICommand sortByLastNameASC;
        private ICommand sortByPayAmountDesc;
        private ICommand sortBySSNDelASC;     
        private ICommand resetGrid;
        private ObservableCollection<Employee> sortedList;
        private List<KeyValuePair<string, SortingOrder>> sortingList;
        private SortingOrder selectedSorting = SortingOrder.Ascending; // Default is set to 'Ascending'
        public SortingOrder SelectedSorting
        {
            get { return selectedSorting; }
            set
            {
                selectedSorting = value;
                RaisePropertyChanged("SelectedSorting");
            }
        }
        public ICommand ResetGrid
        {
            get { return resetGrid; }
        }
        public ICommand SortByLastNameASC
        {
            get { return sortByLastNameASC; }           
        }
     
        public ICommand SortByPayAmountDesc
        {
            get { return sortByPayAmountDesc; }
        }       

        public ICommand SortBySSNDelASC
        {
            get { return sortBySSNDelASC; }
        }      
      
        public ObservableCollection<Employee> SortedList
        {
            get { return sortedList; }
            set { sortedList = value; }
        }
        public delegate int SortSSNDelegate(object obj1, object obj2, bool isAscending);
        IPayable[] payableObjects = new IPayable[32];
        public SortSSNDelegate sortDelegate = null;
       
        public List<KeyValuePair<string, SortingOrder>> SortingList
        {
            get
            {
                if (sortingList == null)
                {
                    sortingList = new List<KeyValuePair<string, SortingOrder>>();
                    foreach (SortingOrder level in Enum.GetValues(typeof(SortingOrder)))
                    {
                        string description;
                        FieldInfo fieldInfo = level.GetType().GetField(level.ToString());
                        DescriptionAttribute[] attributes = (DescriptionAttribute[])fieldInfo.GetCustomAttributes(typeof(DescriptionAttribute), false);
                        if (attributes != null && attributes.Length > 0) { description = attributes[0].Description; }
                        else { description = string.Empty; }
                        KeyValuePair<string, SortingOrder> TypeKeyValue =
                        new KeyValuePair<string, SortingOrder>(description, level);
                        sortingList.Add(TypeKeyValue);
                    }
                }
                return sortingList;
            }
        }
       
        public event PropertyChangedEventHandler PropertyChanged;
        public void RaisePropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null) handler(this, new PropertyChangedEventArgs(propertyName));
        }

        #endregion
        public MainViewModel()
        {
            SortedList = new ObservableCollection<Employee>();
            payableObjects = new IPayable[16];
            InitGrid();
            sortByLastNameASC = new DelegateCommand((p) => SortByLastNameASCFxn(p));
            sortByPayAmountDesc = new DelegateCommand((p) => SortByPayAmountDescFxn(p));
            sortBySSNDelASC = new DelegateCommand((p) => SortBySSNDelASCFxn(p));
            resetGrid = new DelegateCommand((p) => ResetGridFxn(p));
            sortDelegate = new SortSSNDelegate(Employee.CompareSSN);  //delegate points to method.
            ReloadListCollection(payableObjects);            
        }

        void InitGrid()
        {
            payableObjects[0] = new SalariedEmployee("John", "Smith", "111-11-1111", 700M);
            payableObjects[1] = new SalariedEmployee("Antonio", "Smith", "555-55-5555", 800M);
            payableObjects[2] = new SalariedEmployee("Victor", "Smith", "444-44-4444", 600M);
            payableObjects[3] = new HourlyEmployee("Karen", "Price", "222-22-2222", 16.75M, 40M);
            payableObjects[4] = new HourlyEmployee("Ruben", "Zamora", "666-66-6666", 20.00M, 40M);
            payableObjects[5] = new CommissionEmployee("Sue", "Jones", "333-33-3333", 10000M, .06M);
            payableObjects[6] = new BasePlusCommissionEmployee("Bob", "Lewis", "777-77-7777", 5000M, .04M, 300M);
            payableObjects[7] = new BasePlusCommissionEmployee("Lee", "Duarte", "888-88-888", 5000M, .04M, 300M);

            payableObjects[8] = new SalariedEmployee("John", "Smith", "111-11-1111", 700M);
            payableObjects[9] = new SalariedEmployee("Antonio", "Smith", "555-55-5555", 800M);
            payableObjects[10] = new SalariedEmployee("Victor", "Smith", "444-44-4444", 600M);
            payableObjects[11] = new HourlyEmployee("Karen", "Price", "222-22-2222", 16.75M, 40M);
            payableObjects[12] = new HourlyEmployee("Ruben", "Zamora", "666-66-6666", 20.00M, 40M);
            payableObjects[13] = new CommissionEmployee("Sue", "Jones", "333-33-3333", 10000M, .06M);
            payableObjects[14] = new BasePlusCommissionEmployee("Bob", "Lewis", "777-77-7777", 5000M, .04M, 300M);
            payableObjects[15] = new BasePlusCommissionEmployee("Lee", "Duarte", "888-88-888", 5000M, .04M, 300M);
        }

        private void ResetGridFxn(object p)
        {
            InitGrid();
            ReloadListCollection(payableObjects);
        }

        private void SortBySSNDelASCFxn(object p)//3. <Sort based on SSN in Ascending order>
        {
            if (SelectedSorting == SortingOrder.Ascending)
                SelectionSortMethod(payableObjects as object, sortDelegate, true);    // 'true' for ascending. 
            else
                SelectionSortMethod(payableObjects as object, sortDelegate, false);

            ReloadListCollection(payableObjects);
        }

        private void SortByPayAmountDescFxn(object p)  //2. <Sort payment amount in desc using ICompaRER>
        {
            if (SelectedSorting == SortingOrder.Descending)
                Array.Sort(payableObjects, new PaymentAmountComparer(false));
            else if (SelectedSorting == SortingOrder.Ascending)
                Array.Sort(payableObjects, new PaymentAmountComparer(true));
            ReloadListCollection(payableObjects);
        }

        private void SortByLastNameASCFxn(object p)  //1. <Sorting Last Name using IComparABLE>
        {
            Array.Sort(payableObjects);            
            ReloadListCollection(payableObjects);
        }


        private void ReloadListCollection(IPayable[] p)
        {
            SortedList.Clear();
            foreach (Employee e in payableObjects)
            {
                SortedList.Add(e);
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
}
