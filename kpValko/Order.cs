using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace kpValko
{
    public partial class Order
    {
        [Key]
        public int orderID { get; set; }
        public int carID { get; set; }
        public int userID { get; set; }
        public string data { get; set; }
        public string order_state { get; set; }
    }
}
