using AutoMapper;
using BaseModel;
using Repositories;
using Sevices.ViewModels.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sevices
{
    public class UserService: IUserService
    {
        public readonly IUnitOfWork _unitOfWork;
        public readonly IMapper _mapper;
        public UserService(IUnitOfWork unitOfWork, IMapper mapper) {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public UserViewModel GetUserById(int Id)
        {
            User user = _unitOfWork.UserRepository.GetUser(Id);

            //var result = new UserViewModel();
            //result.Id = user.Id;
            //result.Name = user.Name;
            //result.Blogs = user.Blogs;

            var result = _mapper.Map<UserViewModel>(user);

            return result;
        }
    }
}
