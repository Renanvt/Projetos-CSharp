using _Interface1_.entities;
using System;


namespace _Interface1_.services
{
    class RentalService //Service de Aluguel
    {
        public double PricePerHour { get; private set; }
        public double PricePerDay { get; private set; }

        //DEPENDÊNCIA
        private BrazilTaxService _brazilTaxService = new BrazilTaxService();

        public RentalService(double pricePerHour, double pricePerDay)
        {
            PricePerHour = pricePerHour;
            PricePerDay = pricePerDay;
        }

        public void ProcessInvoice(CarRental carRental) //Processar Nota de pagamento
        {
            //Diferenca entre o horario de entregad e horario de locacao
            TimeSpan duration = carRental.Finish.Subtract(carRental.Start);
            double basicPayment = 0.0;
            if(duration.TotalHours <= 12.0)
            {
                basicPayment = PricePerHour * Math.Ceiling(duration.TotalHours); //Arredonda pra cima

            }
            else
            {
                basicPayment = PricePerDay * Math.Ceiling(duration.TotalDays);
            }
            double tax = _brazilTaxService.Tax(basicPayment);
            carRental.Invoice = new Invoice(basicPayment, tax);
        }
    }
}
