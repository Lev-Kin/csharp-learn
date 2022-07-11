using System;

namespace ProjectCSharp
{
    class ArrayOneD
    {
        public int[] Array { get; set; }
        public int Count
        {
            get
            {
                return Array.Length;
            }
        }
        public int this[int i]
        {
            get
            {
                return Array[i];
            }
            set
            {
                Array[i] = value;
            }
        }
        public ArrayOneD(params int[] array)
        {
            Array = array;
        }
        public ArrayOneD()
        {
            Array = new int[0];
        }

        public override string ToString()
        {
            string str = "";
            for (int i = 0; i < Array.Length; i++)
            {
                str += String.Format( "{0,4}", Array[i]);
                if (i + 1 < Array.Length)
                    str += ", ";
                if ((i + 1) % Array.Length == 0)
                    str += "}\n\n";
                if ((i + 1) % 5 == 0)
                    str += "\n\t";
            }

            return str;
        }

        public static ArrayOneD operator *(ArrayOneD array, int factor)
        {
            int[] arr = new int[array.Count];
            for (int i = 0; i < arr.Length; i++)
                arr[i] = array.Array[i];
            
            for (int i = 0; i < arr.Length; ++i)
                arr[i] *= factor;
            
            return new ArrayOneD(arr);
        }

        public static ArrayOneD operator -(ArrayOneD array)
        {
            int[] arr = new int[array.Count];
            for (int i = 0; i < arr.Length; i++)
                arr[i] = -array.Array[i];
            
            return new ArrayOneD(arr);
        }

        public static int operator *(int factor, ArrayOneD array)
        {
            int product = factor;
            for (int i = 0; i < array.Count; ++i)
                product *= array.Array[i];
           
            return product;
        }

        public static implicit operator ArrayOneD(string str)
        {
            try
            {
                int[] arr = new int[str.Length * 4];
                for (int i = 0; i < str.Length; ++i)
                {
                    if (str[i] != ' ')
                    {
                        if (str[i] == '-')
                            arr[i] = -str[i];
                        else
                            arr[i] = str[i];
                    }
                }

                return new ArrayOneD(arr);
            }
            catch (FormatException fex)
            {
                Console.WriteLine(fex.Message);
                return new ArrayOneD();
            }
        }

        public static int NegativeSum(params int[] array)
        {
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < 0)
                    sum += array[i];
            }
            return sum;
        }
    }
}
