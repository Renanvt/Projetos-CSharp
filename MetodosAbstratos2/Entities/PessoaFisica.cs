using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;
namespace Entities{
    class PessoaFisica : Pessoa
    {
       
        //public double Imposto { get; set; }
      
        public double GastosComSaude { get; set; }
        
        public PessoaFisica()
        {

        }
         public PessoaFisica( string nome, double rendaAnual, double gastosComSaude)
         :base(nome,rendaAnual)
        {
            GastosComSaude = gastosComSaude;
        }
        public override double TotImposto(){
                if(RendaAnual <20000.0){
                    return RendaAnual * 0.15 - GastosComSaude * 0.5;
                }else{
                   return RendaAnual * 0.25 - GastosComSaude * 0.5;
                
            }
        }

    }
}