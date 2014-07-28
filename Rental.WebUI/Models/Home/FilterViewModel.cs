﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Rental.WebUI.Models.Enums;

namespace Rental.WebUI.Models.Home
{
    public class FilterViewModel
    {
        [DataType(DataType.Currency)]
        public decimal MinPrice { get; set; }

        [DataType(DataType.Currency)]
        public decimal MaxPrice { get; set; }

        [RegularExpression("[0-9]{1,}", ErrorMessage = "it should be positive integer")]
        public int MinFootage { get; set; }

        [RegularExpression("[0-9]{1,}", ErrorMessage = "it should be positive integer")]
        public int MaxFootage { get; set; }

        public AdvertTypeViewModel AdvertType { get; set; }
    }
}