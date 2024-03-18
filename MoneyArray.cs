using Microsoft.CSharp.RuntimeBinder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
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
            _arr = Array.Empty<Money>();
        }

        public MoneyArray(int size, bool random = true)
        {
            Random rnd = new Random();
            _arr = new Money[size];
            _size = size;
            for (int i = 0; i < size; i++)
            {
                _arr[i] = new Money();
            }
            if (random)
            {
                for (int i = 0; i < size; i++)
                {
                    _arr[i].Rubles = rnd.Next(0, 100);
                    _arr[i].Kopeks = rnd.Next(0, 100);
                }
            }
            else
            {
                for (int i = 0; i < size; i++)
                {
                    Console.WriteLine("Введите данные для элемента " + i);
                    Console.Write("Рубли: ");
                    _arr[i].Rubles = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Копейки: ");
                    _arr[i].Kopeks = Convert.ToInt32(Console.ReadLine());
                }
            }
        }

        public Money this[int index] {
            get 
            {
                if (index < _size)
                {
                    return _arr[index];
                }
                else
                {
                    throw new ArgumentException("Индекс не существует");
                }
            }
            set
            {
                if (index < _size)
                {
                    _arr[index].Rubles = value.Rubles;
                    _arr[index].Kopeks = value.Kopeks;
                } else
                {
                    throw new ArgumentException("Индекс не существует");
                }
            }
        }

        public int Lenght { get => _size; }

        public Money Min()
        {
            if (_size > 0)
            {
                Money min = _arr[0];
                for (int i = 1; i < _size; i++)
                {
                    if ((_arr[i].Rubles*100 + _arr[i].Kopeks) < (min.Rubles*100+min.Kopeks)) {
                        min = _arr[i];
                    }
                }
                return min;
            }
            return new Money(0, 0);
            
        }

    }   

}
