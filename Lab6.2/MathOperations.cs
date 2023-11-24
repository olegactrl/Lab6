using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Lab6._2
{
    public class MathOperations
    {
        public static T Add<T>(T a, T b)
        {
            dynamic dynamicA = a;
            dynamic dynamicB = b;
            return dynamicA + dynamicB;
        }

        public static T[] Add<T>(T[] a, T[] b)
        {

            T[] result = new T[a.Length];
            for (int i = 0; i < a.Length; i++)
            {
                result[i] = Add(a[i], b[i]);
            }

            return result;
        }

        public static T[,] Add<T>(T[,] a, T[,] b)
        {
            int rows = a.GetLength(0);
            int columns = a.GetLength(1);

            T[,] result = new T[rows, columns];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    result[i, j] = Add(a[i, j], b[i, j]);
                }
            }

            return result;
        }

    }
}

