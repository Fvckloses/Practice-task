using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1.DataBase
{
    public class Payment
    {
        [Key]
        public int idPayment { get; set; }
        public DateTime Country { get; set; }
        public int PaymentCost { get; set; }
        [ForeignKey("TouristsInfo")]
        public int idVoucher { get; set; }
    }
}
