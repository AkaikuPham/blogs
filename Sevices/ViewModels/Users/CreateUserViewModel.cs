using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sevices.ViewModels.Users
{
    public class CreateUserViewModel
    {
        public int Id { get; set; }

        [MinLength(3, ErrorMessage = "Phai lon hon 3 ky tu")]
        public string Name { get; set; }
    }
}
