using Sevices.ViewModels;
using Sevices.ViewModels.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sevices
{
    public interface IUserService
    {
        public UserViewModel GetUserById(int id);

        public ResponseResult<CreateUserViewModel> Create(UserViewModel user);
    }
}
