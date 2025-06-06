namespace RxCloseAPI.Services
{
    public interface IPharmecyService
    {
        Task<IEnumerable<Pharmecy>> GetAllAsync(CancellationToken cancellationToken = default);
        Task<Pharmecy?> GetAsync(int id, CancellationToken cancellationToken = default);
        Task<Pharmecy> AddAsync(Pharmecy user, CancellationToken cancellationToken=default);

        Task<bool> UpdateAsync(int id, Pharmecy user, CancellationToken cancellationToken = default);

        Task<bool> DeleteAsync(int id, CancellationToken cancellationToken = default);
    }
}
