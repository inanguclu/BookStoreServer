using BookStoreServer.WebApi.Models;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace BookStoreServer.WebApi.Services;

public static class JwtService
{
    public static string CreateToken(User user)
    {
        var claims = new Claim[]
        {

        };

        JwtSecurityToken handler = new(
            issuer: "Issuer",
            audience: "Audience",
            claims: claims,
            notBefore:DateTime.Now,
            expires:DateTime.Now.AddDays(1),
            signingCredentials:new SigningCredentials(new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_jwtOptions.SecretKey)),

        string token=string.Empty;
        return token;


    }
    

}
