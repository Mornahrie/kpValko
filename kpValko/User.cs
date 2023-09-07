using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace kpValko
{
    public partial class User
    {
        [Key]
        public int userID { get; set; }
        public string name { get; set; }
        public string surname { get; set; }
        public string email { get; set; }
        public string date_of_birth { get; set; }
        public string phone_number { get; set; }
        public string login { get; set; }
        public string password { get; set; }
    }
}
