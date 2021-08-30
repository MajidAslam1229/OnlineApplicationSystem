using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineJobApplication.Services.Common
{
    public static class ControllerExtension
    {
        public static string GetUserId(this ControllerBase controllerBase)
        {
            return controllerBase.HttpContext.User.Claims.First(i => i.Type == JwtRegisteredClaimNames.Jti).Value;
        }

    }
}
