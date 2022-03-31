using GET.FlightBooking.Domain.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GET.FlightBooking.API.Adapters.Commands.UserCommands
{
    public class CreateUserCommand : IRequest<UserModel>
    {
        public UserModel userModel { get; set; }
        public CreateUserCommand(UserModel userModel)
        {
            this.userModel = userModel;
        }
    }
}
