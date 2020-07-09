using System;


namespace _Interface1_.services
{
    class BrazilTaxService //Servico de imposto do brasil
    {
        public double Tax(Double amount) { 
            if(amount <= 100.0)
            {
                return amount * 0.2;
            }
            else
            {
                return amount * 0.15;
            }
        }
    }
}
