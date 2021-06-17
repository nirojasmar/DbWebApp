using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DbWebApplication.Models
{
    public class UserModel
    {
        [Key]
        public int Id { get; set; }
        public String Name { get; set; }
        [DataType(DataType.Date)]
        public DateTime Birthday { get; set; }
    }
}
