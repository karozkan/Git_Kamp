using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{
    class MyList<T>
    {
        T[] items;
        //constructor
        public MyList() //ctor TabTab
        {
            items = new T[0];// array in newlenme zorunluluğu var. array referans tip olduğu için
        }

        public void Add(T item)
        {
            T[] tempArray = items; //Geçici dizi
            items = new T[items.Length + 1]; //dizi eleman sayısını 1 arttırır
           
            for (int i = 0; i < tempArray.Length; i++) //for TabTab
            {
                items[i] = tempArray[i];
            }
            items[items.Length - 1] = item; //items a ekleme burada gerçekleşir
        }
        public int Length // eleman sayısını verir
        {
            get { return items.Length; }
        }
        public T[] Items
        {
            get { return items; }
        }
    }
}
