using System;

namespace Overwrite
{
    internal class Program
    {
        static void Main(string[] args)
        {
            B b = new B();
            Console.WriteLine(b.Hi());

            Sale sale = new Sale(10);
            sale.Add(10);
            sale.Add(2);
            Console.WriteLine(sale.GetTotal());

            SaleWithTax saleWithTax = new SaleWithTax(10, 1.15m);
            saleWithTax.Add(10);
            saleWithTax.Add(2);
            Console.WriteLine(saleWithTax.GetTotal());
        }
    }

    #region Example Sale
    public class Sale
    {
        private decimal[] _amounts;
        private int _n;
        private int _end;

        public Sale(int n)
        {
            _amounts = new decimal[n];
            _n = n;
            _end = 0;
        }

        public void Add(decimal amount)
        {
            if (_end < _n)
            {
                _amounts[_end] = amount;
                _end++;
            }
        }

        public virtual decimal GetTotal()
        {
            decimal result = 0;
            int i = 0;

            while (i < _amounts.Length)
            {
                result += _amounts[i];
                i++;
            }

            return result;
        }
    }

    public class SaleWithTax : Sale
    {
        private decimal _tax;
        public SaleWithTax(int n, decimal tax) : base(n)
        {
            _tax = tax;
        }

        public override decimal GetTotal()
        {
            return base.GetTotal() * _tax;
        }
    }
    #endregion

    #region Example A and B
    public class A
    {
        public virtual string Hi()
        {
            return "Hi I am A";
        }
    }

    public class B : A
    {
        public override string Hi()
        {
            return base.Hi() + "Hi I am B";
        }
    }
    #endregion
}
