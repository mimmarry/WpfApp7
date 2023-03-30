using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp7.Database
{
    
    public class Bill
    {
        [Key]
        public Guid IdBill { get; set; }
        public Account? Account { get; set; }    
        public decimal Balance { get; set; }
    }
}
