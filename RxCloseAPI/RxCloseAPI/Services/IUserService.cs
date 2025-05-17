namespace RxCloseAPI.Services
{
    public interface IUserService
    {
        Task<IEnumerable<User>> GetAllAsync(CancellationToken cancellationToken = default);
        Task<User?> GetAsync(int id, CancellationToken cancellationToken = default);
        Task<User> AddAsync(User user, CancellationToken cancellationToken=default);

        Task<bool> UpdateAsync(int id, User user, CancellationToken cancellationToken = default);

        Task<bool> DeleteAsync(int id, CancellationToken cancellationToken = default);
    }
}
