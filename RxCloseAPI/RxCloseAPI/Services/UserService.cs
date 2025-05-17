
using System.Threading;

namespace RxCloseAPI.Services;

public class UserService(RxCloseDbContext context) : IUserService
{
    private readonly RxCloseDbContext _context = context;
    public async Task<IEnumerable<User>> GetAllAsync(CancellationToken cancellationToken = default) => 
        await _context.users.AsNoTracking().ToListAsync(cancellationToken);

    public async Task<User?> GetAsync(int id, CancellationToken cancellationToken = default) =>
       await _context.users.FindAsync(id, cancellationToken);

    public async Task<User> AddAsync(User user, CancellationToken cancellationToken = default)
    {
        await _context.AddAsync(user, cancellationToken);
        await _context.SaveChangesAsync(cancellationToken);
        return user;
    }

    public async Task<bool> UpdateAsync(int id, User user, CancellationToken cancellationToken = default)
    {
        var currentUser =await GetAsync(id, cancellationToken);

        if (currentUser is null)
            return false;

        currentUser.PhoneNumber = user.PhoneNumber;
        currentUser.Name = user.Name;
        currentUser.UserName = user.UserName;
        currentUser.Password = user.Password;
        currentUser.Email = user.Email;
        currentUser.Location = user.Location;

        await _context.SaveChangesAsync(cancellationToken);
        return true;
    }

    public async Task<bool> DeleteAsync(int id, CancellationToken cancellationToken = default)
    {
        var User =await GetAsync(id, cancellationToken);

        if (User is null)
            return false;

        _context.Remove(User);

        await _context.SaveChangesAsync(cancellationToken);
        return true;
    }
}
