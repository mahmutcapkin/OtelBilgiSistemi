using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtelBilgiSistemi
{
    public class LinkedListYorum: LinkedADTYorum
    {
        public override void InsertFirst(OtelYorum value)
        {
            NodeOtelYorum tmpHead = new NodeOtelYorum
            {
                otelYorum = value
            };

            if (Head == null)
                Head = tmpHead;
            else
            {
                //En kritik nokta: tmpHead'in next'i eski Head'i göstermeli
                tmpHead.Next = Head;
                //Yeni Head artık tmpHead oldu
                Head = tmpHead;
            }
            //Bağlı listedeki eleman sayısı bir arttı
            Size++;
        }

        public override void InsertLast(OtelYorum value)
        {
            //Eski sonuncu node, Head'den başlanarak set ediliyor
            NodeOtelYorum oldLast = Head;

            if (Head == null)
                //Hiç kayıt eklenmediği için InsertFirst çağrılabilir
                InsertFirst(value);
            else
            {
                //Yeni sonuncu node yaratılıyor
                NodeOtelYorum newLast = new NodeOtelYorum
                {
                    otelYorum = value
                };

                //Eski sonuncu node bulunuyor
                //Tail olsaydı sonuncuyu bulmaya gerek yoktu.
                while (oldLast.Next != null)
                {

                    oldLast = oldLast.Next;

                }

                //Eski sonuncu node referansı artık yeni sonuncu node'u gösteriyor
                oldLast.Next = newLast;

                //Bağlı listedeki eleman sayısı bir arttı
                Size++;
            }
        }

        public override void InsertPos(int position, OtelYorum value)
        {
            NodeOtelYorum eklenecek = new NodeOtelYorum { otelYorum = value };
            NodeOtelYorum onceki = null;
            NodeOtelYorum sonraki = null;
            NodeOtelYorum simdiki = Head;
            int count = 0;
            if (Head == null)
                InsertFirst(value);
            while (simdiki != null)
            {
                if (count == position - 1)
                {
                    onceki = simdiki;
                    sonraki = simdiki.Next;
                    onceki.Next = eklenecek;
                    eklenecek.Next = sonraki;
                    break;
                }
                simdiki = simdiki.Next;
                count++;
            }
            Size++;
        }

        public override void DeleteFirst()
        {
            if (Head != null)
            {
                //Head'in next'i HeadNext'e atanıyor
                NodeOtelYorum tempHeadNext = this.Head.Next;
                //HeadNext null ise zaten tek kayıt olan Head silinir.
                if (tempHeadNext == null)
                    Head = null;
                else
                    //HeadNext null değilse yeni Head, HeadNext olur.
                    Head = tempHeadNext;
                //Listedeki eleman sayısı bir azaltılıyor
                Size--;
            }
        }

        public override void DeleteLast()
        {
            //Last node bulunup NULL yapılacak
            NodeOtelYorum lastNode = Head;
            //Last node'dan bir önceki node'un Next'i null olacak
            NodeOtelYorum lastPrevNode = null;

            while (lastNode.Next != null)
            {

                lastPrevNode = lastNode;
                lastNode = lastNode.Next;

            }
            //Listedeki eleman sayısı bir azaltılıyor
            Size--;
            //Last node null oldu
            lastNode = null;

            //Last node'dan önceki node varsa onun next'i null olacak yoksa zaten tek kayıt vardır, 
            //o da Head'dir, o da null olacak
            if (lastPrevNode != null)
                lastPrevNode.Next = null;
            else
                Head = null;
        }

        public override void DeletePos(int position)
        {
            if (position == 0)
            {
                DeleteFirst();
            }
            NodeOtelYorum onceki = null;
            NodeOtelYorum sonraki = null;
            NodeOtelYorum simdiki = Head;
            int count = 0;
            if (Head.Next == null)
            {
                DeleteFirst();
            }
            while (simdiki != null)
            {

                if (count == position - 1)
                {
                    onceki = simdiki;
                    onceki.Next = simdiki.Next.Next;
                    sonraki = onceki.Next;
                    break;
                }
                simdiki = simdiki.Next;
                count++;
            }
            simdiki = null;
            Size++;
        }

        /*   public override NodePersonel GetElement(Personel position)
           {
               //Geri dönülecek eleman
               NodePersonel retNode = null;
               //Head'den başlanarak Next node'a gidilecek
               NodePersonel tempNode = Head;
               int count = 0;

               while (tempNode != null)
               {
                   if (count == position)
                   {
                       retNode = tempNode;
                       break;
                   }
                   //Next node'a git
                   tempNode = tempNode.Next;
                   count++;
               }
               return retNode;
           }*/

        public override string DisplayElements()
        {
            string temp = "";
            NodeOtelYorum item = Head;
            while (item != null)
            {
                temp += "-->" + item.otelYorum.YorumcuEposta;
                item = item.Next;
            }

            return temp;
        }
    }
}
