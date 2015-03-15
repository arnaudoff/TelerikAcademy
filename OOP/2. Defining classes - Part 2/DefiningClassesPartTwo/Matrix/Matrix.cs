﻿namespace Matrices
{
    using System;
    using System.Text;

    public class Matrix<T> where T : IComparable<T>
    {
        private const string delimiter = " ";
        private T[,] matrix;

        public Matrix(int rows, int cols)
        {
            this.Rows = rows;
            this.Cols = cols;
            this.matrix = new T[rows, cols];
        }

        public int Rows { get; private set; }

        public int Cols { get; private set; }
        
        public T this[int row, int col]
        {
            get
            {
                if ((row < 0 || row >= this.Rows) || (col < 0 || col >= this.Cols))
                {
                    throw new IndexOutOfRangeException("Invalid index given.");
                }

                return this.matrix[row, col];
            }
            set
            {
                if ((row < 0 || row >= this.Rows) || (col < 0 || col >= this.Cols))
                {
                    throw new IndexOutOfRangeException("Invalid index given.");
                }

                this.matrix[row, col] = value;
            }
        }

        public override string ToString()
        {
            StringBuilder res = new StringBuilder();

            for (int row = 0; row < this.Rows; row++)
            {
                for (int col = 0; col < this.Cols; col++)
                {
                    res.Append(this.matrix[row, col] + delimiter);
                }
                res.AppendLine();
            }

            return res.ToString();
        }

        public static Matrix<T> operator +(Matrix<T> firstMatrix, Matrix<T> secondMatrix)
        {
            if (firstMatrix.Cols != secondMatrix.Cols || firstMatrix.Rows != secondMatrix.Rows)
            {
                throw new InvalidOperationException("Matrices are with different dimensions and cannot be added.");
            }

            Matrix<T> res = new Matrix<T>(firstMatrix.Rows, firstMatrix.Cols);

            for (int row = 0; row < firstMatrix.Rows; row++)
            {
                for (int col = 0; col < firstMatrix.Cols; col++)
                {
                    res[row, col] = (dynamic)firstMatrix[row, col] + secondMatrix[row, col];
                }
            }

            return res;
        }

        public static Matrix<T> operator -(Matrix<T> firstMatrix, Matrix<T> secondMatrix)
        {
            if (firstMatrix.Cols != secondMatrix.Cols || firstMatrix.Rows != secondMatrix.Rows)
            {
                throw new InvalidOperationException("Matrices are with different dimensions and cannot be substracted.");
            }

            Matrix<T> res = new Matrix<T>(firstMatrix.Rows, firstMatrix.Cols);

            for (int row = 0; row < firstMatrix.Rows; row++)
            {
                for (int col = 0; col < firstMatrix.Cols; col++)
                {
                    res[row, col] = (dynamic)firstMatrix[row, col] - secondMatrix[row, col];
                }
            }

            return res;
        }

        public static Matrix<T> operator *(Matrix<T> firstMatrix, Matrix<T> secondMatrix)
        {
            if (firstMatrix.Cols != secondMatrix.Rows)
            {
                throw new InvalidOperationException("Matrices are with different dimensions and cannot be multiplied.");
            }

            Matrix<T> res = new Matrix<T>(firstMatrix.Rows, secondMatrix.Cols);
            T tmp;

            for (int matrixRow = 0; matrixRow < res.Rows; matrixRow++)
            {
                for (int matrixCol = 0; matrixCol < res.Cols; matrixCol++)
                {
                    tmp = default(T);
                    for (int index = 0; index < res.Cols; index++)
                    {
                        tmp += (dynamic)firstMatrix[matrixRow, index] * secondMatrix[index, matrixCol];
                    }
                    res[matrixRow, matrixCol] = tmp;
                }
            }

            return res;
        }

        public static bool operator true(Matrix<T> matrix)
        {
            return HasNonZeroValue(matrix);
        }

        public static bool operator false(Matrix<T> matrix)
        {
            return HasNonZeroValue(matrix);
        }

        private static bool HasNonZeroValue(Matrix<T> matrix)
        {
            for (int row = 0; row < matrix.Rows; row++)
            {
                for (int col = 0; col < matrix.Cols; col++)
                {
                    if (matrix[row, col] != (dynamic)0)
                    {
                        return true;
                    }
                }
            }

            return false;
        }
    }
 }