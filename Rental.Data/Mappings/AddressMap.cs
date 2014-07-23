﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rental.Models.Entities;

namespace Rental.Data.Mappings
{
    public class AddressMap : EntityTypeConfiguration<Address>
    {
        public AddressMap()
        {
            // Table & Column Mappings
            this.ToTable("Address");
            this.Property(x => x.AdvertId).HasColumnName("AdvertId");

            // Primary Key
            this.HasKey(x => x.AdvertId);

            // Properties
            this.Property(x => x.AdvertId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            this.Property(x => x.Country).HasMaxLength(64).IsRequired();
            this.Property(x => x.City).HasMaxLength(64).IsRequired();
            this.Property(x => x.District).HasMaxLength(128).IsRequired();
            this.Property(x => x.Street).HasMaxLength(128).IsRequired();

            // Advert one-to-one Address
            this.HasRequired(a => a.Advert)
                .WithRequiredDependent(a => a.Address);
        }
    }
}
