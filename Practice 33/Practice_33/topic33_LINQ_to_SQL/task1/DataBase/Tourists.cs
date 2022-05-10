using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1.DataBase
{
    public class Tourists
    {
        [Key]
        public int idTourists { get; set; }
        public string TouristsLastName { get; set; }
        public string TouristsFirstName { get; set; }
        public string TouristsMidleName { get; set; }
        public virtual TouristsInfo TouristsInfo { get; set; }
        public int idTouristsInfo { get; set; }
    }
}
