using Proiect.Models.User;

namespace Proiect.Helper.JwtUtils
{
    public interface IJwtUtils
    {
        public string GenerateJwtToken(User user);
        public Guid ValidateJwtToken(string token);
    }
}
