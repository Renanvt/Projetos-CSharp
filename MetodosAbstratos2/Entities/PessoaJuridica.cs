using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Entities{
    class PessoaJuridica : Pessoa
    {
       
        //public double Imposto { get; set; }
        public int NumeroDeFunc { get; set; }
        public PessoaJuridica()
        {

        }
         public PessoaJuridica( string nome, double rendaAnual, int numerodeFunc)
         :base(nome,rendaAnual)
        {
            NumeroDeFunc = numerodeFunc;
        }
    
        public override double TotImposto(){
            if(NumeroDeFunc > 10){
               return RendaAnual* 0.14;
            }else{
                return RendaAnual * 0.16;
                
            }
        }

    }
}