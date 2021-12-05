using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace iao.Models
{
    public class Item
    {
        [Key]
        public int Id { get; set; }
        public int Borrower { get; set; }
    }
}
