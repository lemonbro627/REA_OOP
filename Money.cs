using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace REA_OOP
{
    internal class Money
    {
        private int _rubles;
        private int _kopeks;
        private static int _counter;

        public Money(int rubles, int kopeks)
        {
            this.Rubles = rubles;
            this.Kopeks = kopeks;
            _counter++;
        }

        public Money(int rubles)
        {
            new Money(rubles, 0);
        }
        public Money()
        {
            new Money(0, 0);
        }

        public static int Counter => _counter;

        public int Rubles
        {
            get => _rubles;
            set
            {
                if (value >= 0)
                {
                    _rubles = value;
                }
            }
        }

        public int Kopeks
        {
            get => _kopeks;
            set
            {
                if ((value >= 0) && (value <= 99))
                {
                    _kopeks = value;
                } else
                {
                    _rubles += value / 100;
                    _kopeks = value % 100;
                }
            }
        }

        public override string ToString()
        {
            return "Rubles: " + Rubles + ", Kopeks: " + Kopeks;
        }

        public static Money operator +(Money a, int b)
        {
            return new Money(a.Rubles, a.Kopeks + b);
        }
    }
}
