using Excecoes2.Entities.Exceptions;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Excecoes2.Entities {
    class Account {
        public int Numero { get; set; }
        public string Proprietario { get; set; }
        public double Saldo { get; set; }
        public double LimitedeSaque{ get; set; }

        public Account() {

        }
        public Account(int numero, string proprietario, double balance, double limitedeSaque) {
            Numero = numero;
            Proprietario = proprietario;
            Saldo = balance;
            LimitedeSaque = limitedeSaque;
        }

        public void Depositar(double quantia) {
         
            Saldo += quantia;
        }
        public void Saque(double quantia) {
            if(quantia > LimitedeSaque) {
                throw new DomainException("Erro de saque: A quantia excedeu o limite de saque");
            }
            else if(quantia > Saldo) {
                throw new DomainException("Erro de saque: Não tem saldo suficiente");
            }
            Saldo -= quantia;
        }
        public override string ToString() {
            return "Novo saldo: $" + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
