using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1.DataBase
{
    public class TouristsInfo
    {
        [Key]
        public int idTouristsInfo { get; set; }
        public string PassportSeries { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public int PhoneNumber { get; set; }
        public int Index { get; set; }
    }
}
