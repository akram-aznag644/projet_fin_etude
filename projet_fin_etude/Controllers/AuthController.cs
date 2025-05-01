using System.Net;
using System.Security.Cryptography;
using System.Text;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NuGet.Common;
using projet_fin_etude.Data;
using projet_fin_etude.Models;
using projet_fin_etude.Services;

namespace projet_fin_etude.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly MyAppDbContext _context;
        private readonly IMapper _mapper;
        private readonly JwtService _jwtService;

        public AuthController(MyAppDbContext context, IMapper mapper, JwtService jwtService)
        {
            _context = context;
            _mapper = mapper;
            _jwtService = jwtService;
        }

        [HttpPost("register")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<ApiResponse>> Register([FromBody] RegisterDTO request)
        {
            // Check if username already exists
            var existingUser = await _context.Users.FirstOrDefaultAsync(u => u.Username == request.Username);

            if (existingUser != null)
            {
                return BadRequest("Username is already taken.");
            }

            // Validate ModelState
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

          
           
            User user = null;
            if (request.Role == "Admin")
            {
                user = _mapper.Map<Admin>(request);
            }
            else if (request.Role == "JobApplicant")
            {
                user = _mapper.Map<JobApplicant>(request);
            }
            else if (request.Role == "Employer")
            {
                user = _mapper.Map<Employer>(request);
            }
            else
            {
                return NotFound("Invalid role.");
            }

            var hasher = new PasswordHasher<User>();
            user.Password = hasher.HashPassword(user, request.Password);

            await _context.Users.AddAsync(user);
            await _context.SaveChangesAsync();
            var response = new ApiResponse
            {
                Status = true,
                StatusCode = HttpStatusCode.OK,
                Data = new { user.Id, user.Username, user.Email, user.Role}
            };
            return Ok();
        }

        [HttpPost("login")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]

        public async Task<ActionResult<ApiResponse>> Login([FromBody] LoginDTO request)
        {
            if (request == null)  {
                return BadRequest();
            }

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var user = await _context.Users
                .FirstOrDefaultAsync(e => e.Username == request.Login || e.Email == request.Login);

            if (user == null)
            {
                return NotFound("No user is found with this login.");
            }

            if (!VerifyPassword(user, request.Password))
            {
                return Unauthorized("The username or password is invalid.");
            }

            var token = _jwtService.GenerateToken(user);
            var response = new ApiResponse
            {
                Status = true,
                StatusCode = HttpStatusCode.OK,
                Data = new { user.Id, user.Username, user.Email, user.Role,  token }
            };

            return Ok(response);
        }


       
        private bool VerifyPassword(User user, string password)
        {
            var hasher = new PasswordHasher<User>();
            var result = hasher.VerifyHashedPassword(user, user.Password, password);
            return result == PasswordVerificationResult.Success;
        }

    }
}
