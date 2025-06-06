namespace RxCloseAPI.Services
{
    public class AuthService(UserManager<User> userManager, IJwtProvider jwtProvider) : IAuthService
    {
        private readonly UserManager<User> _userManager = userManager;
        private readonly IJwtProvider _jwtProvider = jwtProvider;

        public async Task<AuthResponse?> GetTokenAsync(string email, string password, CancellationToken cancellationToken = default)
        {
            //chick user?
            var user = await _userManager.FindByEmailAsync(email);

            if (user is null)
                return null;

            //check password
            var isValidPassword = await _userManager.CheckPasswordAsync(user, password);

            if (!isValidPassword)
                return null;

            //generate jwt token
            var (token, expiersIn) = _jwtProvider.GnerateToken(user);

            return new AuthResponse(user.Id, user.Email, user.FirstName, user.LastName, token, expiersIn);
        }
    }
}
