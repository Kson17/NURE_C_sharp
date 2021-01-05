using System;

namespace NURE
{

    class Program
    {

        static void Main(string[] args)
        {
            Matrix matrix1 = new Matrix();
            Matrix matrix2 = new Matrix();
            Matrix matrix3 = new Matrix();

            Console.WriteLine("Ввод Матрица 1: ");
            matrix1.WriteMatrix();
            Console.WriteLine("Ввод Матрица 2: ");
            matrix2.WriteMatrix();

            Console.WriteLine("Матрица 1: ");
            matrix1.ReadMatrix();
            Console.WriteLine();
            Console.WriteLine("Матрица 2: ");
            Console.WriteLine();
            matrix2.ReadMatrix();

            Console.WriteLine("Сложение матриц 1 и 2: ");
            matrix3 = (matrix1 + matrix2);
            matrix3.ReadMatrix();

            Console.WriteLine("Умножение матриц 1 и 2: ");
            matrix3 = (matrix1 * matrix2);
            matrix3.ReadMatrix();

            Console.WriteLine("Умножение матрицы 1 на число 2: ");
            matrix3 = (matrix1 * 2);
            matrix3.ReadMatrix();

            Console.Write("Сравнение матрицы 1 и 2: ");
            bool result = (matrix1 == matrix2);
            Console.WriteLine(result);

            Console.Write("Детерминант матрицы 1: ");
            Console.WriteLine(matrix1.Det2x2());

            Console.WriteLine("Транспонирование матрицы 1: ");
            matrix3 = Matrix.Transpose(matrix1);
            matrix3.ReadMatrix();

            Console.ReadKey();
        }
    }
}