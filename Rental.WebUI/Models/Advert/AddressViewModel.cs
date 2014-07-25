﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Rental.WebUI.Models.Advert
{
    public class AddressViewModel
    {
        [Required]
        public string Country { get; set; }

        [Required]
        public string City { get; set; }

        [Required]
        public string Distrcit { get; set; }

        [Required]
        public string Street { get; set; }
    }
}