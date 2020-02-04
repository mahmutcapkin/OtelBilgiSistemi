using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtelBilgiSistemi
{
    public abstract class LinkedADTYorum
    {
        public NodeOtelYorum Head;
        public int Size = 0;
        public abstract void InsertFirst(OtelYorum value);
        public abstract void InsertLast(OtelYorum value);
        public abstract void InsertPos(int position, OtelYorum value);
        public abstract void DeleteFirst();
        public abstract void DeleteLast();
        public abstract void DeletePos(int position);
        // public abstract NodeOtelYorum GetElement(int position);
        public abstract string DisplayElements();
    }
}
