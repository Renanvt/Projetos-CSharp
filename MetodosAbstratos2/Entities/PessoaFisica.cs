using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;
namespace Entities{
    class PessoaFisica : Pessoa
    {
       
        //public double Imposto { get; set; }
      
        public double GastosComSaude { get; set; }
        
         public PessoaFisica( string nome, double rendaAnual, double gastosComSaude)
         :base(nome,rendaAnual)
        {
            GastosComSaude = gastosComSaude;
        }
        public override double TotImposto(){
            if(GastosComSaude > 0.0){
                if(base.RendaAnual <2000.00){
                    base.RendaAnual += base.RendaAnual * 0.1 ;
                    base.RendaAnual -= base.GastosComSaude * 0.5;
                }else{
                    base.RendaAnual += base.RendaAnual * 0.2;
                    base.RendaAnual -= base.GastosComSaude * 0.5;
                }
            }else{
                if(base.RendaAnual <2000.00){
                    base.RendaAnual += base.RendaAnual * 0.1 ;
                }else{
                    base.RendaAnual += base.RendaAnual * 0.2;
                }
            }
        }

    }
}