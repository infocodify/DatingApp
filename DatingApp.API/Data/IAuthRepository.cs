using System.Threading.Tasks;
using DatingApp.API.Models;

namespace DatingApp.API.Data
{
    public interface IAuthRepository
    {
         // Methods that has to support
         Task<User> Register(User user, string password);

         Task<User> Login(string username, string password);
         
         Task<bool> UserExists(string username);
    }
}