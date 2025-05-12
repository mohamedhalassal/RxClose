
using RxCloseAPI.Models;
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

        public bool Update(int id, User user)
        {
            var currentUser = Get(id);

            if (currentUser is null)
                return false;

            currentUser.PhoneNumber = user.PhoneNumber;
            currentUser.Name = user.Name;
            currentUser.Password = user.Password;
            currentUser.Email = user.Email;
            currentUser.Location = user.Location;
            return true;
        }

        public bool Delete(int id)
        {
            var User = Get(id);

            if (User is null)
                return false;

            _users.Remove(User);
            return true;
        }
    }
}
