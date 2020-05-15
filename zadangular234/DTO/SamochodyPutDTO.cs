using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace zadangular234.DTO
{
    public class SamochodyPutDTO
    {
        public Guid Id { get; set; }
        public string Marka { get; set; }
        public string Model { get; set; }
        public string KM { get; set; }
        public string Silnik { get; set; }
        public string Sciezka { get; set; }
    }
}
