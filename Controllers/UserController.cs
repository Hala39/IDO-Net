using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Helpers;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    [AllowAnonymous]
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;
        private readonly TokenService _tokenService;
        private readonly DataContext _data;

        public UserController(
            UserManager<User> userManager, 
            SignInManager<User> signInManager,
            TokenService tokenService,
            DataContext data
        )
        {
            _signInManager = signInManager;
            _tokenService = tokenService;
            _data = data;
            _userManager = userManager;
        }

        [HttpPost("login")]
        public async Task<ActionResult<Result<UserCreds>>> Login(UserLoginDto creds) 
        {
            var user = await _userManager.Users
                    .FirstOrDefaultAsync(x => x.Email.ToLower() == creds.Email.ToLower());

            if (user == null) return Unauthorized("User Not Found!");

            var result = await _signInManager.CheckPasswordSignInAsync(user, creds.Password, false);

            if (result.Succeeded)
            {
                return Ok(CreateUserObject(user));
            }

            return Unauthorized("Wrong Password!");
        }

        [HttpGet]
        public async Task<ActionResult<List<User>>> GetUsers()
        {
            return await _data.Users.ToListAsync();
        }

        private UserCreds CreateUserObject(User user)
        {
            return new UserCreds
            {
                Id = user.Id,
                Email = user.Email,
                AccessToken = _tokenService.CreateToken(user)
            };
        }
    }
}