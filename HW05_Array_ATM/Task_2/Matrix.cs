namespace ProjectCSharp
{
    class Matrix
    {
        private int[,] matrix;

        public Matrix()
        {
            matrix = new int[3, 3];

            for (int i = 0; i < Row; i++)
                matrix[i, i] = 1;
        }
        public Matrix(int[,] m)
        {
            matrix = m;
        }

        public int this[int i, int j]
        {
            set { matrix[i, j] = value; }
            get { return matrix[i, j]; }
        }
        public int Row
        {
            get { return matrix.GetLength(0); }
        }
        public int Col
        {
            get { return matrix.GetLength(1); }
        }

        public override string ToString()
        {
            string str = "";
            for (int i = 0; i < Row; i++)
            {
                for (int j = 0; j < Col; j++)
                    str += matrix[i, j] + " ";
                str += "\n";
            }

            return str;
        }
        private bool Check(int col)
        {
            bool flag = true;
            for (int i = 0; i < matrix.GetLength(0); i++)
                if (matrix[i, col] < 0)
                    flag = false;
            if (flag == true)
                return true;

            return false;
        }

        public int SumPosCol()
        {
            int sum = 0;
            for (int i = 0; i < matrix.GetLength(1); i++)
            {
                if (Check(i))
                    for (int j = 0; j < matrix.GetLength(0); j++)
                        sum += matrix[j, i];
            }

            return sum;
        }

        public int SumDiagonalMatrix
        {
            get
            {
                int i, j, s = 0, m = 0;
                for (i = 0; i < Row; i++)
                {
                    for (j = 0; j < Col; j++)
                    {
                        if (i == j)
                            m+= matrix[i, j]; // main diagonal
                            
                        if((i + j) == (Row - 1))
                        {
                            if(i != j)
                            s += matrix[i,j]; // secondary diagonal
                        }
                    }
                }

                return m + s;
            }
        }
    }
}