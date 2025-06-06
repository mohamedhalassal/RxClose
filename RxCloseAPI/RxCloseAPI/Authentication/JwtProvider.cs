
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace RxCloseAPI.Authentication;

public class JwtProvider : IJwtProvider
{
    public (string token, int expiresIn) GnerateToken(User user)
    {
        Claim[] claims = [
            new(JwtRegisteredClaimNames.Sub,user.Id),
            new(JwtRegisteredClaimNames.Email,user.Email!),
            new(JwtRegisteredClaimNames.GivenName,user.FirstName!),
            new(JwtRegisteredClaimNames.FamilyName,user.LastName!),
            new(JwtRegisteredClaimNames.Jti,Guid.NewGuid().ToString())
        ];

        // encryptions and coding,decoding
        var symmetricSecurityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("yP5fNeueTtIgDSzDD6yQiCxCZ1fgaOly"));

        //key 
        var signingCredentials = new SigningCredentials(symmetricSecurityKey, SecurityAlgorithms.HmacSha256);

        //
        var expieresIn = 30;

        var token = new JwtSecurityToken(
            issuer:"RxCloseApp",
            audience: "RxCloseApp users",
            claims: claims,
            expires: DateTime.UtcNow.AddMinutes(expieresIn),
            signingCredentials:signingCredentials
        );
        return (token: new JwtSecurityTokenHandler().WriteToken(token), expieresIn: expieresIn*60);
    }
}
