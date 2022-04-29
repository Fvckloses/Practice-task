using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Form_26_1_.models
{
    public class Parking
    {
        public string Mark { get; set; }
        public string Year { get; set; }
        public int Date { get; set; }
        public override string ToString()
        {
            return new StringBuilder().AppendLine($"Марка автомобиля {Mark}")
                .AppendLine($"\tГод выпуска {Year}")
                .AppendLine($"Кол-во дней аренды {Date}").ToString();
        }
    }
}
