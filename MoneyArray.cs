using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace REA_OOP
{
    internal class MoneyArray
    {
        private Money[] _arr;
        private int _size;

        public MoneyArray()
        {
            _arr = new Money[0];
        }

        public MoneyArray(int size)
        {
            Random rnd = new Random();
            _arr = new Money[size];
            _size = size;
            for (int i = 0; i < size; i++) {
                _arr[i].Kopeks = rnd.Next(0, 100);
                _arr[i].Rubles = rnd.Next(0, 100);
            }
        }


    }   

}
