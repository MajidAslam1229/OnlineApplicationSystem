using AutoMapper;
using CleanStructure.Data.Database.Tables;
using CleanStructure.Models;
using CleanStructure.Models.DTOs;
using CleanStructure.Services.Common;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace CleanStructure.Controllers.Authentication
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : Controller
    {
        #region Fields
        private readonly UserManager<ApplicationUser> userManager;
        private readonly RoleManager<ApplicationRole> roleManager;
        private readonly CommonService _commonService;
        private readonly IConfiguration _configuration;

        #endregion

        #region Constructor
        public AuthController(UserManager<ApplicationUser> userManager, RoleManager<ApplicationRole> roleManager, IConfiguration configuration, IMapper mapper)
        {
            this.userManager = userManager;
            this.roleManager = roleManager;
            _configuration = configuration;
            _commonService = new CommonService(mapper);
        }
        #endregion

        #region Login
        [HttpPost]
        [Route("login")]
        public async Task<IActionResult> Login([FromBody] UserLoginDTO model)
        {
            try
            {
                using (var db = new DuDbContext())
                {
                    var authClaims = new List<Claim>();
                    string Name = "";

                    ApplicationUser user = await userManager.FindByNameAsync(model.UserName);

                    if (user != null && await userManager.CheckPasswordAsync(user, model.Password))
                    {
                        var userRoles = await userManager.GetRolesAsync(user);

                        var authSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["JWT:Secret"]));

                        var token = new JwtSecurityToken(
                            issuer: _configuration["JWT:ValidIssuer"],
                            audience: _configuration["JWT:ValidAudience"],
                            expires: DateTime.Now.AddDays(7),
                            claims: authClaims,
                            signingCredentials: new SigningCredentials(authSigningKey, SecurityAlgorithms.HmacSha256)
                        );

                        return Ok(new
                        {
                            token = new JwtSecurityTokenHandler().WriteToken(token),
                            expiration = token.ValidTo.AddDays(365),
                            user,
                            userRoles,
                            Name
                        });

                    }

                    return Unauthorized();
                }
            }
            catch (Exception ex)
            {
                return BadRequest(UtilService.GetExResponse<Exception>(ex));
            }



        }

        #endregion

        #region Register

        [HttpPost]
        [Route("register")]
        public async Task<IActionResult> Register([FromBody] UserRegisterDTO model)
        {
            try
            {
                var userExists = await userManager.FindByNameAsync(model.UserName);
                //Duplicate Check
                if (userExists != null)
                    return Ok(new { Status = "Warning", Message = "User Already Exists!" });


                ApplicationUser user = new ApplicationUser()
                {
                    PhoneNumber = model.PhoneNumber,
                    Email = model.Email,
                    SecurityStamp = Guid.NewGuid().ToString(),
                    UserName = model.UserName
                };


                ///
                var result = await userManager.CreateAsync(user, model.Password);
                if (!result.Succeeded)
                    return StatusCode(StatusCodes.Status500InternalServerError, new { IsException = true, Message = "User creation failed! Please check user details and try again." });

                return Ok(new { IsException = false, Message = "User Created Successfully!" });
            }
            catch (Exception ex)
            {
                return BadRequest(UtilService.GetExResponse<Exception>(ex));
            }

        }

        #endregion


    }
}
