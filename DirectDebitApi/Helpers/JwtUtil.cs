using System;
using System.IdentityModel.Tokens.Jwt;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Caching.Distributed;
using Microsoft.IdentityModel.Tokens;

namespace DirectDebitApi.Helpers
{
    public interface IJwtUtil
    {
        string GenerateJwtToken(int id, string name);
        Task<bool> IsActiveAsync(string token);
        Task DeactivateAsync(string token);
    }

    public class JwtUtil : IJwtUtil
    {
        public const string SECRET_KEY = "2F6F84DBB9DAD3D861FCCDFB4EAF4577AC0853B79D1942238CFBE93A83E35CB8";
        public const int EXPIRY_IN_MINUTES = 60;
        private readonly IDistributedCache cache;

        public JwtUtil(IDistributedCache cache)
        {
            this.cache = cache;
        }

        public string GenerateJwtToken(int id, string name)
        {
            // Also note that securityKey length should be >256b (about 64 hexadecimal characters)
            // so you have to make sure that your private key has a proper length
            var signingKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(SECRET_KEY));
            var credentials = new SigningCredentials(signingKey, SecurityAlgorithms.HmacSha256);

            // Finally create a Token
            var header = new JwtHeader(credentials);

            // generate jwt payload
            DateTime expiry = DateTime.UtcNow.AddMinutes(EXPIRY_IN_MINUTES);
            int ts = (int)(expiry - new DateTime(1970, 1, 1)).TotalSeconds;
            var payload = new JwtPayload
            {
                { "Id", id },
                { "FullName", name },
                { "exp", ts }
            };

            var secToken = new JwtSecurityToken(header, payload);

            var handler = new JwtSecurityTokenHandler();

            var tokenString = handler.WriteToken(secToken); // security token

            return tokenString;
        }

        public async Task<bool> IsActiveAsync(string token)
        {
            //ensure that token has not been blacklisted
            return await cache.GetStringAsync(GetKey(token)) == null;
        }

        public async Task DeactivateAsync(string token)
        {
            //blacklist token
            await cache.SetStringAsync(GetKey(token), string.Empty, new DistributedCacheEntryOptions
            {
                AbsoluteExpirationRelativeToNow = TimeSpan.FromMinutes(EXPIRY_IN_MINUTES)
            });
        }

        private static string GetKey(string token) => token + "_key";
    }
}
