﻿using System;
using System.Collections.Generic;
using System.Text;
using ExcecoesPersonalizadas.Entities.Exceptions;

namespace ExcecoesPersonalizadas.Entities
{
    class Reservation
    {
        public int RoomNumber { get; set; }
        public DateTime Checkin { get; set; }
        public DateTime Checkout { get; set; }
        public Reservation() {

        }

        public Reservation(int roomNumber, DateTime checkin, DateTime checkout)
        {
            if (checkout <= checkin) 
            {
                throw new DomainException("Erro na reserva, a data de checkout tem que ser depois da data de checkin");
            }
            RoomNumber = roomNumber;
            Checkin = checkin;
            Checkout = checkout;
        }

        public int Duration()
        {
            //Pega a diferença entre um estante e outro
            TimeSpan duration = Checkout.Subtract(Checkin);
            return (int) duration.TotalDays;
        }
        public void UpdateDates(DateTime checkin, DateTime checkout)
        {
            DateTime now = DateTime.Now;
            if (checkin < now || checkout < now)
            {
                //throw é como se fosse o return
                throw new DomainException("A data reserva para atualização tem que ser datas futuras");
            }
            else if (checkout <= checkin)
            {
                throw new DomainException("Erro na reserva, a data de checkout tem que ser depois da data de checkin");
            }

            Checkin = checkin;
            Checkout = checkout;
            //INDICA QUE A FUNCAO NÃO TEVE ERROS
            //return null;
        }
        public override string ToString()
        {
            return $"Reservation: Quarto {RoomNumber}, check-in: " +
                $"{Checkin.ToString("dd/MM/yyyy")}, check-out: {Checkout.ToString("dd/MM/yyyy")}, {Duration()} noites";
        }
    }
}
