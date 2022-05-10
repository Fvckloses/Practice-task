using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1.DataBase
{
    public class Seasons
    {
        [Key]
        public int idSeason { get; set; }
        public DateTime SeasonDateStart { get; set; }
        public DateTime SeasonDateEn { get; set; }
        public DateTime SeasonDateClose { get; set; }
        [ForeignKey("Tours")]
        public int idTour { get; set; }
    }
}
