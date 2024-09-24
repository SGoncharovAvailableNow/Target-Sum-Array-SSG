using Target_Sum_Array_SSG.SumArray;

internal class Program
{
    private static void Main(string[] args)
    {
        SumArray sumArray = new SumArray();

        sumArray.ShowIndexes(sumArray.GetIndexesOfNumsThatSumToTarget(new List<int> { 1, 2, 3 }, 4));
        sumArray.ShowIndexes(sumArray.GetIndexesOfNumsThatSumToTarget(new List<int> { 3, 2, 4 }, 6));

        Console.WriteLine(sumArray.GetIndexesOfNumsThatSumToTargetWithValueTuple(new List<int> { 1, 2, 3 }, 4));
        Console.WriteLine(sumArray.GetIndexesOfNumsThatSumToTargetWithValueTuple(new List<int> { 3, 2, 4 }, 6));

        Console.WriteLine(sumArray.GetIndexesOfNums(new List<int> { 1, 2, 3 }, 4));
        Console.WriteLine(sumArray.GetIndexesOfNums(new List<int> { 3, 2, 4 }, 6));
    }
}