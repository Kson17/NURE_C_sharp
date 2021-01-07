using System;

namespace NURE
{
    class Matrix
    {
        public int n;
        public int[,] mass;

        public Matrix()
        {
            // хардкод для создания 2х2 матрицы
            this.n = 2;
            mass = new int[0, 0];
        }

        public int this[int i, int j]
        {
            get { return mass[i, j]; }
            set { mass[i, j] = value; }
        }


        public void WriteMatrix()
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.WriteLine("Введите элемент матрицы {0}:{1}", i + 1, j + 1);
                    mass[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
        }


        public void ReadMatrix()
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(mass[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }


        // Умножение матрицы на число
        public static Matrix MultiplyByNumber(Matrix a, int ch)
        {
            Matrix result = new Matrix();
            for (int i = 0; i < a.n; i++)
            {
                for (int j = 0; j < a.n; j++)
                {
                    result[i, j] = a[i, j] * ch;
                }
            }
            return result;
        }

        // Умножение матриц
        public static Matrix MultiplyTwoMatrices(Matrix a, Matrix b)
        {
            Matrix result = new Matrix();
            for (int i = 0; i < a.n; i++)
                for (int j = 0; j < b.n; j++)
                    for (int k = 0; k < b.n; k++)
                        result[i, j] += a[i, k] * b[k, j];

            return result;
        }

        // Сложение матриц
        public static Matrix Sum(Matrix a, Matrix b)
        {
            Matrix result = new Matrix();
            for (int i = 0; i < a.n; i++)
            {
                for (int j = 0; j < b.n; j++)
                {
                    result[i, j] = a[i, j] + b[i, j];
                }
            }

            return result;
        }

        // Сравнение матриц (сравнение массивов)
        public static bool Equals(Matrix a, Matrix b)
        {
            for (int i = 0; i < a.n; i++)
            {
                for (int j = 0; j < b.n; j++)
                {
                    if (a.mass[i, j] != b[i, j])
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        // Детерминант матриц 2х2
        public double Det2x2()
        {
            double det;
            det = mass[0, 0] * mass[1, 1] - mass[0, 1] * mass[1, 0];

            return det;
        }

        // Транспонирование матриц
        public static Matrix Transpose(Matrix a)
        {
            Matrix result = new Matrix();

            for (int i = 0; i < a.n; i++)
            {
                for (int j = 0; j < a.n; j++)
                {
                    result[j, i] = a.mass[i, j];
                }
            }

            return result;
        }



        // перегрузка оператора умножения матриц
        public static Matrix operator *(Matrix a, Matrix b)
        {
            return Matrix.MultiplyTwoMatrices(a, b);
        }

        // перегрузка оператора умножения матрицы на число
        public static Matrix operator *(Matrix a, int b)
        {
            return Matrix.MultiplyByNumber(a, b);
        }
       
        // перегрузка оператора сложения
        public static Matrix operator +(Matrix a, Matrix b)
        {
            return Matrix.Sum(a, b);
        }

        // перегрузка оператора сравнения
        public static bool operator ==(Matrix a, Matrix b)
        {
            return Matrix.Equals(a, b);
        }

        public static bool operator !=(Matrix a, Matrix b)
        {
            return !Matrix.Equals(a, b);
        }
    }
}