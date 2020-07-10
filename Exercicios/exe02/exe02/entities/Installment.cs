using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace exe02.entities
{
    class Installment //Parcelas
    {
        public DateTime dueDate { get; set; } //Data de vencimento
        public double Amount { get; set; } //Valor

        public Installment(DateTime dueDate, double amount)
        {
            this.dueDate = dueDate;
            Amount = amount;
        }
        public override string ToString()
        {
            return dueDate.ToString("dd/MM/yyyy")
                + " - "
                + Amount.ToString("F2", CultureInfo.InvariantCulture);
        }
}
