using System;
using System.Collections.Generic;

namespace greatest_values_in_matrices
{
    class Program
    {
        public static List<List<int>> CompareMatrix(List<List<int>> firstMatrix, List<List<int>> secondMatrix)
        {
            var output = firstMatrix;
            return output;
        }
        static void Main(string[] args)
        {
            var firstMatrix = new List<List<int>>();
            firstMatrix.Add(new List<int> { 1, 3 });
            firstMatrix.Add(new List<int> { 2, 1 });

            var secondMatrix = new List<List<int>>();
            secondMatrix.Add(new List<int> { -1, 1 });
            secondMatrix.Add(new List<int> { 2, 2 });
            
            Console.WriteLine(CompareMatrix(firstMatrix, secondMatrix));
        }
    }
}
