using System;

namespace PriceInformation.Repository.Entities
{
    public class Product
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Store { get; set; }

        public string Type { get; set; }

        public string Price { get; set; }

        public string Quantity { get; set; }

        public DateTime Date { get; set; }
    }
}
