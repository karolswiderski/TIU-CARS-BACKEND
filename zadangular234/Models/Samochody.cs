using System;
using System.ComponentModel.DataAnnotations;

namespace zadangular234.Models
{
    public class Samochody
    {
        [Key]
        public Guid Id { get; set; }
        public string Marka { get; set; }
        public string Model { get; set; }
        public string KM { get; set; }
        public string Silnik { get; set; }
        public string Sciezka { get; set; }
    }
}
