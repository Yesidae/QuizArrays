using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizArrays.Logic
{
    public class TwoDimensions
    {
        private int[,] _array; // inicia el arreglo de 2 dimensiones

        public int M { get; } // propiedad M que solo deja leer
        public int N { get; } // propiedad N que solo deja leer

        public TwoDimensions(int n, int m) // Const que dimensiona el arreglo
        {
            N = n;
            M = m;
            _array = new int[n,m];
        }

        public void Fill() // metodo fill
        {
            var random = new Random();
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < M; j++)
                {
                    _array[i, j] = random.Next(1, 100); 
                }
            }
        }

        public ToOneDimension() // convierte 2 dimensiones en una
        {
            int[] newArray;

            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < M; j++)
                {
                    int aux = 0;
                    aux = _array[i, j] ;
                    newArray[i] = aux;
                }
            }

            return newArray;
        }

        public override string ToString() // convierte a string
        {
            string output = string.Empty;
            int count = 0;
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < M; j++)
                {
                    output += $"{_array[i,j]}\t";
                    count++;
                    if (count > 9)
                    {
                        count = 0;
                        output += "\n";
                    } 
                }
            }
            return output;
        }
    }
}
