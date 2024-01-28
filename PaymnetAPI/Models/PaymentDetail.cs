﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PaymnetAPI.Models
{
    public class PaymentDetail
    {

        [Key]
        public int PaymentDetailId { get; set; }

        
        public string CardOwnerName { get; set; }

       
        public string CardNumber { get; set; }

       
        public string ExpirationDate { get; set; }

       
        public string SecurityCode {get;set;}
    }
}
