
namespace RxCloseAPI.Services
{
    public class UserService : IUserService
    {
        private readonly List<User> _users = [
     new User {
          Id=1,
          PhoneNumber=100,
          Name="Ahmed",
          Password="123",
          Email="mo@gmail.com"
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

        
    }
}
