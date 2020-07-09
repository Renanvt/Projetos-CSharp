using System;


namespace _SemInterface2_.services
{
    //Implementacao da interface
    class BrazilTaxService : ITaxService
    {
        public double Tax(double amount)
            //O Tax irá substituir o Tax da interface
        {
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
