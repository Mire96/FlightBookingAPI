using GET.FlightBooking.Data.Database;
using GET.FlightBooking.Data.Entities;
using GET.FlightBooking.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GET.FlightBooking.Data.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly AppDbContext _context;

        public UserRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<User> CreateUserAsync(User newUserEntity)
        {
            try
            {
                User userEntity = null;
                userEntity = _context.Users.SingleOrDefault(u => (u.UserName == newUserEntity.UserName && u.Password == newUserEntity.Password));
                if (userEntity != null && userEntity.UserName == newUserEntity.UserName)
                {
                    return null;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            _context.Users.Add(newUserEntity);
            await _context.SaveChangesAsync();
            return newUserEntity;
        }
    }
}
