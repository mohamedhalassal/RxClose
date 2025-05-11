namespace RxCloseAPI.Services
{
    public interface IUserService
    {
        IEnumerable<User> GetAll();
        User? Get(int id);
        User Add(User user);
    }
}
