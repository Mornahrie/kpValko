using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kpValko
{
    public partial class PreOrder
    {
        [Key]
        public int preorderID { get; set; }
        public int carID { get; set; }
        public int userID { get; set; }
        public string data { get; set; }
        public string state { get; set; }
    }
}
