
using System.Diagnostics.Tracing;

namespace RxCloseAPI.Services
{
    public class UserService : IUserService
    {
        private static readonly List<User> _users = [
     new User {
          Id=1,
          PhoneNumber=100,
          Name="Name1",
          Password="123",
          Email="mo@gmail.com",
          Location="Assiut"
      }
   ];
        public IEnumerable<User> GetAll()
        {
            return _users;
        }
        public User? Get(int id)
        {
            return _users.SingleOrDefault(x => x.Id == id);
        }

        public User Add(User user)
        {
            user.Id = _users.Count + 1;
            _users.Add(user);
            return user;
        }
    }
}
