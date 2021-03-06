﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MovieMix.Models
{
    public class MembershipType
    {
      
        public byte Id { get; set; }
        [Required]
        public short SignupFree { get; set; }
        public byte DurationInMonths { get; set; }
        public byte DiscountRate { get; set; }
        public String MemberShipTypeName { get; set; }

        public static readonly byte Unkown = 0;
        public static readonly byte PayAsYouGo = 1;
     
        

    }
}