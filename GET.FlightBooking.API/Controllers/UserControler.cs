using GET.FlightBooking.API.Adapters.Commands.UserCommands;
using GET.FlightBooking.Domain.Models;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GET.FlightBooking.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserControler : Controller
    {
        private readonly IMediator _mediator;

        public UserControler(IMediator mediator)
        {
            _mediator = mediator;
        }



        // GET: UserControler/register
        [HttpPost("register")]
        public async Task<IActionResult> RegisterAsync(UserModel userModel)
        {

            var command = new CreateUserCommand(userModel);
            var user = await _mediator.Send(command);

            return user != null ? Ok(user) : NotFound();

        }




    }
}
