using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp7.Database
{
    public class Account
    {
        [Key]
        public Guid MyProperty { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }    
    }
}
