using System;
using System.Collections.Generic;
using System.Text;

namespace PBL3REAL.Extention
{
    public class MaxHeap
    {
        public double[] Array { get; private set; }
        public int Length { get; private set; }
        public string rs { get; private set; }
        public string pointtime { get; private set; }
        public int len { get; private set; }
        public MaxHeap(double[] input, int length)
        {
            this.Length = length;
            this.Array = input;
            BuildMaxHeap();
        }
        private void BuildMaxHeap()
        {
            for (int i = this.Length / 2; i > 0; i--)
            {
                MaxHeapify(i);
            }
            return;
        }
        public void MaxHeapify(int index)
        {
            var left = 2 * index;
            var right = 2 * index + 1;
            int max = index;
            if (left <= this.Length && this.Array[left - 1] > this.Array[index - 1])
            {
                max = left;
            }
            if (right <= this.Length && this.Array[right - 1] > this.Array[max - 1])
            {
                max = right;
            }
            if (max != index)
            {
                double temp = this.Array[max - 1];
                this.Array[max - 1] = this.Array[index - 1];
                this.Array[index - 1] = temp;
                MaxHeapify(max);
            }
            return;
        }
        public double Maximum()
        {
            return this.Array[0];
        }
    }
}
