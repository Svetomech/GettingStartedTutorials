using System;

namespace GettingStartedTutorials.CSharp.Encapsulation
{
    public class Order
    {
        private DateTime _date;

        public Order(string number) : this(number, DateTime.Now)
        { }
        public Order(string number, DateTime date)
        {
            Number = number;
            Date = date;
        }

        public string Number { get; }
        public DateTime Date
        {
            get => _date;
            set
            {
                if (value > DateTime.Now)
                {
                    throw new ArgumentOutOfRangeException(nameof(value));
                }

                _date = value;
            }
        }

        public override string ToString() => $"{Number}    {Date}";
    }
}