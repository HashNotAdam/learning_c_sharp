using System;

namespace introduction_to_classes
{

    public class Transaction
    {
        public decimal Amount { get; }
        public DateTime Date { get; }
        public string Notes { get; }

        public Transaction(decimal amount, DateTime date, string note)
        {
            this.Amount = amount;
            this.Date = date;
            this.Notes = note;
        }

        public string ToString(int columnLength)
        {
            return Date.ToShortDateString().PadRight(columnLength) +
              Amount.ToString("$0.00").PadRight(columnLength) +
              Notes.PadRight(columnLength);
        }
    }
}
