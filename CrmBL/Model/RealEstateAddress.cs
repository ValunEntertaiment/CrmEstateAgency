﻿using System.Collections.Generic;

namespace CrmBL.Model
{
    abstract class RealEstateAddress
    {
        public int RealEstateAddressId { get; set; }
        public HouseInfo HouseInfo { get; set; }
        public LandInfo LandInfo { get; set; }
        public ApartmentInfo ApartmentInfo { get; set; }

        public string City { get; set; }

        public string Street { get; set; }

        public string House { get; set; }

        public string Number { get; set; }

        public virtual ICollection<Supply> Supplies { get; set; }

        public override string ToString()
        {
            return $"Город {City}, улица {Street}, дом {House}, номер квартиры {Number}.";
        }
    }
}
