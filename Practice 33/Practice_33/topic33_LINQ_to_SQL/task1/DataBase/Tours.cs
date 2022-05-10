using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Sqlite;

namespace task1.DataBase
{
    public class Tours
    {
        [Key]
        public int idTour { get; set; }
        public string TourName { get; set; }
        public int TourPrice { get; set; }
        public string TourInfo { get; set; }
    }
}
