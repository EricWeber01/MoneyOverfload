//Написать класс Money, предназначенный для хранения денежной 
//суммы (в гривнах и копейках). Для класса реализовать перегрузку 
//операторов + (сложение денежных сумм), – (вычитание сумм), / 
//(деление суммы на целое число), * (умножение суммы на целое число), 
//++ (сумма увеличивается на 1 копейку), -- (сумма уменьшается на 1 
//копейку), ==, !=. Программа должна с помощью меню 
//продемонстрировать все возможности класса Money.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Money
{
    internal class Money
    {
        static void Main(string[] args)
        {
             public long rub { get; private set; }
        public byte kop { get; private set; }
        public Money(long rub, byte kop)
        {
            if (kop >= 100 || kop < 0)
                throw new ArgumentException("Количество копеек должно быть от 0 до 99.");
            if (rub < 0)
                throw new ArgumentException("Количество рублей должно быть положительным.");
            this.rub = rub;
            this.kop = kop;
        }
        public override string ToString()
        {
            return string.Format("{0},{1:00}", rub, kop);
        }
        public static Money operator +(Money a, Money b)
        {
            int kopSum = a.kop + b.kop;
            long rub = a.rub + b.rub + kopSum / 100;
            byte kop = (byte)(kopSum % 100);
            return new Money(rub, kop);
        }
        public static Money operator -(Money a, Money b)
        {
            int kopDiff = a.kop - b.kop;
            long rub = a.rub - b.rub;
            if (kopDiff < 0)
            {
                rub--;
                kopDiff += 100;
            }
            byte kop = (byte)(kopDiff % 100);
            return new Money(rub, kop);
        }
        public static Money operator true(Money obj)
        {
            if ((obj.a > 0) && (obj.b > 0))
                return true;
            return false;
        }
        public static Money operator false(Money obj)
        {
            if ((obj.a <= 0) || (obj.b <= 0)))
                return true;
            return false;
        }
    }
}