using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Cards.Models
{
    public class Card
    {
        public int ID { get; set; }
        public string CardName { get; set; }
        public string Value { get; set; }
        public string Color { get; set; }
    }
}