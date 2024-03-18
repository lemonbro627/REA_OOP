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

        public static int Counter => _counter;

        public Money()
        {
            _counter++;
            this.Rubles = 0;
            this.Kopeks = 0;
        }

        public Money(int rubles) : this()
        {
            this.Rubles = rubles;
        }

        public Money(int rubles, int kopeks) : this(rubles)
        {
            this.Kopeks = kopeks;
        }

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
                } 
                else if (value >= 100)
                {
                    this.Rubles = this.Rubles + value / 100;
                    _kopeks = value % 100;
                } 
                else if (this.Rubles > 0)
                {
                    this.Rubles = this.Rubles - 1;
                    _kopeks = _kopeks + 100 + value;
                }
                else
                {
                    _rubles = 0;
                    _kopeks = 0;
                }
            }
        }

        public override string ToString()
        {
            return "Rubles: " + this.Rubles + ", Kopeks: " + this.Kopeks;
        }

        public static Money operator +(Money a, int b)
        {
            return new Money(a.Rubles, a.Kopeks + b);
        }
        public static Money operator -(Money a, int b)
        {
            return new Money(a.Rubles, a.Kopeks - b);
        }
        public static Money operator +(int a, Money b)
        {
            return new Money(b.Rubles, a + b.Kopeks);
        }
        public static Money operator -(int a, Money b)
        {
            return new Money(b.Rubles, a - b.Kopeks);
        }

        public static Money operator +(Money a, Money b)
        {
            return new Money(a.Rubles + b.Rubles, a.Kopeks + b.Kopeks);
        }
        public static Money operator -(Money a, Money b)
        {
            return new Money(a.Rubles - b.Rubles, a.Kopeks - b.Kopeks);
        }

        public static Money operator ++(Money a)
        {
            return new Money(a.Rubles, a.Kopeks + 1);
        }
        public static Money operator --(Money a)
        {
            return new Money(a.Rubles, a.Kopeks - 1);
        }

        public static explicit operator int(Money a)
        { 
            return a.Rubles;
        }
        public static explicit operator double(Money a)
        {
            return (double)a.Kopeks / 100;
        }

    }
}
