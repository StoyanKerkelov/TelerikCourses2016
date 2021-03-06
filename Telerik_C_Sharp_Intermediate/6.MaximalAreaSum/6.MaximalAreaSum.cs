﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _6.MaximalAreaSum
{   //Write a program that reads a text file containing a square matrix of numbers.
    //Find an area of size 2 x 2 in the matrix, with a maximal sum of its elements.
    class Program
    {
        static void Main()
        {
            string filePath = @"../../Files/matrix.txt";
            string resultPath = @"../../Files/result.txt";//the program makes result.txt file

            StreamReader reader = new StreamReader(filePath);

            int matrixSize = int.Parse(reader.ReadLine());

            int[,] matrix = new int[matrixSize, matrixSize];

            string currentLine;
            int currentRow = 0;

            while ((currentLine = reader.ReadLine()) != null)
            {
                string[] numbers = currentLine.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                for (int i = 0; i < numbers.Length; i++)
                {
                    matrix[currentRow, i] = int.Parse(numbers[i]);
                }

                currentRow++;
            }

            PrintMatrix(matrix);

            using (StreamWriter writer = new StreamWriter(resultPath))
            {
                writer.WriteLine(FindMaxSequence(2, matrix));
            }

            using (StreamReader resultReader = new StreamReader(resultPath))
            {
                Console.WriteLine("Max sequence: " + resultReader.ReadLine());
            }

        }

        private static void PrintMatrix(int[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col]);
                }

                Console.WriteLine();
            }
        }

        private static int FindMaxSequence(int sequenceSize, int[,] matrix)
        {
            int maxSum = int.MinValue, currentSum = 0;

            for (int row = 0; row <= matrix.GetLength(0) - sequenceSize; row++)
            {
                for (int col = 0; col <= matrix.GetLength(1) - sequenceSize; col++)
                {
                    currentSum = matrix[row, col] + matrix[row + 1, col] + matrix[row, col + 1] + matrix[row + 1, col + 1];

                    if (currentSum > maxSum)
                    {
                        maxSum = currentSum;
                    }
                }
            }

            return maxSum;
        }
    }
}
