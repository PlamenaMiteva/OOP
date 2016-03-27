using System;
using System.Numerics;

public class BitArray
    {
        private bool[] arr;
        private int size;

        public BitArray(int size)
        {
            this.Size = size;
            this.Arr = new bool[size];
        }

        public bool[] Arr
        {
            get { return this.arr; }
            set
            {
                if (value==null) 
                    throw new ArgumentNullException();
                this.arr = value;
            }
        }

        public int Size
        {
            get { return this.size; }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Size cannot be negative.");
                }
                this.size = value;
            }
        }

        public bool this[int index]
        {
            get
            {
                return this.Arr[index];
            }
            set
            {
                if (index < 0 || index > 100000)
                {
                    throw new ArgumentOutOfRangeException("The given index is outside the allowed range [0 - 100000]");
                }
                this.Arr[index] = value;
            }
        }
        
        public void SetBits(params int[] positions)
        {
            for (int i = 0; i < positions.Length; i++)
            {
                this[positions[i]] = true;
            }
        }

        public override string ToString()
        {
            return ArrayToBigNumber().ToString();
        }

        private BigInteger ArrayToBigNumber()
        {
            BigInteger num = BigInteger.Zero;
            BigInteger exp2 = BigInteger.One;
            for (int pos = 0; pos < this.Size; pos++)
            {
                exp2 *= 2;
                if (this[pos])
                {
                    num += exp2 / 2;
                }
            }

            return num;
        }

    }
