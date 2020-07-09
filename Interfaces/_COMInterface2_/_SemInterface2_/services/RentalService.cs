using _SemInterface2_.entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace _SemInterface2_.services
{
    class RentalService //Servico de aluguel
    {
        public double PricePerHour { get; set; }
        public double PricePerDay { get; set; }

        //Fazendo a dependencia de RentalService para BrazilTaxService
        //private BrazilTaxService _brazilTaxService = new BrazilTaxService();
        //A Dependencia fica muito forte, so vai funcionar para BrazilTaxService
        //Se tiver que trocar esse servico para outro servico, tera que criar um novo servico e abir o servico BrazilTaxService e mexer nela
        private ITaxService _taxService;
        public RentalService(double pricePerHour, double pricePerDay, ITaxService taxService)
        {
            PricePerHour = pricePerHour;
            PricePerDay = pricePerDay;
            //INVERSÃO DE CONTROLE POR MEIO DE INJEÇÃO DE DEPENDENCIA
            /*A classe RentalService não instancia mais a dependencia dela
             ela recebe o objeto instanciado e atribui automaticamente*/
            _taxService = taxService;
        }

        public void ProcessInvoice(CarRental carRental) //Processar nota de pagamento
        {
            //Gera uma nota de pagamento Invoice
            TimeSpan duration = carRental.Finish.Subtract(carRental.Start);
            double basicPayment = 0.0;
            if(duration.TotalHours <= 12.0)
            {
                basicPayment = PricePerHour * Math.Ceiling(duration.TotalHours);
            }
            else
            {
                basicPayment = PricePerDay * Math.Ceiling(duration.TotalDays);
            }
            double tax = _taxService.Tax(basicPayment);
            carRental.Invoice = new Invoice(basicPayment, tax);
        }
    }
}
