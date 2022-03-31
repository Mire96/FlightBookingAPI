using GET.FlightBooking.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GET.FlightBooking.Domain.Interfaces
{
    public interface IUserService
    {
        Task<UserModel> CreateUserAsync(UserModel userModel);
    }
}
