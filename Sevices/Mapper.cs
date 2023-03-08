using AutoMapper;
using BaseModel;
using Sevices.ViewModels.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sevices
{
    public class Mapper: Profile
    {
        public Mapper()
        {
            CreateMap<UserViewModel, User>().ReverseMap();
        }
    }
}
