using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Target_Sum_Array_SSG.SumArray
{
    internal class SumArray
    {
        public List<int> GetIndexesOfNumsThatSumToTarget(List<int> innerList, int targetNumber)
        {
            if (innerList.Count() < 2)
            {
                throw new ArgumentException("Array length must be more then 1!");
            }

            List<int> indexesOfPartsOfTargetNumber = new List<int>();

            for(int i = 0; i < innerList.Count; i++) 
            {
                for (int j = 0; j < innerList.Count; j++) 
                {
                    if (innerList[i] + innerList[j] == targetNumber && i != j) 
                    {
                        indexesOfPartsOfTargetNumber.Add(i);
                        indexesOfPartsOfTargetNumber.Add(j);
                    }
                }

                if (indexesOfPartsOfTargetNumber.Count == 2)
                {
                    break;
                }
            }

            if (indexesOfPartsOfTargetNumber.Count == 0)
            {
                throw new ArgumentException("Wrong target number!");
            }

            return indexesOfPartsOfTargetNumber;
        }

        public ValueTuple<int, int> GetIndexesOfNumsThatSumToTargetWithValueTuple(List<int> innerList, int target) 
        {
            if (innerList.Count() < 2)
            {
                throw new ArgumentException("Array length must be more then 1!");
            }

            ValueTuple<int, int> indexes = (0, 0);

            for (int i = 0; i < innerList.Count; i++)
            {
                for (int j = 0; j < innerList.Count; j++)
                {
                    if (innerList[i] + innerList[j] == target && i != j)
                    {
                        indexes.Item1 = i;
                        indexes.Item2 = j;

                        return indexes;
                    }
                }
            }

            if (indexes.Item1 == 0 && indexes.Item2 == 0)
            {
                throw new ArgumentException("Wrong target number!");
            }

            return indexes;
        }

        public void ShowIndexes(List<int> collection)
        {
            foreach (int inner in collection)
            {
                Console.WriteLine(inner);
            }
        }
    }
}
