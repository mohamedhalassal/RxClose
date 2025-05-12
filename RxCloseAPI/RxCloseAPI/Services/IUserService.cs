namespace RxCloseAPI.Services
{
    public interface IUserService
    {
        IEnumerable<User> GetAll();
        User? Get(int id);
        User Add(User user);

        bool Update(int id, User user);
    }
}
