using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Eve.Web.ViewModels
{
    public class LoginViewModel
    {
        [Required]
        [DataType(DataType.Text)]
        public string username { get; set; }
        
        [Required]
        [DataType(DataType.Password)]
        public string password { get; set; }
    }
}
