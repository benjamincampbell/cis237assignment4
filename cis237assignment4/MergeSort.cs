using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237assignment4
{
    class MergeSort
    {
        private IComparable[] arrayToSort;
        private IComparable[] tempArray;

        public MergeSort()
        {

        }

        public IComparable[] sortArray(IComparable[] array)
        {
            this.arrayToSort = array;
            this.sort(array, 0, array.Length - 1);
            return this.arrayToSort;
        }

        private void sort(IComparable[] array, int low, int high)
        {
            if (low < high)
            {
                int mid = low + ((high - low) / 2);
                this.sort(array, low, mid);
                this.sort(array, mid + 1, high);
                this.merge(array, low, mid, high);
            }
        }

        private void merge(IComparable[] array, int low, int mid, int high)
        {
            int i = low;
            int j = mid + 1;
            //Make a temporary array to compare the values against
            tempArray = new IComparable[array.Length];
            for (int a = low; a < high + 1; a++)
            {   //Copy the values into tempArray
                tempArray[a] = array[a];
            }
            //Now we actually have to do our sorting
            for (int k = low; k <= high; k++)
            {
                if (i > mid)
                {   //If i (low) is greater than mid, it means we are at the end of the first subarray
                    array[k] = tempArray[j];
                    j++;
                }
                else
                {
                    if (j > high)
                    {   //If j (mid+1) is greater than high, it means we are at the end of the second subarray
                        array[k] = tempArray[i];
                        i++;
                    }
                    else
                    {

                        if (tempArray[j].CompareTo(tempArray[i]) < 0)
                        {   //If tempArray[j] is less than tempArray[i], insert j (since low values come first)
                            array[k] = tempArray[j];
                            j++;
                        }
                        else
                        {   // tempArray[i] is lower than tempArray[j], so insert i
                            array[k] = tempArray[i];
                            i++;
                        }
                    }
                }
            }

        }
    }
}