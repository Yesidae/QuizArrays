namespace QuizArrays.Logic
{
    public class OneDimension
    {

        #region Fields
        private int[] _array; // inicia el arreglo
        private int _top; // variable para el tope fisico
        #endregion

        #region Properties
        private bool IsFull => _top == N; // lleno

        private bool IsEmpty => _top == 0; // vacio

        public int N { get; } // tamaño de las posiciones con algo en ellas
        #endregion

        #region Methods
        public OneDimension(int n) // constructor
        {
            N = n;
            _array = new int[n];
            _top = 0;
        }

        public void Add(int number) // añade el numero al estar lleno indica que esta lleno
        {
            if (IsFull)
            {
                throw new Exception("The array is full.");
            }

            _array[_top] = number;
            _top++;
        }

        public override string ToString()
        {
            if (IsEmpty)
            {
                return "Empty array.";
            }

            string output = string.Empty;
            int count = 0;
            for (int i = 0; i < _top; i++)
            {
                output += $"{_array[i]}\t";
                count++;
                if (count > 9)
                {
                    count = 0;
                    output += "\n";
                }
            }
            return output;
        }
        #endregion

    }
}