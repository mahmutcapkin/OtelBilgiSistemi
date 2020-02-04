using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtelBilgiSistemi
{
    public abstract class LinkedADTPersonel
    {
        public NodePersonel Head;
        public int Size = 0;
        public abstract void InsertFirst(Personel value);
        public abstract void InsertLast(Personel value);
        public abstract void InsertPos(int position, Personel value);
        public abstract void DeleteFirst();
        public abstract void DeleteLast();
        public abstract void DeletePos(int position);
        //   public abstract NodePersonel GetElement(Personel position);
        public abstract string DisplayElements();
    }
}
