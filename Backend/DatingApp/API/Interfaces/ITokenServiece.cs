using API.Models;

namespace API.Interfaces
{
    public interface ITokenServiece
    {
        string CreateToken(User user);
    }
}
