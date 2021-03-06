﻿using System;
using System.Collections.Generic;

namespace greatest_values_in_matrices
{
    class Program
    {
        public static List<List<int>> CompareMatrix(List<List<int>> firstMatrix, List<List<int>> secondMatrix)
        {
            var output = firstMatrix;
            for (int i = 0; i < output.Count; i++)
            {
                for (int j = 0; j < output[i].Count; j++)
                {
                    if (secondMatrix[i][j] > output[i][j])
                    {
                        output[i][j] = secondMatrix[i][j];
                    }
                }
            }
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
            
            var comparedMatrix = CompareMatrix(firstMatrix, secondMatrix);

            foreach (List<int> row in comparedMatrix)
            {
                string strRow = "";
                foreach (int item in row)
                {
                    strRow = strRow + item.ToString() + ", ";
                }

                Console.WriteLine(strRow);
            }
        }
    }
}
