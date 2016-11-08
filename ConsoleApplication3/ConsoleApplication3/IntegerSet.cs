using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    public class IntegerSet
    {
        /// <summary>
        /// To set the maximum size of set
        /// </summary>
        public int SETSIZE = 101;
        
        public bool[] set;

        // <summary>
        /// To initialize set with default
        /// </summary>
        public IntegerSet()
        {
            set = new bool[SETSIZE];
        }

        // <summary>
        /// To initialize set with user defined numbers
        /// </summary>
        
        public IntegerSet(int[] list)
        {
            set = new bool[SETSIZE];
            foreach (int i in list)
            {
                int temp;
                temp = i;
                try
                {
                    this.set[temp] = true;
                }
                catch (IndexOutOfRangeException)
                {
                 System.Console.WriteLine("Invalid integer to add to set");
                }
               
            }

        }

        

       

        // <summary>
        /// To insert get a particular element  in the set
        /// </summary>
        public bool[] InsertElement(int add)
        {
            if (add < 0 || add >= SETSIZE)
            {
                System.Console.WriteLine("Invalid integer to add to set");
                return this.set;
            }
            else
            {
                this.set[add] = true;
                return this.set;
            }
        }
        // <summary>
        /// To set the entered  a particular element value as true in the boolean array.
        /// </summary>
        public bool[] InsertElements(int[] add)
        {
            int temp;
            foreach (int i in add)
            {
                if (i < 0 || i >= SETSIZE)
                {
                    System.Console.WriteLine("invalid integer");
                }
                else
                {
                    temp = i;
                    this.set[temp] = true;
                }
            }
            return this.set;
        }
        // <summary>
        /// To delete a particular element value in the boolean array.
        /// </summary>

        public bool[] DeleteElement(int del)
        {
            this.set[del] = false;
            return this.set;
        }
        // <summary>
        /// To enter a particular element from console.
        /// </summary>
        public bool[] InputSet()
        {
            string temp;
            int j;
            System.Console.Write("Enter an integer to be added to the set: ");
            temp = System.Console.ReadLine();
            while (temp.Length > 0)
            {
                j = System.Int32.Parse(temp);
                this.InsertElement(j);
                System.Console.Write("Enter an integer to be added to the set: ");
                temp = System.Console.ReadLine();
            }

            return this.set;
        }
        // <summary>
        /// To display the content of the boolean array.
        /// </summary>

        public override string ToString()
        {

            if (this.set == null)
            {
                return "{ <empty> }";
            }

            else
            {
                string temp;
                temp = "{ ";
                for (int i = 0; i < this.set.Length; i++)
                {
                    if (this.set[i] == true)
                    {
                        temp += i;
                    }
                    temp += ", ";
                }
                temp += " }";
                return temp;
            }
        }
        // <summary>
        /// To compare the content of the two set.
        /// </summary>
        public override bool Equals(object obj)
        {   
            IntegerSet other;

            if ((obj == null) || !(obj is IntegerSet))
            {
                return false;
            }
            other = (IntegerSet)obj;

            for (int i = 0; i < this.set.Length; i++)
            {
                if (this.set[i] != other.set[i])
                {
                    return false;
                }
            }
            return true;
        }
        // <summary>
        /// To  do union of the two set.
        /// </summary>

        public IntegerSet Union(object obj)
        {
            IntegerSet tempSet = new IntegerSet();
            

            for (int i = 0; i < this.set.Length; i++)
            {
                if (this.set[i] == true || (obj as IntegerSet).set[i] == true)
                {
                    tempSet.set[i] = true;
                }
            }

          

            return tempSet;
        }

        // <summary>
        /// To  do intersection of the two set.
        /// </summary>
        public IntegerSet Intersection(object obj)
        {
            IntegerSet tempSet = new IntegerSet();
           
            for (int i = 0; i < this.set.Length; i++)
            {
                if (this.set[i] == true && (obj as IntegerSet).set[i] == true)
                {
                    tempSet.set[i] = true;
                }
                else
                {
                    tempSet.set[i] = false;
                }
            }          
            return tempSet;
        }

        // <summary>
        /// To return the unique number of a particular element.
        /// </summary>
        public override int GetHashCode()
        {
            return this.set.GetHashCode();
        }


    }
}
