using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace kpValko
{
    public partial class Car
    {
        [Key]
        public int carID { get; set; }
        public string model { get; set; }
        public string country { get; set; }
        public int year { get; set; }
        public string fuel { get; set; }
        public string color { get; set; }
        public string state { get; set; }
    }
}
