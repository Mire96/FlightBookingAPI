using GET.FlightBooking.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GET.FlightBooking.Data.Interfaces
{
    public interface IUserRepository
    {
        Task<User> CreateUserAsync(User newUserEntity);
    }
}
