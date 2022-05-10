using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1.DataBase
{
    public class Vouchers
    {
        [Key]
        public int idVoucher { get; set; }
        [ForeignKey("TouristsInfo")]
        public int idTouristsInfo { get; set; }
        [ForeignKey("Seasons")]
        public int idSeason { get; set; }
    }
}
