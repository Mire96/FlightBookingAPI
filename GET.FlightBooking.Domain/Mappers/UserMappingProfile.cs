using AutoMapper;
using GET.FlightBooking.Data.Entities;
using GET.FlightBooking.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GET.FlightBooking.Domain.Mappers
{
    public class UserMappingProfile : Profile
    {
        public UserMappingProfile()
        {
            CreateMap<UserModel, User>().ReverseMap();
        }
    }
}
