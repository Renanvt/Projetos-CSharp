using System;
using System.Collections.Generic;
using System.Text;
namespace Entities{
   sealed class OutsourceEmployee : Employee
    {
    
        public double AdditionalCharge {get;set;} //Despesa adicional

        public OutsourceEmployee(){

        }
        public OutsourceEmployee(string name, int hours, double valuePerHour,double additionalCharge)
        : base(name, hours, valuePerHour, additionalCharge)
        {
            AdditionalCharge = additionalCharge;
        }

      public override double Payment(){
          return base.Payment() + AdditionalCharge * 1.1;
          //return AdditionalCharge * 0.11;
      }

    }
}