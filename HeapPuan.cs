using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtelBilgiSistemi

{
    public class HeapPuan
    {
        private HeapDugumu[] heapArray;
        private int maxSize;
        private int currentSize;
        public HeapPuan(int maxHeapSize)
        {
            maxSize = maxHeapSize;
            heapArray = new HeapDugumu[maxSize];
            currentSize = 0;

        }
        public bool IsEmpty()
        {
            return currentSize == 0;
        }
        public bool Insert(Otel otel)
        {
            if (currentSize == maxSize)
                return false;
            HeapDugumu newHeapDugumu = new HeapDugumu(otel);
            heapArray[currentSize] = newHeapDugumu;
            MoveToUp(currentSize++);
            return true;
        }
        public void MoveToUp(int index)
        {
            int parent = (index - 1) / 2;
            HeapDugumu bottom = heapArray[index];
            while (index > 0 && int.Parse(heapArray[parent].otel.OtelPuani) < int.Parse(bottom.otel.OtelPuani))
            {
                heapArray[index] = heapArray[parent];
                index = parent;
                parent = (parent - 1) / 2;
            }
            heapArray[index] = bottom;
        }
        public HeapDugumu RemoveMax() // Remove maximum value HeapDugumu
        {
            HeapDugumu root = heapArray[0];
            heapArray[0] = heapArray[--currentSize];
            MoveToDown(0);
            return root;
        }
        public void MoveToDown(int index)
        {
            int largerChild;
            HeapDugumu top = heapArray[index];
            while (index < currentSize / 2)
            {
                int leftChild = 2 * index + 1;
                int rightChild = leftChild + 1;
                //Find larger child
                if (rightChild < currentSize && int.Parse(heapArray[leftChild].otel.OtelPuani) < int.Parse(heapArray[rightChild].otel.OtelPuani))
                    largerChild = rightChild;
                else
                    largerChild = leftChild;
                if (int.Parse(top.otel.OtelPuani) >= int.Parse(heapArray[largerChild].otel.OtelPuani))
                    break;
                heapArray[index] = heapArray[largerChild];
                index = largerChild;
            }
            heapArray[index] = top;
        }
        
        public List<Otel> siralanmisGetir()
        {
            List<Otel> hotels = new List<Otel>();
            while (!IsEmpty())
            {
                hotels.Add(RemoveMax().otel);
            }

            return hotels;
        }

    }
}
