using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;
using Entities;
namespace Entities{
    class PessoaJuridica : Pessoa
    {
       
        //public double Imposto { get; set; }
        public int NumeroDeFunc { get; set; }
         public PessoaJuridica( string nome, double rendaAnual, int numerodeFunc)
         :base(nome,rendaAnual)
        {
            NumeroDeFunc = numerodeFunc;
        }
    
        public override double TotImposto(){
            if(NumeroDeFunc <= 10){
                base.RendaAnual += base.RendaAnual * 0.6;
            }else{
                base.RendaAnual += base.RendaAnual * 0.4;
            }
        }

    }
}