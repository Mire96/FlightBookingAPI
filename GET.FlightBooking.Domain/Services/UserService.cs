using AutoMapper;
using GET.FlightBooking.Data.Entities;
using GET.FlightBooking.Data.Interfaces;
using GET.FlightBooking.Domain.Interfaces;
using GET.FlightBooking.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GET.FlightBooking.Domain.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository userRepository;
        private readonly IMapper mapper;

        public UserService(IUserRepository userRepository, IMapper mapper)
        {
            this.userRepository = userRepository;
            this.mapper = mapper;
        }

        public async Task<UserModel> CreateUserAsync(UserModel userModel)
        {
            var newUserEntity = mapper.Map<UserModel, User>(userModel);
            var createdUserEntity = await userRepository.CreateUserAsync(newUserEntity);

            var createdUserModel = mapper.Map<User, UserModel>(createdUserEntity);
            return createdUserModel;
        }
    }
}
